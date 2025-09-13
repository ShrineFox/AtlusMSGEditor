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
using AtlusScriptLibrary.FlowScriptLanguage;
using AtlusScriptLibrary.Common.Logging;
using AtlusScriptLibrary.MessageScriptLanguage.Compiler;
using System.Threading;
using System.Reflection;
using MoreLinq;

namespace AtlusMSGEditor
{
    public partial class MainForm : MetroSetForm
    {

        private void SaveProject_Click(object sender, EventArgs e)
        {
            SaveProject();
        }

        private void SaveProject()
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

            // Save to .json file
            string jsonText = JsonConvert.SerializeObject(UserSettings, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(outPath, jsonText);
            MessageBox.Show($"Saved project file to:\n{outPath}", "Project Saved");
        }

        private void Load_Click(object sender, EventArgs e)
        {
            LoadProject();
        }

        private void LoadProject()
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

        private void ImportBMDs_Click(object sender, EventArgs e)
        {
            ImportBMDs();
        }

        private void ExportTXTs_Click(object sender, EventArgs e)
        {
            CreateTXTDump();
        }

        private void JsonDump_Click(object sender, EventArgs e)
        {
            CreateJSONDump();
        }

        private void ExportBMDs_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                ExportBMDs();
            }).Start();
        }

        private void SetInputPath_Click(object sender, EventArgs e)
        {
            var path = WinFormsDialogs.SelectFolder("Choose Dir Containing CPK Dump Folders");
            if (!String.IsNullOrEmpty(path))
            {
                formSettings.DumpInputPath = path;
                SaveFormSettings();
            }
        }


        private void SetCPKOutputPath_Click(object sender, EventArgs e)
        {
            var path = WinFormsDialogs.SelectFolder("Choose Mod's CPK Folder to Export To");
            if (!String.IsNullOrEmpty(path))
            {
                formSettings.CPKExportPath = path;
                SaveFormSettings();
            }
        }

        private void SetFEmuOutputPath_Click(object sender, EventArgs e)
        {
            var path = WinFormsDialogs.SelectFolder("Choose Mod's FEmulator Folder to Export To");
            if (!String.IsNullOrEmpty(path))
            {
                formSettings.FEmuExportPath = path;
                SaveFormSettings();
            }
        }

        private void CompilerPath_Click(object sender, EventArgs e)
        {
            var path = WinFormsDialogs.SelectFile("Locate AtlusScriptCompiler.exe", false, new string[] { "Executable (.EXE)" });
            if (path.Count > 0 && !String.IsNullOrEmpty(path[0]))
            {
                formSettings.CompilerPath = path[0];
                SaveFormSettings();
            }
        }

        private void AutoReplace_Click(object sender, EventArgs e)
        {
            OpenAutoReplaceForm();
        }

        private void OpenAutoReplaceForm()
        {
            AutoReplaceForm replaceForm = new AutoReplaceForm();
            var result = replaceForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                UserSettings.Replacements = replaceForm.Replacements;
                RefreshForm();
            }
        }

        private void Encoding_Changed(object sender, EventArgs e)
        {
            ApplyNewEncoding();
            SaveFormSettings();
        }

        private void ApplyNewEncoding()
        {
            formSettings.UserEncoding = comboBox_Encoding.SelectedItem.ToString();
        }

        private void ToggleTheme_Click(object sender, EventArgs e)
        {
            ToggleTheme();
            ApplyTheme();
        }

        private void ToggleTheme()
        {
            if (formSettings.Theme == MetroSet_UI.Enums.Style.Light)
                formSettings.Theme = MetroSet_UI.Enums.Style.Dark;
            else
                formSettings.Theme = MetroSet_UI.Enums.Style.Light;

            SaveFormSettings();
        }

        private void ApplyTheme()
        {
            this.Style = formSettings.Theme;
            Theme.ThemeStyle = this.Style;

            Theme.ApplyToForm(this);
            //Theme.SetMenuRenderer(ContextMenuStrip_RightClick);
            //Theme.RecursivelySetColors(ContextMenuStrip_RightClick);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void SetProgress(int percent)
        {
            progressBar1.SyncUI(() => { progressBar1.Value = percent; progressBar1.Update(); }, true);
        }

        private void MenuStrip_CheckedChanged(object sender, EventArgs e)
        {
            SaveFormSettings();
        }
    }
}
