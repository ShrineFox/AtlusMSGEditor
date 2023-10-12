using AtlusScriptLibrary.Common.Libraries;
using AtlusScriptLibrary.Common.Text.Encodings;
using AtlusScriptLibrary.FlowScriptLanguage.BinaryModel;
using AtlusScriptLibrary.MessageScriptLanguage.Decompiler;
using AtlusScriptLibrary.MessageScriptLanguage;
using MetroSet_UI.Forms;
using Newtonsoft.Json;
using ShrineFox.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static AtlusMSGEditor.MainForm;
using static System.Net.Mime.MediaTypeNames;
using AtlusScriptLibrary.MessageScriptLanguage.BinaryModel;
using AtlusScriptLibrary.FlowScriptLanguage;
using System.Xml.Linq;
using AtlusFileSystemLibrary.Common.IO;
using AtlusScriptLibrary.Common.Logging;
using AtlusScriptLibrary.MessageScriptLanguage.Compiler;

namespace AtlusMSGEditor
{
    public partial class MainForm : MetroSetForm
    {
        private void Save_Click(object sender, EventArgs e)
        {
            // Get output path from file select prompt
            var outPaths = WinFormsDialogs.SelectFile("Save Project...", true, new string[] { "Project JSON (.json)" }, true);
            if (outPaths == null || outPaths.Count == 0 || string.IsNullOrEmpty(outPaths.First()))
                return;

            // Ensure output path ends with .json
            string outPath = outPaths.First();
            if (!outPath.ToLower().EndsWith(".json"))
                outPath += ".json";

            // Update list of changes in usersettings object with form data
            List<Change> Changes = new List<Change>();
            foreach (var dir in MsgDirs)
                foreach (var file in dir.MsgFiles)
                    foreach (var msg in file.Messages)
                        if (msg.Change != null)
                            Changes.Add(msg.Change);
            UserSettings.Changes = Changes;

            // Remove default values from serialized objects
            string jsonText = JsonConvert.SerializeObject(UserSettings, Newtonsoft.Json.Formatting.Indented);

            // Save to .json file
            File.WriteAllText(outPath, jsonText);
            MessageBox.Show($"Saved project file to:\n{outPath}", "Project Saved");
        }

        private void Load_Click(object sender, EventArgs e)
        {
            var filePaths = WinFormsDialogs.SelectFile("Load Project...", true, new string[] { "Project JSON (.json)" });
            if (filePaths == null || filePaths.Count == 0 || string.IsNullOrEmpty(filePaths.First()))
                return;

            UserSettings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(filePaths.First()));

            // Update form data with list of changes in usersettings object
            foreach (var dir in MsgDirs)
                foreach (var file in dir.MsgFiles)
                    foreach (var msg in file.Messages)
                        if (UserSettings.Changes.Any(x => x.Path == file.Path && x.MsgName == msg.Name))
                            msg.Change = UserSettings.Changes.First(x => x.Path == file.Path && x.MsgName == msg.Name);

            SetDirectoryListBoxDataSource();

            MessageBox.Show($"Loaded changes from:\n{filePaths.First()}", "Project Loaded");
        }

        private void ExportTXTs_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(dumpOutPath))
            {
                // Combine .MSG and .FLOW files into single .txt files
                Output.Log($"Combining .MSGs in \"{dumpOutPath}\"...");
                CombineToTxt(dumpOutPath, ".msg");
                Output.Log($"Done Combining .MSGs.");
                Output.Log($"Combining .FLOWs in \"{dumpOutPath}\"...");
                CombineToTxt(dumpOutPath, ".flow");
                Output.Log($"Done Combining .FLOWs.");
            }
        }

        private void JsonDump_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(dumpOutPath))
            {
                // Combine .MSG and .FLOW files into single .txt files
                Output.Log($"Combining .MSGs in \"{dumpOutPath}\"...");
                CombineToTxt(dumpOutPath, ".msg");
                Output.Log($"Done Combining .MSGs.");
                Output.Log($"Combining .FLOWs in \"{dumpOutPath}\"...");
                CombineToTxt(dumpOutPath, ".flow");
                Output.Log($"Done Combining .FLOWs.");
            }
        }

        private void ExportBMDs_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(exportPath);

            Output.Log($"Creating new .MSGs in \"{exportPath}\"...");
            foreach (var dir in MsgDirs)
            {
                foreach (var file in dir.MsgFiles.Where(x => 
                    x.Messages.Any(y => 
                        y.Change != null || 
                        y.Text != ApplyReplacements(y.Text) || y.Speaker != ApplyReplacements(y.Speaker)
                    )))
                {
                    string msgTxt = "";
                    foreach (var msg in file.Messages)
                    {
                        string speaker = msg.Speaker;
                        string text = msg.Text;
                        if (msg.Change != null)
                        {
                            speaker = msg.Change.Speaker;
                            text = msg.Change.MsgText;
                        }

                        if (msg.IsSelection)
                            msgTxt += "[sel ";
                        else
                            msgTxt += "[msg ";

                        msgTxt += msg.Name;
                        if (!string.IsNullOrEmpty(speaker))
                        {
                            msgTxt += $" [{ApplyReplacements(speaker)}]";
                        }
                        msgTxt += "]\n";
                        msgTxt += ApplyReplacements(text) + "\n\n";
                    }
                    string outPath = file.Path.Replace(dumpOutPath, exportPath);
                    Directory.CreateDirectory(Path.GetDirectoryName(outPath));
                    File.WriteAllText(outPath, msgTxt);
                }
            }
            Output.Log($"Done creating new .MSGs.");
            Output.Log($"Compiling .MSGs to .BMD in \"{exportPath}\"...");
            foreach (var msgFile in Directory.GetFiles(exportPath, "*.msg", SearchOption.AllDirectories))
            {
                string outPath = FileSys.GetExtensionlessPath(msgFile);
                if (Path.GetExtension(outPath).ToLower() == ".bf")
                {
                    InjectMSGIntoBF(msgFile, outPath);
                }
                else
                {
                    CompileMSGToBMD(msgFile, outPath);
                }
            }
            Output.Log($"Done compiling .MSGs to .BMD.");
        }

        private void InjectMSGIntoBF(string msgFile, string outBfPath)
        {
            string dumpBfPath = FileSys.GetExtensionlessPath(msgFile).Replace(exportPath, dumpOutPath);

            if (!File.Exists(dumpBfPath))
                return;

            FlowScript flowScript = FlowScript.FromFile(dumpBfPath, null);

            using (FileStream fileStream = File.OpenRead(msgFile))
            {
                MessageScriptCompiler messageScriptCompiler = new MessageScriptCompiler(
                    AtlusScriptLibrary.MessageScriptLanguage.FormatVersion.Version1BigEndian, userEncoding);
                messageScriptCompiler.AddListener(new ConsoleLogListener(true, LogLevel.Info | LogLevel.Warning
                    | LogLevel.Error | LogLevel.Fatal));
                messageScriptCompiler.Library = LibraryLookup.GetLibrary("P5R");
                MessageScript messageScript;
                if (!messageScriptCompiler.TryCompile(fileStream, out messageScript))
                    return;
                flowScript.MessageScript = messageScript;
                Directory.CreateDirectory(Path.GetDirectoryName(outBfPath));
                flowScript.ToFile(outBfPath);
            }
        }

        private void CompileMSGToBMD(string msgFile, string outPath)
        {
            InitializeScriptCompiler(msgFile, outPath);

            AtlusScriptCompiler.Program.Main(new string[] {
                    msgFile, "-Compile",
                    "-Library", "P5R",
                    "-Encoding", comboBox_Encoding.SelectedItem.ToString(),
                    "-OutFormat", "V1BE",
                    "-Out", outPath });
        }

        private void AutoReplace_Click(object sender, EventArgs e)
        {
            AutoReplaceForm replaceForm = new AutoReplaceForm();
            var result = replaceForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                UserSettings.Replacements = replaceForm.Replacements;
            }
        }

        private void Encoding_Changed(object sender, EventArgs e)
        {
            userEncoding = AtlusEncoding.GetByName(comboBox_Encoding.SelectedItem.ToString());
        }

        private void ToggleTheme_Click(object sender, EventArgs e)
        {
            ToggleTheme();
            ApplyTheme();
        }

        private void ToggleTheme()
        {
            if (Theme.ThemeStyle == MetroSet_UI.Enums.Style.Light)
                Theme.ThemeStyle = MetroSet_UI.Enums.Style.Dark;
            else
                Theme.ThemeStyle = MetroSet_UI.Enums.Style.Light;
        }

        private void ApplyTheme()
        {
            Theme.ApplyToForm(this);
            //Theme.SetMenuRenderer(ContextMenuStrip_RightClick);
            //Theme.RecursivelySetColors(ContextMenuStrip_RightClick);
        }

        private void SetLogging()
        {
            Output.Logging = true;
            Output.LogPath = "Log.txt";
            Output.LogToFile = true;
            Output.LogControl = rtb_Log;
            Output.VerboseLogging = true;
        }
    }
}
