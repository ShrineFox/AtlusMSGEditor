using MetroSet_UI.Controls;
using MetroSet_UI.Forms;
using System.Drawing;
using System.Windows.Forms;

namespace AtlusMSGEditor
{
    partial class MainForm : MetroSetForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportTXTsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputBMDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteOutputMSGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteExistingDumpDirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox_Encoding = new System.Windows.Forms.ToolStripComboBox();
            this.toggleThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer_Main = new System.Windows.Forms.SplitContainer();
            this.tlp_ListAndSearch = new System.Windows.Forms.TableLayoutPanel();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.listBox_Msgs = new System.Windows.Forms.ListBox();
            this.panel_Editor = new System.Windows.Forms.Panel();
            this.tlp_Editor = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_MsgName = new System.Windows.Forms.Label();
            this.txt_MsgName = new System.Windows.Forms.TextBox();
            this.chk_ShowOldMsgText = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.lbl_MsgTxt = new System.Windows.Forms.Label();
            this.txt_MsgTxt = new System.Windows.Forms.TextBox();
            this.lbl_MsgType = new System.Windows.Forms.Label();
            this.lbl_Speaker = new System.Windows.Forms.Label();
            this.txt_Speaker = new System.Windows.Forms.TextBox();
            this.comboBox_MsgType = new System.Windows.Forms.ComboBox();
            this.splitContainer_Log = new System.Windows.Forms.SplitContainer();
            this.splitContainer_Directories = new System.Windows.Forms.SplitContainer();
            this.listBox_Directories = new System.Windows.Forms.ListBox();
            this.splitContainer_Files = new System.Windows.Forms.SplitContainer();
            this.listBox_Files = new System.Windows.Forms.ListBox();
            this.rtb_Log = new System.Windows.Forms.RichTextBox();
            this.menuStrip_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Main)).BeginInit();
            this.splitContainer_Main.Panel1.SuspendLayout();
            this.splitContainer_Main.Panel2.SuspendLayout();
            this.splitContainer_Main.SuspendLayout();
            this.tlp_ListAndSearch.SuspendLayout();
            this.panel_Editor.SuspendLayout();
            this.tlp_Editor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Log)).BeginInit();
            this.splitContainer_Log.Panel1.SuspendLayout();
            this.splitContainer_Log.Panel2.SuspendLayout();
            this.splitContainer_Log.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Directories)).BeginInit();
            this.splitContainer_Directories.Panel1.SuspendLayout();
            this.splitContainer_Directories.Panel2.SuspendLayout();
            this.splitContainer_Directories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Files)).BeginInit();
            this.splitContainer_Files.Panel1.SuspendLayout();
            this.splitContainer_Files.Panel2.SuspendLayout();
            this.splitContainer_Files.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader
            // 
            this.columnHeader.Width = 100;
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.toggleThemeToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(2, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.menuStrip_Main.Size = new System.Drawing.Size(890, 28);
            this.menuStrip_Main.TabIndex = 2;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.exportTXTsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.saveToolStripMenuItem.Text = "Save Project";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.Save_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.loadToolStripMenuItem.Text = "Load Project";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.Load_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.importToolStripMenuItem.Text = "Import .BMDs";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.ImportBMDs_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.exportToolStripMenuItem.Text = "Export .BMDs";
            // 
            // exportTXTsToolStripMenuItem
            // 
            this.exportTXTsToolStripMenuItem.Name = "exportTXTsToolStripMenuItem";
            this.exportTXTsToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.exportTXTsToolStripMenuItem.Text = "Create .TXT Dump";
            this.exportTXTsToolStripMenuItem.Click += new System.EventHandler(this.ExportTXTs_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outputBMDToolStripMenuItem,
            this.deleteOutputMSGToolStripMenuItem,
            this.deleteExistingDumpDirToolStripMenuItem,
            this.comboBox_Encoding});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // outputBMDToolStripMenuItem
            // 
            this.outputBMDToolStripMenuItem.Checked = true;
            this.outputBMDToolStripMenuItem.CheckOnClick = true;
            this.outputBMDToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.outputBMDToolStripMenuItem.Name = "outputBMDToolStripMenuItem";
            this.outputBMDToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.outputBMDToolStripMenuItem.Text = "Output BMD";
            // 
            // deleteOutputMSGToolStripMenuItem
            // 
            this.deleteOutputMSGToolStripMenuItem.CheckOnClick = true;
            this.deleteOutputMSGToolStripMenuItem.Name = "deleteOutputMSGToolStripMenuItem";
            this.deleteOutputMSGToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.deleteOutputMSGToolStripMenuItem.Text = "Delete Output MSG";
            // 
            // deleteExistingDumpDirToolStripMenuItem
            // 
            this.deleteExistingDumpDirToolStripMenuItem.Checked = true;
            this.deleteExistingDumpDirToolStripMenuItem.CheckOnClick = true;
            this.deleteExistingDumpDirToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.deleteExistingDumpDirToolStripMenuItem.Name = "deleteExistingDumpDirToolStripMenuItem";
            this.deleteExistingDumpDirToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.deleteExistingDumpDirToolStripMenuItem.Text = "Delete Existing Dump Dir";
            // 
            // comboBox_Encoding
            // 
            this.comboBox_Encoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Encoding.DropDownWidth = 150;
            this.comboBox_Encoding.Items.AddRange(new object[] {
            "P5R_EFIGS",
            "P5R_JAPANESE",
            "P5R_CHINESE"});
            this.comboBox_Encoding.Name = "comboBox_Encoding";
            this.comboBox_Encoding.Size = new System.Drawing.Size(151, 28);
            this.comboBox_Encoding.SelectedIndexChanged += new System.EventHandler(this.Encoding_Changed);
            // 
            // toggleThemeToolStripMenuItem
            // 
            this.toggleThemeToolStripMenuItem.Name = "toggleThemeToolStripMenuItem";
            this.toggleThemeToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.toggleThemeToolStripMenuItem.Text = "Toggle Theme";
            this.toggleThemeToolStripMenuItem.Click += new System.EventHandler(this.ToggleTheme_Click);
            // 
            // splitContainer_Main
            // 
            this.splitContainer_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Main.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Main.Name = "splitContainer_Main";
            // 
            // splitContainer_Main.Panel1
            // 
            this.splitContainer_Main.Panel1.Controls.Add(this.tlp_ListAndSearch);
            // 
            // splitContainer_Main.Panel2
            // 
            this.splitContainer_Main.Panel2.Controls.Add(this.panel_Editor);
            this.splitContainer_Main.Size = new System.Drawing.Size(521, 385);
            this.splitContainer_Main.SplitterDistance = 105;
            this.splitContainer_Main.TabIndex = 3;
            // 
            // tlp_ListAndSearch
            // 
            this.tlp_ListAndSearch.ColumnCount = 1;
            this.tlp_ListAndSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_ListAndSearch.Controls.Add(this.txt_Search, 0, 0);
            this.tlp_ListAndSearch.Controls.Add(this.listBox_Msgs, 0, 1);
            this.tlp_ListAndSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_ListAndSearch.Location = new System.Drawing.Point(0, 0);
            this.tlp_ListAndSearch.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_ListAndSearch.Name = "tlp_ListAndSearch";
            this.tlp_ListAndSearch.RowCount = 2;
            this.tlp_ListAndSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlp_ListAndSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tlp_ListAndSearch.Size = new System.Drawing.Size(105, 385);
            this.tlp_ListAndSearch.TabIndex = 1;
            // 
            // txt_Search
            // 
            this.txt_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Search.Location = new System.Drawing.Point(3, 3);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(99, 26);
            this.txt_Search.TabIndex = 5;
            this.txt_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_KeyDown);
            // 
            // listBox_Msgs
            // 
            this.listBox_Msgs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_Msgs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Msgs.ItemHeight = 20;
            this.listBox_Msgs.Location = new System.Drawing.Point(3, 33);
            this.listBox_Msgs.Name = "listBox_Msgs";
            this.listBox_Msgs.Size = new System.Drawing.Size(99, 349);
            this.listBox_Msgs.TabIndex = 0;
            this.listBox_Msgs.SelectedIndexChanged += new System.EventHandler(this.ListBox_Msgs_SelectedIndexChanged);
            // 
            // panel_Editor
            // 
            this.panel_Editor.AutoSize = true;
            this.panel_Editor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_Editor.Controls.Add(this.tlp_Editor);
            this.panel_Editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Editor.Location = new System.Drawing.Point(0, 0);
            this.panel_Editor.Name = "panel_Editor";
            this.panel_Editor.Size = new System.Drawing.Size(412, 385);
            this.panel_Editor.TabIndex = 0;
            // 
            // tlp_Editor
            // 
            this.tlp_Editor.AutoScroll = true;
            this.tlp_Editor.ColumnCount = 2;
            this.tlp_Editor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Editor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlp_Editor.Controls.Add(this.lbl_MsgName, 0, 0);
            this.tlp_Editor.Controls.Add(this.txt_MsgName, 1, 0);
            this.tlp_Editor.Controls.Add(this.chk_ShowOldMsgText, 1, 4);
            this.tlp_Editor.Controls.Add(this.lbl_MsgTxt, 0, 3);
            this.tlp_Editor.Controls.Add(this.txt_MsgTxt, 1, 3);
            this.tlp_Editor.Controls.Add(this.lbl_MsgType, 0, 1);
            this.tlp_Editor.Controls.Add(this.lbl_Speaker, 0, 2);
            this.tlp_Editor.Controls.Add(this.txt_Speaker, 1, 2);
            this.tlp_Editor.Controls.Add(this.comboBox_MsgType, 1, 1);
            this.tlp_Editor.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_Editor.Location = new System.Drawing.Point(0, 0);
            this.tlp_Editor.Name = "tlp_Editor";
            this.tlp_Editor.RowCount = 5;
            this.tlp_Editor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_Editor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_Editor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_Editor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tlp_Editor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_Editor.Size = new System.Drawing.Size(412, 464);
            this.tlp_Editor.TabIndex = 0;
            // 
            // lbl_MsgName
            // 
            this.lbl_MsgName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_MsgName.AutoSize = true;
            this.lbl_MsgName.Location = new System.Drawing.Point(5, 10);
            this.lbl_MsgName.Name = "lbl_MsgName";
            this.lbl_MsgName.Size = new System.Drawing.Size(95, 20);
            this.lbl_MsgName.TabIndex = 2;
            this.lbl_MsgName.Text = "Msg Name:";
            this.lbl_MsgName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_MsgName
            // 
            this.txt_MsgName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_MsgName.Enabled = false;
            this.txt_MsgName.Location = new System.Drawing.Point(106, 7);
            this.txt_MsgName.Name = "txt_MsgName";
            this.txt_MsgName.ReadOnly = true;
            this.txt_MsgName.Size = new System.Drawing.Size(303, 26);
            this.txt_MsgName.TabIndex = 6;
            // 
            // chk_ShowOldMsgText
            // 
            this.chk_ShowOldMsgText.BackColor = System.Drawing.Color.Transparent;
            this.chk_ShowOldMsgText.BackgroundColor = System.Drawing.Color.White;
            this.chk_ShowOldMsgText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.chk_ShowOldMsgText.Checked = false;
            this.chk_ShowOldMsgText.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.chk_ShowOldMsgText.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.chk_ShowOldMsgText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_ShowOldMsgText.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.chk_ShowOldMsgText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chk_ShowOldMsgText.IsDerivedStyle = true;
            this.chk_ShowOldMsgText.Location = new System.Drawing.Point(106, 263);
            this.chk_ShowOldMsgText.Name = "chk_ShowOldMsgText";
            this.chk_ShowOldMsgText.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            this.chk_ShowOldMsgText.Size = new System.Drawing.Size(213, 16);
            this.chk_ShowOldMsgText.Style = MetroSet_UI.Enums.Style.Light;
            this.chk_ShowOldMsgText.StyleManager = null;
            this.chk_ShowOldMsgText.TabIndex = 10;
            this.chk_ShowOldMsgText.Text = "Show Old Message Text";
            this.chk_ShowOldMsgText.ThemeAuthor = "Narwin";
            this.chk_ShowOldMsgText.ThemeName = "MetroLite";
            this.chk_ShowOldMsgText.CheckedChanged += new MetroSet_UI.Controls.MetroSetCheckBox.CheckedChangedEventHandler(this.ShowOldMsg_CheckedChanged);
            // 
            // lbl_MsgTxt
            // 
            this.lbl_MsgTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_MsgTxt.AutoSize = true;
            this.lbl_MsgTxt.Location = new System.Drawing.Point(17, 120);
            this.lbl_MsgTxt.Name = "lbl_MsgTxt";
            this.lbl_MsgTxt.Size = new System.Drawing.Size(83, 20);
            this.lbl_MsgTxt.TabIndex = 5;
            this.lbl_MsgTxt.Text = "Msg Text:";
            this.lbl_MsgTxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_MsgTxt
            // 
            this.txt_MsgTxt.Location = new System.Drawing.Point(106, 123);
            this.txt_MsgTxt.Multiline = true;
            this.txt_MsgTxt.Name = "txt_MsgTxt";
            this.txt_MsgTxt.Size = new System.Drawing.Size(303, 134);
            this.txt_MsgTxt.TabIndex = 9;
            this.txt_MsgTxt.TextChanged += new System.EventHandler(this.Desc_Changed);
            // 
            // lbl_MsgType
            // 
            this.lbl_MsgType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_MsgType.AutoSize = true;
            this.lbl_MsgType.Location = new System.Drawing.Point(50, 50);
            this.lbl_MsgType.Name = "lbl_MsgType";
            this.lbl_MsgType.Size = new System.Drawing.Size(50, 20);
            this.lbl_MsgType.TabIndex = 11;
            this.lbl_MsgType.Text = "Type:";
            this.lbl_MsgType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Speaker
            // 
            this.lbl_Speaker.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Speaker.AutoSize = true;
            this.lbl_Speaker.Location = new System.Drawing.Point(25, 90);
            this.lbl_Speaker.Name = "lbl_Speaker";
            this.lbl_Speaker.Size = new System.Drawing.Size(75, 20);
            this.lbl_Speaker.TabIndex = 12;
            this.lbl_Speaker.Text = "Speaker:";
            this.lbl_Speaker.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_Speaker
            // 
            this.txt_Speaker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Speaker.Location = new System.Drawing.Point(106, 87);
            this.txt_Speaker.Name = "txt_Speaker";
            this.txt_Speaker.Size = new System.Drawing.Size(303, 26);
            this.txt_Speaker.TabIndex = 13;
            this.txt_Speaker.TextChanged += new System.EventHandler(this.Desc_Changed);
            // 
            // comboBox_MsgType
            // 
            this.comboBox_MsgType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_MsgType.Enabled = false;
            this.comboBox_MsgType.FormattingEnabled = true;
            this.comboBox_MsgType.Items.AddRange(new object[] {
            "Dialog",
            "Selection"});
            this.comboBox_MsgType.Location = new System.Drawing.Point(106, 43);
            this.comboBox_MsgType.Name = "comboBox_MsgType";
            this.comboBox_MsgType.Size = new System.Drawing.Size(213, 28);
            this.comboBox_MsgType.TabIndex = 14;
            // 
            // splitContainer_Log
            // 
            this.splitContainer_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Log.Location = new System.Drawing.Point(2, 28);
            this.splitContainer_Log.Name = "splitContainer_Log";
            this.splitContainer_Log.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_Log.Panel1
            // 
            this.splitContainer_Log.Panel1.Controls.Add(this.splitContainer_Directories);
            // 
            // splitContainer_Log.Panel2
            // 
            this.splitContainer_Log.Panel2.Controls.Add(this.rtb_Log);
            this.splitContainer_Log.Size = new System.Drawing.Size(890, 470);
            this.splitContainer_Log.SplitterDistance = 385;
            this.splitContainer_Log.TabIndex = 4;
            // 
            // splitContainer_Directories
            // 
            this.splitContainer_Directories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Directories.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Directories.Name = "splitContainer_Directories";
            // 
            // splitContainer_Directories.Panel1
            // 
            this.splitContainer_Directories.Panel1.Controls.Add(this.listBox_Directories);
            // 
            // splitContainer_Directories.Panel2
            // 
            this.splitContainer_Directories.Panel2.Controls.Add(this.splitContainer_Files);
            this.splitContainer_Directories.Size = new System.Drawing.Size(890, 385);
            this.splitContainer_Directories.SplitterDistance = 256;
            this.splitContainer_Directories.TabIndex = 0;
            // 
            // listBox_Directories
            // 
            this.listBox_Directories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_Directories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Directories.ItemHeight = 20;
            this.listBox_Directories.Location = new System.Drawing.Point(0, 0);
            this.listBox_Directories.Name = "listBox_Directories";
            this.listBox_Directories.Size = new System.Drawing.Size(256, 385);
            this.listBox_Directories.TabIndex = 2;
            this.listBox_Directories.SelectedIndexChanged += new System.EventHandler(this.ListBox_Dirs_SelectedIndexChanged);
            // 
            // splitContainer_Files
            // 
            this.splitContainer_Files.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Files.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Files.Name = "splitContainer_Files";
            // 
            // splitContainer_Files.Panel1
            // 
            this.splitContainer_Files.Panel1.Controls.Add(this.listBox_Files);
            // 
            // splitContainer_Files.Panel2
            // 
            this.splitContainer_Files.Panel2.Controls.Add(this.splitContainer_Main);
            this.splitContainer_Files.Size = new System.Drawing.Size(630, 385);
            this.splitContainer_Files.SplitterDistance = 105;
            this.splitContainer_Files.TabIndex = 5;
            // 
            // listBox_Files
            // 
            this.listBox_Files.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_Files.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Files.ItemHeight = 20;
            this.listBox_Files.Location = new System.Drawing.Point(0, 0);
            this.listBox_Files.Name = "listBox_Files";
            this.listBox_Files.Size = new System.Drawing.Size(105, 385);
            this.listBox_Files.TabIndex = 1;
            this.listBox_Files.SelectedIndexChanged += new System.EventHandler(this.ListBox_Files_SelectedIndexChanged);
            // 
            // rtb_Log
            // 
            this.rtb_Log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Log.Location = new System.Drawing.Point(0, 0);
            this.rtb_Log.Name = "rtb_Log";
            this.rtb_Log.ReadOnly = true;
            this.rtb_Log.Size = new System.Drawing.Size(890, 81);
            this.rtb_Log.TabIndex = 0;
            this.rtb_Log.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(894, 500);
            this.Controls.Add(this.splitContainer_Log);
            this.Controls.Add(this.menuStrip_Main);
            this.DropShadowEffect = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.HeaderHeight = -40;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_Main;
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "MainForm";
            this.Opacity = 0.99D;
            this.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.ShowHeader = true;
            this.ShowLeftRect = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.Text = "AtlusMSGEditor";
            this.TextColor = System.Drawing.Color.White;
            this.ThemeName = "MetroDark";
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.splitContainer_Main.Panel1.ResumeLayout(false);
            this.splitContainer_Main.Panel2.ResumeLayout(false);
            this.splitContainer_Main.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Main)).EndInit();
            this.splitContainer_Main.ResumeLayout(false);
            this.tlp_ListAndSearch.ResumeLayout(false);
            this.tlp_ListAndSearch.PerformLayout();
            this.panel_Editor.ResumeLayout(false);
            this.tlp_Editor.ResumeLayout(false);
            this.tlp_Editor.PerformLayout();
            this.splitContainer_Log.Panel1.ResumeLayout(false);
            this.splitContainer_Log.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Log)).EndInit();
            this.splitContainer_Log.ResumeLayout(false);
            this.splitContainer_Directories.Panel1.ResumeLayout(false);
            this.splitContainer_Directories.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Directories)).EndInit();
            this.splitContainer_Directories.ResumeLayout(false);
            this.splitContainer_Files.Panel1.ResumeLayout(false);
            this.splitContainer_Files.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Files)).EndInit();
            this.splitContainer_Files.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip_Main;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ColumnHeader columnHeader;
        private SplitContainer splitContainer_Main;
        private Panel panel_Editor;
        private TableLayoutPanel tlp_Editor;
        private ListBox listBox_Msgs;
        private Label lbl_MsgName;
        private TextBox txt_MsgTxt;
        private Label lbl_MsgTxt;
        private TextBox txt_MsgName;
        private ToolStripMenuItem toggleThemeToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem importToolStripMenuItem;
        private TextBox txt_Search;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem outputBMDToolStripMenuItem;
        private TableLayoutPanel tlp_ListAndSearch;
        private ToolStripComboBox comboBox_Encoding;
        private ToolStripMenuItem deleteOutputMSGToolStripMenuItem;
        private MetroSetCheckBox chk_ShowOldMsgText;
        private SplitContainer splitContainer_Log;
        private SplitContainer splitContainer_Directories;
        private ListBox listBox_Directories;
        private RichTextBox rtb_Log;
        private SplitContainer splitContainer_Files;
        private ListBox listBox_Files;
        private ToolStripMenuItem exportTXTsToolStripMenuItem;
        private ToolStripMenuItem deleteExistingDumpDirToolStripMenuItem;
        private Label lbl_MsgType;
        private Label lbl_Speaker;
        private TextBox txt_Speaker;
        private ComboBox comboBox_MsgType;
    }
}