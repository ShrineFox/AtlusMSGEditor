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

namespace AtlusMSGEditor
{
    public partial class MainForm : MetroSetForm
    {
        public Encoding userEncoding = AtlusEncoding.Persona5RoyalEFIGS;
        public string dumpInputPath = "";
        public string dumpOutPath = ".\\Dump";

        public MainForm()
        {
            InitializeComponent();

            // Setup form appearance
            ApplyTheme();
            SetLogging();
            MenuStripHelper.SetMenuStripIcons(MenuStripHelper.GetMenuStripIconPairs("Icons.txt"), this);

            comboBox_Encoding.SelectedIndex = 0;
        }

        List<Change> Changes = new List<Change>();

        public class Change
        {
            public string FilePath { get; set; } = "";
            public string MessageName { get; set; } = "";
            public string MessageText { get; set; } = "";

        }

        private void ImportBMDs_Click(object sender, EventArgs e)
        {
            string importDir = WinFormsDialogs.SelectFolder("Choose Extracted CPKs Directory");
            if (Directory.Exists(importDir))
            {
                dumpInputPath = importDir;

                Output.Log($"Dumping .BMDs from \"{dumpInputPath}\"...");
                ImportBMDs(Directory.GetFiles(dumpInputPath, "*", SearchOption.AllDirectories));
                Output.Log($"Done Dumping .BMDs to \"{dumpOutPath}\".");
                Output.Log($"Combining .MSGs in \"{dumpOutPath}\"...");
                CombineToTxt(dumpOutPath, ".msg");
                Output.Log($"Done Combining .MSGs.");
                Output.Log($"Combining .FLOWs in \"{dumpOutPath}\"...");
                CombineToTxt(dumpOutPath, ".flow");
                Output.Log($"Done Combining .FLOWs.");
            }
        }

        private void CombineToTxt(string directory, string extension)
        {
            string txt = "";

            foreach (var file in Directory.GetFiles(directory, $"*{extension}", SearchOption.AllDirectories))
            {
                txt += $"// {FileSys.GetExtensionlessPath(file)}\n";
                txt += File.ReadAllText(file) + "\n";
            }

            File.WriteAllText(extension.Replace(".","") + "Dump.txt", txt);
        }

        private void CombineMSGs()
        {
            throw new NotImplementedException();
        }

        private void ImportBMDs(string[] importFiles)
        {
            foreach (var file in importFiles)
            {
                switch (Path.GetExtension(file).ToLower())
                {
                    case ".bmd":
                    case ".bf":
                        DumpScript(file);
                        break;
                    case ".pak":
                    case ".pac":
                        ProcessPAC(file);
                        break;
                    default:
                        break;
                }
            }
        }

        private void ProcessPAC(string pacFile)
        {
            //throw new NotImplementedException();
        }

        private void DumpScript(string bmdPath)
        {
            string extension = ".msg";
            if (Path.GetExtension(bmdPath).ToLower() == ".bf")
                extension = ".flow";

            string outPath = bmdPath.Replace(dumpInputPath, dumpOutPath) + extension;
            Directory.CreateDirectory(Path.GetDirectoryName(outPath));

            InitializeScriptCompiler(bmdPath, outPath);

            AtlusScriptCompiler.Program.Main(new string[] { 
                bmdPath, "-Decompile", 
                "-Library", "P5R", 
                "-Encoding", comboBox_Encoding.SelectedItem.ToString(), 
                "-Out", outPath });
        }

        private void InitializeScriptCompiler(string inputPath, string outputPath)
        {
            AtlusScriptCompiler.Program.IsActionAssigned = false;
            AtlusScriptCompiler.Program.InputFilePath = inputPath;
            AtlusScriptCompiler.Program.OutputFilePath = outputPath;
            AtlusScriptCompiler.Program.MessageScriptEncoding = userEncoding;
            AtlusScriptCompiler.Program.MessageScriptTextEncodingName = userEncoding.EncodingName;
            AtlusScriptCompiler.Program.Logger = new Logger($"{nameof(AtlusScriptCompiler)}_{Path.GetFileNameWithoutExtension(outputPath)}");
            AtlusScriptCompiler.Program.Listener = new FileAndConsoleLogListener(true, LogLevel.Info | LogLevel.Warning | LogLevel.Error | LogLevel.Fatal);
        }
    }
}