using MetroSet_UI.Controls;
using MetroSet_UI.Forms;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AtlusMSGEditor
{
    public partial class MainForm : MetroSetForm
    {
        BindingSource bs_ListBox_Files = new BindingSource();
        BindingSource bs_ListBox_Dirs = new BindingSource();
        BindingSource bs_ListBox_Msgs = new BindingSource();

        private void RefreshForm()
        {
            if (listBox_Directories.SelectedIndex != -1)
                RefreshListboxes();
            if (listBox_Msgs.SelectedIndex != -1)
                SetFormFields();
        }

        private void RefreshListboxes()
        {
            selectedDir = listBox_Directories.SelectedIndex;
            selectedFile = listBox_Files.SelectedIndex;
            selectedMsg = listBox_Msgs.SelectedIndex;

            if (listBox_Directories.Items.Count > 1)
            {
                UpdateDirsListBoxFormatting();
            }
        }

        private void SetDirectoryListBoxDataSource()
        {
            bs_ListBox_Dirs.DataSource = MsgDirs;

            listBox_Directories.DataSource = bs_ListBox_Dirs;
            listBox_Directories.DisplayMember = "Path";
            listBox_Directories.ValueMember = "Path";
            listBox_Directories.FormattingEnabled = true;
            listBox_Directories.Format += ListBoxDirs_Format;

            //listBox_Directories.SelectedIndex = selectedDir;
        }

        private void ListBox_Dirs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Directories.SelectedIndex != -1 || listBox_Files.DataSource == null)
                SetFilesListBoxDataSource();
        }

        private void UpdateDirsListBoxFormatting()
        {
            listBox_Directories.DataSource = null;
            listBox_Directories.DataSource = bs_ListBox_Dirs;
        }

        private void UpdateFilesListBoxFormatting()
        {
            listBox_Files.DataSource = null;
            listBox_Files.DataSource = bs_ListBox_Files;
        }

        private void UpdateMsgsListBoxFormatting()
        {
            listBox_Msgs.DataSource = null;
            listBox_Msgs.DataSource = bs_ListBox_Msgs;
        }

        private void SetFilesListBoxDataSource()
        {
            txt_MsgTxt.Enabled = false;

            var selectedMsgDir = (MsgDir)listBox_Directories.SelectedItem;
            listBox_Files.DataSource = null;
            listBox_Files.Items.Clear();

            bs_ListBox_Files.DataSource = selectedMsgDir.MsgFiles;

            listBox_Files.DataSource = bs_ListBox_Files;
            listBox_Files.DisplayMember = "Path";
            listBox_Files.ValueMember = "Path";
            listBox_Files.FormattingEnabled = true;
            listBox_Files.Format += ListBoxFiles_Format;

            if (!chk_ShowOldMsgText.Checked)
                txt_MsgTxt.Enabled = true;
        }

        private void ListBox_Files_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Files.SelectedIndex != -1 || listBox_Msgs.DataSource == null)
                SetMsgsListBoxDataSource();
            else
                UpdateMsgsListBoxFormatting();
        }

        private void SetMsgsListBoxDataSource()
        {
            var selectedMsgFile = (MsgFile)listBox_Files.SelectedItem;
            listBox_Msgs.DataSource = null;
            listBox_Msgs.Items.Clear();
            if (selectedMsgFile == null)
                return;

            bs_ListBox_Msgs.DataSource = selectedMsgFile.Messages;

            listBox_Msgs.DataSource = bs_ListBox_Msgs;
            listBox_Msgs.DisplayMember = "Name";
            listBox_Msgs.ValueMember = "Text";
            listBox_Msgs.FormattingEnabled = true;
            listBox_Msgs.Format += ListBoxMsgs_Format;
        }

        private void ListBox_Msgs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Msgs.SelectedIndex != -1)
                SetFormFields();
        }

        private void SetFormFields()
        {
            if (listBox_Msgs.SelectedItem == null)
                return;

            var msg = (Message)listBox_Msgs.SelectedItem;

            txt_Speaker.Enabled = false;
            txt_MsgName.Enabled = false;

            txt_MsgName.Text = msg.Name;
            txt_Speaker.Text = msg.Speaker;
            txt_MsgTxt.Text = msg.Text;

            if (msg.IsSelection)
                comboBox_MsgType.SelectedIndex = 1;
            else
                comboBox_MsgType.SelectedIndex = 0;

            if (!chk_ShowOldMsgText.Checked)
            {
                if (msg.Change != null)
                {
                    txt_Speaker.Text = ApplyReplacements(msg.Change.Speaker);
                    txt_MsgTxt.Text = ApplyReplacements(msg.Change.MsgText);
                }
                else
                {
                    txt_Speaker.Text = ApplyReplacements(msg.Speaker);
                    txt_MsgTxt.Text = ApplyReplacements(msg.Text);
                }
                txt_Speaker.Enabled = true;
                txt_MsgName.Enabled = true;
            }

            if (listBox_Files.SelectedItem != null && showDecompiledFLOWToolStripMenuItem.Checked && Directory.Exists(dumpInputPath))
            {
                txt_Flowscript.Clear();
                txt_Flowscript.Enabled = true;

                MsgFile msgFile = (MsgFile)listBox_Files.SelectedItem;
                string bfPath = Path.Combine(dumpInputPath, msgFile.Path.Replace(dumpOutPath, "").TrimStart('\\'));
                string flowTxt = GetFlowTxt(ShrineFox.IO.FileSys.GetExtensionlessPath(bfPath));
                if (!string.IsNullOrEmpty(flowTxt))
                    txt_Flowscript.Text = flowTxt;
            }
            else
            {
                txt_Flowscript.Clear();
                txt_Flowscript.Enabled = false;
            }
        }

        private void ListBoxMsgs_Format(object sender, ListControlConvertEventArgs e)
        {
            var msg = (Message)e.ListItem;

            if (msg.Change != null)
                e.Value = $" [*] {msg.Name}";
            else if (showAutoReplacedFilesToolStripMenuItem.Checked && 
                (msg.Text != ApplyReplacements(msg.Text) || msg.Speaker != ApplyReplacements(msg.Speaker)))
            {
                e.Value = $" [A] {msg.Name}";
            }
        }

        private void ListBoxFiles_Format(object sender, ListControlConvertEventArgs e)
        {
            var msgFile = (MsgFile)e.ListItem;

            if (msgFile.Messages.Any(x => x.Change != null))
                e.Value = $" [*] {Path.GetFileNameWithoutExtension(msgFile.Path)}";
            else if (showAutoReplacedFilesToolStripMenuItem.Checked 
                && msgFile.Messages.Any(x => x.Text != ApplyReplacements(x.Text) || x.Speaker != ApplyReplacements(x.Speaker)))
                e.Value = $" [A] {Path.GetFileNameWithoutExtension(msgFile.Path)}";
            else
                e.Value = Path.GetFileNameWithoutExtension(msgFile.Path);
        }

        private void ListBoxDirs_Format(object sender, ListControlConvertEventArgs e)
        {
            var msgDir = (MsgDir)e.ListItem;
            string dirName = msgDir.Path.Replace(dumpOutPath + "\\", "");

            if (msgDir.MsgFiles.Any(x => x.Messages.Any(y => y.Change != null)))
                e.Value = $" [*] {dirName}";
            else if (showAutoReplacedFilesToolStripMenuItem.Checked && 
                msgDir.MsgFiles.Any(x => x.Messages.Any(y =>
                y.Text != ApplyReplacements(y.Text) || y.Speaker != ApplyReplacements(y.Speaker)
            )))
                e.Value = $" [A] {dirName}";
            else
                e.Value = dirName;
        }

        private void Desc_Changed(object sender, EventArgs e)
        {
            if (!txt_MsgTxt.Enabled || !txt_Speaker.Enabled)
                return;

            var msg = (Message)listBox_Msgs.SelectedItem;
            var msgFile = (MsgFile)listBox_Files.SelectedItem;

            if (msg.Change != null)
            {
                // Revert change if identical to original message
                if (ApplyReplacements(msg.Speaker) == txt_Speaker.Text 
                    && ApplyReplacements(msg.Text) == txt_MsgTxt.Text)
                    msg.Change = null;
                else
                {
                    // Update changed text
                    msg.Change.MsgText = txt_MsgTxt.Text;
                    msg.Change.Speaker = txt_Speaker.Text;
                }
                
            }
            else
            {
                // Add new change to list of changes
                msg.Change = new Change()
                {
                    Path = msgFile.Path,
                    MsgName = txt_MsgName.Text,
                    MsgText = txt_MsgTxt.Text,
                    Speaker = txt_Speaker.Text
                };
            }
        }

        private void ShowOldMsg_CheckedChanged(object sender)
        {
            var chkBox = (MetroSetCheckBox)sender;

            SetFormFields();

            if (chkBox.Checked)
                txt_MsgTxt.Enabled = false;
            else
                txt_MsgTxt.Enabled = true;
        }

        private void Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Search.Text))
                return;

            if (e.KeyData == Keys.Enter)
            {
                // stop windows ding noise
                e.Handled = true;
                e.SuppressKeyPress = true;

                if (chk_IncludeDirsInSearch.Checked)
                    SearchDirectories();
                else if (chk_IncludeFilesInSearch.Checked)
                    SearchFiles();
                else
                    SearchMessages();
            }
        }

        private void SearchDirectories()
        {
            string searchTxt = txt_Search.Text.ToLower();
            int selectedIndex = listBox_Directories.SelectedIndex;

            int i = selectedIndex + 1;
            while (i < listBox_Directories.Items.Count)
            {
                if (i == selectedIndex)
                    return;

                var dir = (MsgDir)listBox_Directories.Items[i];

                if (dir.MsgFiles.Any(x => x.Messages.Any(y =>
                    y.Name.ToLower().Contains(searchTxt) ||
                    y.Text.ToLower().Contains(searchTxt) || y.Speaker.ToLower().Contains(searchTxt) ||
                    (y.Change != null && y.Change.MsgText.ToLower().Contains(searchTxt)) ||
                    (y.Change != null && y.Change.Speaker.ToLower().Contains(searchTxt))
                    )))
                {
                    listBox_Directories.SelectedIndex = i;
                    SearchFiles();
                    return;
                }

                if (i == listBox_Directories.Items.Count - 1)
                    i = 0;
                else
                    i++;
            }
        }

        private void SearchFiles()
        {
            string searchTxt = txt_Search.Text.ToLower();
            int selectedIndex = listBox_Files.SelectedIndex;

            int i = selectedIndex + 1;
            while (i < listBox_Files.Items.Count)
            {
                if (i == selectedIndex)
                    return;

                var file = (MsgFile)listBox_Files.Items[i];

                if (file.Messages.Any(y =>
                    y.Name.ToLower().Contains(searchTxt) ||
                    y.Text.ToLower().Contains(searchTxt) || y.Speaker.ToLower().Contains(searchTxt) ||
                    (y.Change != null && y.Change.MsgText.ToLower().Contains(searchTxt)) ||
                    (y.Change != null && y.Change.Speaker.ToLower().Contains(searchTxt))
                    ))
                {
                    listBox_Files.SelectedIndex = i;
                    SearchMessages();
                    return;
                }

                if (i == listBox_Files.Items.Count - 1)
                    i = 0;
                else
                    i++;
            }
        }

        private void SearchMessages()
        {
            string searchTxt = txt_Search.Text.ToLower();
            int selectedIndex = listBox_Msgs.SelectedIndex;

            int i = selectedIndex + 1;
            while (i < listBox_Msgs.Items.Count)
            {
                if (i == selectedIndex)
                    return;

                var msg = (Message)listBox_Msgs.Items[i];

                if (
                    msg.Name.ToLower().Contains(searchTxt) ||
                    msg.Text.ToLower().Contains(searchTxt) || msg.Speaker.ToLower().Contains(searchTxt) ||
                    (msg.Change != null && msg.Change.MsgText.ToLower().Contains(searchTxt)) || 
                    (msg.Change != null &&  msg.Change.Speaker.ToLower().Contains(searchTxt))
                    )
                {
                    listBox_Msgs.SelectedIndex = i;
                    return;
                }

                if (i == listBox_Msgs.Items.Count - 1)
                    i = 0;
                else
                    i++;
            }
        }

        private void ListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F && (e.Modifiers == Keys.Control || e.Modifiers == Keys.LControlKey))
            {
                txt_Search.Select();
            }
        }
    }
}
