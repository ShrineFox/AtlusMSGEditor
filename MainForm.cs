using AtlusScriptCompiler;
using AtlusScriptLibrary.Common.Libraries;
using AtlusScriptLibrary.Common.Logging;
using AtlusScriptLibrary.Common.Text;
using AtlusScriptLibrary.Common.Text.Encodings;
using AtlusScriptLibrary.FlowScriptLanguage.Syntax;
using AtlusScriptLibrary.MessageScriptLanguage;
using AtlusScriptLibrary.MessageScriptLanguage.Compiler;
using AtlusScriptLibrary.MessageScriptLanguage.Decompiler;
using MetroSet_UI.Child;
using MetroSet_UI.Forms;
using Newtonsoft.Json;
using ShrineFox.IO;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace P5RStringEditor
{
    public partial class MainForm : MetroSetForm
    {
        public Encoding userEncoding = AtlusEncoding.Persona5RoyalEFIGS;

        public MainForm()
        {
            InitializeComponent();

            // Setup form appearance
            ApplyTheme();
            SetLogging();
            MenuStripHelper.SetMenuStripIcons(MenuStripHelper.GetMenuStripIconPairs("Icons.txt"), this);

            // Select first tab
            SetListBoxDataSource_ToTBL();
            tabControl_Files.SelectedIndex = -1;
            tabControl_Files.SelectedIndex = 0;
        }

        private void ImportMSGData(string DatMsgPakDir, bool useChanges = false)
        {
            if (!Directory.Exists(DatMsgPakDir))
                return;

                if (File.Exists(bmdPath))
                    DecompileBMD(bmdPath);

                if (File.Exists(msgPath))
                {
                    using (FileSys.WaitForFile(msgPath)) { }

                    string[] lines = File.ReadAllText(msgPath)
                        .Replace("[s]", "").Replace("[n]", "\r\n").Replace("[e]", "")
                        .Replace("[f 0 5 65278][f 2 1]", "")
                        .Split('\n');

                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (lines[i].StartsWith("[msg "))
                        {
                            int itemId = GetItemIdFromFlowscriptLine(lines[i], msgPath.Contains("Help") && !msgPath.Contains("Specific"));


                                string description = "";
                                for (int x = i + 1; x < lines.Length; x++)
                                {
                                    if (lines[x].Contains("[msg "))
                                    {
                                        i = x - 1;
                                        break;
                                    }

                                    description += lines[x] + "\n";
                                }

                                description = description.TrimEnd();
                            
                        }
                    }
                }
            
        }


        private void DecompileBMD(string bmdPath)
        {
            string outPath = FileSys.GetExtensionlessPath(bmdPath) + ".msg";

            AtlusScriptCompiler.Program.IsActionAssigned = false;
            AtlusScriptCompiler.Program.InputFilePath = bmdPath;
            AtlusScriptCompiler.Program.OutputFilePath = outPath;
            AtlusScriptCompiler.Program.MessageScriptEncoding = userEncoding;
            AtlusScriptCompiler.Program.MessageScriptTextEncodingName = userEncoding.EncodingName;
            AtlusScriptCompiler.Program.Logger = new Logger($"{nameof(AtlusScriptCompiler)}_{Path.GetFileNameWithoutExtension(outPath)}");
            AtlusScriptCompiler.Program.Listener = new FileAndConsoleLogListener(true, LogLevel.Info | LogLevel.Warning | LogLevel.Error | LogLevel.Fatal);

            AtlusScriptCompiler.Program.Main(new string[] { bmdPath,
                    "-Decompile", "-Library", "P5R", "-Encoding", comboBox_Encoding.SelectedItem.ToString(), "-Out", outPath });
        }


        private void CreateNewBMD(KeyValuePair<string, string> tblPair)
        {
            string tblName = tblPair.Key;
            string datName = tblPair.Value;

            // Get input/output paths
            string bmdName = "dat" + datName;
            if (datName != "Myth")
                bmdName += "Help";

            string inPath = Path.GetFullPath($".\\Dependencies\\P5RCBT\\DATMSGPAK\\{bmdName}.msg");
            string outDir = Path.GetFullPath(".\\Output\\p5r.tblmod\\FEmulator\\PAK\\INIT\\DATMSG.PAK");
            
            Directory.CreateDirectory(outDir + "\\h");
            Directory.Delete(outDir + "\\h"); // hack to create folder with extension in name
            string outPath = Path.Combine(outDir, $"{bmdName}.bmd");

            if (!File.Exists(inPath))
                return;

            List<string> newMsgLines = new List<string>();

            // Create .msg file with form data's description text
            for (int i = 0; i < tblSection.TblEntries.Count; i++)
            {
                if (bmdName.Contains("Help") && !bmdName.Contains("Specific"))
                    newMsgLines.Add($"[msg item_{i.ToString("X3")}]");
                else if (bmdName.Contains("Myth"))
                    newMsgLines.Add($"[msg myth_{i.ToString("D3")}]");
                else
                    newMsgLines.Add($"[msg specific_{i.ToString("D3")}]");

                string[] descLines = tblSection.TblEntries[i].Description.Split('\n');
                foreach (var line in descLines)
                    if (!string.IsNullOrEmpty(line) && !line.Equals("\r"))
                        newMsgLines.Add(line.Replace("\r", "[n]"));

                newMsgLines.Add("[e]");
                
            }

            // Save new .msg to output folder
            string msgPath = outPath.Replace(".bmd", ".msg");
            File.WriteAllLines(msgPath, newMsgLines);

            if (outputBMDToolStripMenuItem.Checked)
            {
                // HACK: Comment out mFileWriter lines in AtlusScriptCompiler/FileAndConsoleLogListener.cs
                // to prevent file access errors, at expense of no log output

                using (FileSys.WaitForFile(msgPath)) { }
                AtlusScriptCompiler.Program.IsActionAssigned = false;
                AtlusScriptCompiler.Program.InputFilePath = msgPath;
                AtlusScriptCompiler.Program.OutputFilePath = outPath;
                AtlusScriptCompiler.Program.MessageScriptEncoding = userEncoding;
                AtlusScriptCompiler.Program.MessageScriptTextEncodingName = userEncoding.EncodingName;
                AtlusScriptCompiler.Program.Logger = new Logger($"{nameof(AtlusScriptCompiler)}_{Path.GetFileNameWithoutExtension(outPath)}");
                AtlusScriptCompiler.Program.Listener = new FileAndConsoleLogListener(true, LogLevel.Info | LogLevel.Warning | LogLevel.Error | LogLevel.Fatal);

                AtlusScriptCompiler.Program.Main(new string[] { msgPath,
                    "-Compile", "-Library", "P5R", "-Encoding", comboBox_Encoding.SelectedItem.ToString(), "-OutFormat", "V1BE", "-Out", outPath });

                if (deleteOutputMSGToolStripMenuItem.Checked)
                {
                    using (FileSys.WaitForFile(msgPath)) { }
                    File.Delete(msgPath);
                }
            }
        }

        List<Change> Changes = new List<Change>();

        public class Change
        {
            public string FilePath { get; set; } = "";
            public string MessageName { get; set; } = "";
            public string MessageText { get; set; } = "";

        }
    }
}