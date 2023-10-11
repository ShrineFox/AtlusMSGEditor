using AtlusScriptLibrary.Common.Text.Encodings;
using MetroSet_UI.Forms;
using Newtonsoft.Json;
using ShrineFox.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static AtlusMSGEditor.MainForm;

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
    }
}
