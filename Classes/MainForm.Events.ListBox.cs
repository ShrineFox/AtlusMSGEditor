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

        private void SetDirectoryListBoxDataSource()
        {
            bs_ListBox_Dirs.DataSource = MsgDirs;

            listBox_Directories.DataSource = bs_ListBox_Dirs;
            listBox_Directories.DisplayMember = "Path";
            listBox_Directories.ValueMember = "Path";
            listBox_Directories.FormattingEnabled = true;
            listBox_Directories.Format += ListBoxDirs_Format;

            //listBox_Directories.SelectedIndex = 0;
        }

        private void ListBox_Dirs_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetFilesListBoxDataSource();
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

            //listBox_Files.SelectedIndex = 0;
            if (!chk_ShowOldMsgText.Checked)
                txt_MsgTxt.Enabled = true;
        }

        private void ListBox_Files_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetMsgsListBoxDataSource();
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
            SetFormFields();
        }

        private void SetFormFields()
        {
            if (listBox_Msgs.SelectedItem == null)
                return;

            var msg = (Message)listBox_Msgs.SelectedItem;

            txt_MsgName.Enabled = false;
            txt_Speaker.Enabled = false;

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
                    txt_MsgTxt.Text = msg.Change.MsgText;
                    txt_Speaker.Text = msg.Change.Speaker;
                }
                txt_MsgName.Enabled = true;
                txt_Speaker.Enabled = true;
            }
        }

        private void ListBoxMsgs_Format(object sender, ListControlConvertEventArgs e)
        {
            var msg = (Message)e.ListItem;

            if (msg.Change != null)
                e.Value = $" * {msg.Name}";
        }

        private void ListBoxFiles_Format(object sender, ListControlConvertEventArgs e)
        {
            var msgFile = (MsgFile)e.ListItem;

            if (msgFile.Messages.Any(x => x.Change != null))
                e.Value = $" * {Path.GetFileNameWithoutExtension(msgFile.Path)}";
            else
                e.Value = Path.GetFileNameWithoutExtension(msgFile.Path);
        }

        private void ListBoxDirs_Format(object sender, ListControlConvertEventArgs e)
        {
            var msgDir = (MsgDir)e.ListItem;
            string dirName = msgDir.Path.Replace(dumpOutPath + "\\", "");

            if (msgDir.MsgFiles.Any(x => x.Messages.Any(y => y.Change != null)))
                e.Value = $" * {dirName}";
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
                msg.Change.MsgText = txt_MsgTxt.Text;
                msg.Change.Speaker = txt_Speaker.Text;
            }
            else
                msg.Change = new Change() { 
                    Path = Path.GetDirectoryName(msgFile.Path), 
                    MsgName = txt_MsgName.Text,
                    MsgText = txt_MsgTxt.Text,
                    Speaker = txt_Speaker.Text
                };
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
