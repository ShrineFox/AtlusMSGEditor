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

        private void SetDirectoryListBoxDataSource()
        {
            bs_ListBox_Dirs.DataSource = MsgDirs;

            listBox_Directories.DataSource = bs_ListBox_Dirs;
            listBox_Directories.DisplayMember = "Path";
            listBox_Directories.ValueMember = "MsgFiles";
            listBox_Directories.FormattingEnabled = true;
            listBox_Directories.Format += ListBoxDirs_Format;

            listBox_Directories.SelectedIndex = 0;
        }

        private void ListBox_Dirs_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetFilesListBoxDataSource();
        }

        private void SetFilesListBoxDataSource()
        {
            var selectedMsgDir = (MsgDir)listBox_Directories.SelectedItem;
            bs_ListBox_Files.DataSource = selectedMsgDir.MsgFiles;

            listBox_Files.DataSource = bs_ListBox_Files;
            listBox_Files.DisplayMember = "Path";
            listBox_Files.ValueMember = "Messages";
            listBox_Files.FormattingEnabled = true;
            listBox_Files.Format += ListBoxFiles_Format;

            listBox_Files.SelectedIndex = 0;
        }

        private void ListBox_Files_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetMsgsListBoxDataSource();
        }

        private void SetMsgsListBoxDataSource()
        {
            var selectedMsgFile = (MsgFile)listBox_Files.SelectedItem;
            bs_ListBox_Msgs.DataSource = selectedMsgFile.Messages;

            listBox_Msgs.DataSource = bs_ListBox_Msgs;
            listBox_Msgs.DisplayMember = "Name";
            listBox_Msgs.ValueMember = "Text";
            listBox_Msgs.FormattingEnabled = true;
            listBox_Msgs.Format += ListBoxMsgs_Format;
        }

        private void ListBox_Msgs_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetFormFields();
        }

        private void SetFormFields()
        {
            var msg = (Message)listBox_Msgs.SelectedItem;

            txt_MsgName.Text = msg.Name;
            txt_MsgTxt.Text = msg.Text;

            var msgFile = (MsgFile)listBox_Files.SelectedItem;
            if (!chk_ShowOldMsgText.Checked && Changes.Any(x => x.Path == msgFile.Path && x.MsgName == msg.Name))
                txt_MsgTxt.Text = Changes.First(x => x.Path == msgFile.Path && x.MsgName == msg.Name).MsgText;
        }

        private void ListBoxMsgs_Format(object sender, ListControlConvertEventArgs e)
        {
            var msgFile = (MsgFile)listBox_Files.SelectedItem;
            var msg = (Message)e.ListItem;

            if (Changes.Any(x => x.Path == msgFile.Path
                && x.MsgName == msg.Name))
                e.Value = $" * {msg.Name}";
        }

        private void ListBoxFiles_Format(object sender, ListControlConvertEventArgs e)
        {
            var msgFile = (MsgFile)e.ListItem;

            if (Changes.Any(x => x.Path == msgFile.Path))
                e.Value = $" * {msgFile.Path}";
        }

        private void ListBoxDirs_Format(object sender, ListControlConvertEventArgs e)
        {
            var msgDir = (MsgDir)e.ListItem;

            if (Changes.Any(x => Path.GetDirectoryName(x.Path) == msgDir.Path))
                e.Value = $" * {msgDir.Path}";
        }

        private void Desc_Changed(object sender, EventArgs e)
        {
            if (!txt_MsgTxt.Enabled)
                return;

            var msgFile = (MsgFile)listBox_Files.SelectedItem;
            var msg = (Message)listBox_Msgs.SelectedItem;

            if (Changes.Any(x => x.Path == msgFile.Path
                && x.MsgName == msg.Name))
                Changes.First(x => x.Path == msgFile.Path
                    && x.MsgName == msg.Name).MsgText = txt_MsgTxt.Text;
            else
                Changes.Add(new Change() { 
                    Path = Path.GetDirectoryName(msgFile.Path), 
                    MsgName = txt_MsgName.Text, 
                    MsgText = txt_MsgTxt.Text 
                });
        }

        private void ShowOldMsg_CheckedChanged(object sender)
        {
            var chkBox = (CheckBox)sender;

            SetFormFields();

            if (chkBox.Checked)
                txt_MsgTxt.Enabled = true;
            else
                txt_MsgTxt.Enabled = false;
        }

        private void Search_KeyDown(object sender, KeyEventArgs e)
        {
            
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
