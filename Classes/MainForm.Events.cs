using AtlusScriptLibrary.Common.Text.Encodings;
using MetroSet_UI.Child;
using MetroSet_UI.Forms;
using Newtonsoft.Json;
using ShrineFox.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AtlusMSGEditor
{
    public partial class MainForm : MetroSetForm
    {
        BindingSource bindingSource_ListBox = new BindingSource();

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

            // Remove default values from serialized objects
            string jsonText = JsonConvert.SerializeObject(Changes, Newtonsoft.Json.Formatting.Indented);

            // Save to .json file
            File.WriteAllText(outPath, jsonText);
            MessageBox.Show($"Saved project file to:\n{outPath}", "Project Saved");
        }

        private void Load_Click(object sender, EventArgs e)
        {
            var filePaths = WinFormsDialogs.SelectFile("Load Project...", true, new string[] { "Project JSON (.json)" });
            if (filePaths == null || filePaths.Count == 0 || string.IsNullOrEmpty(filePaths.First()))
                return;

            Changes = JsonConvert.DeserializeObject<List<Change>>(File.ReadAllText(filePaths.First()));

            //SetListBoxDataSource();

            MessageBox.Show($"Loaded changes from:\n{filePaths.First()}", "Project Loaded");
        }

        private void Desc_Changed(object sender, EventArgs e)
        {
            if (!txt_MsgTxt.Enabled)
                return;

            string messageName = txt_MsgName.Text;
            string messagePath = listBox_Files.SelectedItem.ToString();
            string messageText = txt_MsgTxt.Text;

            if (Changes.Any(x => x.MessageName == messageName && x.FilePath.Equals(messagePath)))
                Changes.First(x => x.MessageName == messageName && x.FilePath.Equals(messagePath))
                    .MessageText = messageText;
            else
                Changes.Add(new Change() { MessageName = messageName, MessageText = messageText, FilePath = messagePath });
        }

        private void Encoding_Changed(object sender, EventArgs e)
        {
            userEncoding = AtlusEncoding.GetByName(comboBox_Encoding.SelectedItem.ToString());
        }

        private void Search_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void ListBox_Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F && (e.Modifiers == Keys.Control || e.Modifiers == Keys.LControlKey))
            {
                txt_Search.Select();
            }
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
    }
}
