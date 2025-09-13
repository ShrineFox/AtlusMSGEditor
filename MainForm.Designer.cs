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
            columnHeader = new ColumnHeader();
            splitContainer_Main = new SplitContainer();
            groupBox_Msgs = new GroupBox();
            tlp_ListAndSearch = new TableLayoutPanel();
            txt_Search = new TextBox();
            listBox_Msgs = new ListBox();
            panel_Editor = new Panel();
            tabControl_EditorType = new MetroSetTabControl();
            tabPage_Message = new TabPage();
            tlp_Editor = new TableLayoutPanel();
            lbl_MsgName = new Label();
            txt_MsgName = new TextBox();
            chk_ShowOldMsgText = new MetroSetCheckBox();
            lbl_MsgTxt = new Label();
            txt_MsgTxt = new TextBox();
            lbl_MsgType = new Label();
            lbl_Speaker = new Label();
            txt_Speaker = new TextBox();
            comboBox_MsgType = new ComboBox();
            tabPage_Flowscript = new TabPage();
            panel_FlowScript = new Panel();
            tlp_Flowscript = new TableLayoutPanel();
            chk_UseMessageName = new MetroSetCheckBox();
            txt_Flowscript = new TextBox();
            btn_ExportScript = new Button();
            splitContainer_Log = new SplitContainer();
            splitContainer_Directories = new SplitContainer();
            groupBox_Directories = new GroupBox();
            tlp_DirsAndSearch = new TableLayoutPanel();
            listBox_Directories = new ListBox();
            chk_IncludeDirsInSearch = new MetroSetCheckBox();
            splitContainer_Files = new SplitContainer();
            groupBox_Files = new GroupBox();
            tlp_FilesAndSearch = new TableLayoutPanel();
            chk_IncludeFilesInSearch = new MetroSetCheckBox();
            listBox_Files = new ListBox();
            tlp_Progress = new TableLayoutPanel();
            rtb_Log = new RichTextBox();
            progressBar1 = new ProgressBar();
            menuStrip_Main = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            importToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            exportTXTsToolStripMenuItem = new ToolStripMenuItem();
            createJSONDumpToolStripMenuItem = new ToolStripMenuItem();
            setInputPathToolStripMenuItem = new ToolStripMenuItem();
            setOutputPathToolStripMenuItem = new ToolStripMenuItem();
            setFEmulatorOutputPathToolStripMenuItem = new ToolStripMenuItem();
            setAtlusScriptCompilerPathToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            outputBMDToolStripMenuItem = new ToolStripMenuItem();
            deleteOutputMSGToolStripMenuItem = new ToolStripMenuItem();
            deleteExistingDumpDirToolStripMenuItem = new ToolStripMenuItem();
            deleteExistingOutputDirToolStripMenuItem = new ToolStripMenuItem();
            showAutoReplacedFilesToolStripMenuItem = new ToolStripMenuItem();
            exportAutoReplacedFilesToolStripMenuItem = new ToolStripMenuItem();
            exportOnlyEditedMessagesToolStripMenuItem = new ToolStripMenuItem();
            showDecompiledFLOWToolStripMenuItem = new ToolStripMenuItem();
            comboBox_Encoding = new ToolStripComboBox();
            toggleThemeToolStripMenuItem = new ToolStripMenuItem();
            autoReplaceToolStripMenuItem = new ToolStripMenuItem();
            refreshToolStripMenuItem = new ToolStripMenuItem();
            copyLinesInVoicePackOrderToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer_Main).BeginInit();
            splitContainer_Main.Panel1.SuspendLayout();
            splitContainer_Main.Panel2.SuspendLayout();
            splitContainer_Main.SuspendLayout();
            groupBox_Msgs.SuspendLayout();
            tlp_ListAndSearch.SuspendLayout();
            panel_Editor.SuspendLayout();
            tabControl_EditorType.SuspendLayout();
            tabPage_Message.SuspendLayout();
            tlp_Editor.SuspendLayout();
            tabPage_Flowscript.SuspendLayout();
            panel_FlowScript.SuspendLayout();
            tlp_Flowscript.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_Log).BeginInit();
            splitContainer_Log.Panel1.SuspendLayout();
            splitContainer_Log.Panel2.SuspendLayout();
            splitContainer_Log.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_Directories).BeginInit();
            splitContainer_Directories.Panel1.SuspendLayout();
            splitContainer_Directories.Panel2.SuspendLayout();
            splitContainer_Directories.SuspendLayout();
            groupBox_Directories.SuspendLayout();
            tlp_DirsAndSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_Files).BeginInit();
            splitContainer_Files.Panel1.SuspendLayout();
            splitContainer_Files.Panel2.SuspendLayout();
            splitContainer_Files.SuspendLayout();
            groupBox_Files.SuspendLayout();
            tlp_FilesAndSearch.SuspendLayout();
            tlp_Progress.SuspendLayout();
            menuStrip_Main.SuspendLayout();
            SuspendLayout();
            // 
            // columnHeader
            // 
            columnHeader.Width = 100;
            // 
            // splitContainer_Main
            // 
            splitContainer_Main.Dock = DockStyle.Fill;
            splitContainer_Main.Location = new Point(0, 0);
            splitContainer_Main.Name = "splitContainer_Main";
            // 
            // splitContainer_Main.Panel1
            // 
            splitContainer_Main.Panel1.Controls.Add(groupBox_Msgs);
            // 
            // splitContainer_Main.Panel2
            // 
            splitContainer_Main.Panel2.Controls.Add(panel_Editor);
            splitContainer_Main.Size = new Size(557, 456);
            splitContainer_Main.SplitterDistance = 160;
            splitContainer_Main.TabIndex = 3;
            // 
            // groupBox_Msgs
            // 
            groupBox_Msgs.Controls.Add(tlp_ListAndSearch);
            groupBox_Msgs.Dock = DockStyle.Fill;
            groupBox_Msgs.Location = new Point(0, 0);
            groupBox_Msgs.Name = "groupBox_Msgs";
            groupBox_Msgs.Size = new Size(160, 456);
            groupBox_Msgs.TabIndex = 0;
            groupBox_Msgs.TabStop = false;
            groupBox_Msgs.Text = "Messages";
            // 
            // tlp_ListAndSearch
            // 
            tlp_ListAndSearch.ColumnCount = 1;
            tlp_ListAndSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp_ListAndSearch.Controls.Add(txt_Search, 0, 0);
            tlp_ListAndSearch.Controls.Add(listBox_Msgs, 0, 1);
            tlp_ListAndSearch.Dock = DockStyle.Fill;
            tlp_ListAndSearch.Location = new Point(3, 22);
            tlp_ListAndSearch.Margin = new Padding(0);
            tlp_ListAndSearch.Name = "tlp_ListAndSearch";
            tlp_ListAndSearch.RowCount = 2;
            tlp_ListAndSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tlp_ListAndSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 92F));
            tlp_ListAndSearch.Size = new Size(154, 431);
            tlp_ListAndSearch.TabIndex = 2;
            // 
            // txt_Search
            // 
            txt_Search.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_Search.Location = new Point(3, 4);
            txt_Search.Name = "txt_Search";
            txt_Search.Size = new Size(148, 26);
            txt_Search.TabIndex = 5;
            txt_Search.Text = "Search...";
            txt_Search.KeyDown += Search_KeyDown;
            // 
            // listBox_Msgs
            // 
            listBox_Msgs.BorderStyle = BorderStyle.FixedSingle;
            listBox_Msgs.Dock = DockStyle.Fill;
            listBox_Msgs.Location = new Point(3, 37);
            listBox_Msgs.Name = "listBox_Msgs";
            listBox_Msgs.Size = new Size(148, 391);
            listBox_Msgs.TabIndex = 0;
            listBox_Msgs.SelectedIndexChanged += ListBox_Msgs_SelectedIndexChanged;
            listBox_Msgs.KeyDown += ListBox_KeyDown;
            // 
            // panel_Editor
            // 
            panel_Editor.AutoSize = true;
            panel_Editor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel_Editor.Controls.Add(tabControl_EditorType);
            panel_Editor.Dock = DockStyle.Fill;
            panel_Editor.Location = new Point(0, 0);
            panel_Editor.Name = "panel_Editor";
            panel_Editor.Padding = new Padding(0, 30, 0, 0);
            panel_Editor.Size = new Size(393, 456);
            panel_Editor.TabIndex = 0;
            // 
            // tabControl_EditorType
            // 
            tabControl_EditorType.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            tabControl_EditorType.AnimateTime = 200;
            tabControl_EditorType.BackgroundColor = Color.FromArgb(30, 30, 30);
            tabControl_EditorType.Controls.Add(tabPage_Message);
            tabControl_EditorType.Controls.Add(tabPage_Flowscript);
            tabControl_EditorType.Dock = DockStyle.Fill;
            tabControl_EditorType.IsDerivedStyle = true;
            tabControl_EditorType.ItemSize = new Size(100, 38);
            tabControl_EditorType.Location = new Point(0, 30);
            tabControl_EditorType.Name = "tabControl_EditorType";
            tabControl_EditorType.SelectedIndex = 1;
            tabControl_EditorType.SelectedTextColor = Color.White;
            tabControl_EditorType.Size = new Size(393, 426);
            tabControl_EditorType.SizeMode = TabSizeMode.Fixed;
            tabControl_EditorType.Speed = 100;
            tabControl_EditorType.Style = MetroSet_UI.Enums.Style.Dark;
            tabControl_EditorType.StyleManager = null;
            tabControl_EditorType.TabIndex = 0;
            tabControl_EditorType.ThemeAuthor = "Narwin";
            tabControl_EditorType.ThemeName = "MetroDark";
            tabControl_EditorType.UnselectedTextColor = Color.Gray;
            tabControl_EditorType.UseAnimation = false;
            // 
            // tabPage_Message
            // 
            tabPage_Message.AutoScroll = true;
            tabPage_Message.Controls.Add(tlp_Editor);
            tabPage_Message.Location = new Point(4, 42);
            tabPage_Message.Name = "tabPage_Message";
            tabPage_Message.Size = new Size(385, 380);
            tabPage_Message.TabIndex = 0;
            tabPage_Message.Text = "Message";
            // 
            // tlp_Editor
            // 
            tlp_Editor.AutoScroll = true;
            tlp_Editor.ColumnCount = 2;
            tlp_Editor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlp_Editor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tlp_Editor.Controls.Add(lbl_MsgName, 0, 0);
            tlp_Editor.Controls.Add(txt_MsgName, 1, 0);
            tlp_Editor.Controls.Add(chk_ShowOldMsgText, 1, 4);
            tlp_Editor.Controls.Add(lbl_MsgTxt, 0, 3);
            tlp_Editor.Controls.Add(txt_MsgTxt, 1, 3);
            tlp_Editor.Controls.Add(lbl_MsgType, 0, 1);
            tlp_Editor.Controls.Add(lbl_Speaker, 0, 2);
            tlp_Editor.Controls.Add(txt_Speaker, 1, 2);
            tlp_Editor.Controls.Add(comboBox_MsgType, 1, 1);
            tlp_Editor.Dock = DockStyle.Top;
            tlp_Editor.Location = new Point(0, 0);
            tlp_Editor.Name = "tlp_Editor";
            tlp_Editor.RowCount = 5;
            tlp_Editor.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlp_Editor.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlp_Editor.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlp_Editor.RowStyles.Add(new RowStyle(SizeType.Absolute, 220F));
            tlp_Editor.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlp_Editor.Size = new Size(364, 464);
            tlp_Editor.TabIndex = 1;
            // 
            // lbl_MsgName
            // 
            lbl_MsgName.Anchor = AnchorStyles.Right;
            lbl_MsgName.AutoSize = true;
            lbl_MsgName.Location = new Point(30, 0);
            lbl_MsgName.Name = "lbl_MsgName";
            lbl_MsgName.Size = new Size(58, 40);
            lbl_MsgName.TabIndex = 2;
            lbl_MsgName.Text = "Msg Name:";
            lbl_MsgName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_MsgName
            // 
            txt_MsgName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_MsgName.Enabled = false;
            txt_MsgName.Location = new Point(94, 7);
            txt_MsgName.Name = "txt_MsgName";
            txt_MsgName.ReadOnly = true;
            txt_MsgName.Size = new Size(267, 26);
            txt_MsgName.TabIndex = 6;
            // 
            // chk_ShowOldMsgText
            // 
            chk_ShowOldMsgText.BackColor = Color.Transparent;
            chk_ShowOldMsgText.BackgroundColor = Color.White;
            chk_ShowOldMsgText.BorderColor = Color.FromArgb(155, 155, 155);
            chk_ShowOldMsgText.Checked = false;
            chk_ShowOldMsgText.CheckSignColor = Color.FromArgb(65, 177, 225);
            chk_ShowOldMsgText.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            chk_ShowOldMsgText.Cursor = Cursors.Hand;
            chk_ShowOldMsgText.DisabledBorderColor = Color.FromArgb(205, 205, 205);
            chk_ShowOldMsgText.Font = new Font("Microsoft Sans Serif", 10F);
            chk_ShowOldMsgText.IsDerivedStyle = true;
            chk_ShowOldMsgText.Location = new Point(94, 343);
            chk_ShowOldMsgText.Name = "chk_ShowOldMsgText";
            chk_ShowOldMsgText.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            chk_ShowOldMsgText.Size = new Size(213, 16);
            chk_ShowOldMsgText.Style = MetroSet_UI.Enums.Style.Light;
            chk_ShowOldMsgText.StyleManager = null;
            chk_ShowOldMsgText.TabIndex = 10;
            chk_ShowOldMsgText.Text = "Show Old Message Text";
            chk_ShowOldMsgText.ThemeAuthor = "Narwin";
            chk_ShowOldMsgText.ThemeName = "MetroLite";
            chk_ShowOldMsgText.CheckedChanged += ShowOldMsg_CheckedChanged;
            // 
            // lbl_MsgTxt
            // 
            lbl_MsgTxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_MsgTxt.AutoSize = true;
            lbl_MsgTxt.Location = new Point(5, 120);
            lbl_MsgTxt.Name = "lbl_MsgTxt";
            lbl_MsgTxt.Size = new Size(83, 20);
            lbl_MsgTxt.TabIndex = 5;
            lbl_MsgTxt.Text = "Msg Text:";
            lbl_MsgTxt.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_MsgTxt
            // 
            txt_MsgTxt.Dock = DockStyle.Fill;
            txt_MsgTxt.Location = new Point(94, 123);
            txt_MsgTxt.Multiline = true;
            txt_MsgTxt.Name = "txt_MsgTxt";
            txt_MsgTxt.Size = new Size(267, 214);
            txt_MsgTxt.TabIndex = 9;
            txt_MsgTxt.TextChanged += Desc_Changed;
            // 
            // lbl_MsgType
            // 
            lbl_MsgType.Anchor = AnchorStyles.Right;
            lbl_MsgType.AutoSize = true;
            lbl_MsgType.Location = new Point(38, 50);
            lbl_MsgType.Name = "lbl_MsgType";
            lbl_MsgType.Size = new Size(50, 20);
            lbl_MsgType.TabIndex = 11;
            lbl_MsgType.Text = "Type:";
            lbl_MsgType.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_Speaker
            // 
            lbl_Speaker.Anchor = AnchorStyles.Right;
            lbl_Speaker.AutoSize = true;
            lbl_Speaker.Location = new Point(13, 90);
            lbl_Speaker.Name = "lbl_Speaker";
            lbl_Speaker.Size = new Size(75, 20);
            lbl_Speaker.TabIndex = 12;
            lbl_Speaker.Text = "Speaker:";
            lbl_Speaker.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_Speaker
            // 
            txt_Speaker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_Speaker.Location = new Point(94, 87);
            txt_Speaker.Name = "txt_Speaker";
            txt_Speaker.Size = new Size(267, 26);
            txt_Speaker.TabIndex = 13;
            txt_Speaker.TextChanged += Desc_Changed;
            // 
            // comboBox_MsgType
            // 
            comboBox_MsgType.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBox_MsgType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_MsgType.Enabled = false;
            comboBox_MsgType.FormattingEnabled = true;
            comboBox_MsgType.Items.AddRange(new object[] { "Dialog", "Selection" });
            comboBox_MsgType.Location = new Point(94, 46);
            comboBox_MsgType.Name = "comboBox_MsgType";
            comboBox_MsgType.Size = new Size(267, 28);
            comboBox_MsgType.TabIndex = 14;
            // 
            // tabPage_Flowscript
            // 
            tabPage_Flowscript.AutoScroll = true;
            tabPage_Flowscript.Controls.Add(panel_FlowScript);
            tabPage_Flowscript.Location = new Point(4, 42);
            tabPage_Flowscript.Name = "tabPage_Flowscript";
            tabPage_Flowscript.Size = new Size(385, 380);
            tabPage_Flowscript.TabIndex = 1;
            tabPage_Flowscript.Text = "Script";
            // 
            // panel_FlowScript
            // 
            panel_FlowScript.AutoScroll = true;
            panel_FlowScript.Controls.Add(tlp_Flowscript);
            panel_FlowScript.Dock = DockStyle.Fill;
            panel_FlowScript.Location = new Point(0, 0);
            panel_FlowScript.Name = "panel_FlowScript";
            panel_FlowScript.Size = new Size(385, 380);
            panel_FlowScript.TabIndex = 0;
            // 
            // tlp_Flowscript
            // 
            tlp_Flowscript.ColumnCount = 2;
            tlp_Flowscript.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_Flowscript.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_Flowscript.Controls.Add(chk_UseMessageName, 0, 1);
            tlp_Flowscript.Controls.Add(txt_Flowscript, 0, 0);
            tlp_Flowscript.Controls.Add(btn_ExportScript, 1, 1);
            tlp_Flowscript.Dock = DockStyle.Fill;
            tlp_Flowscript.Location = new Point(0, 0);
            tlp_Flowscript.Name = "tlp_Flowscript";
            tlp_Flowscript.RowCount = 2;
            tlp_Flowscript.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp_Flowscript.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlp_Flowscript.Size = new Size(385, 380);
            tlp_Flowscript.TabIndex = 0;
            // 
            // chk_UseMessageName
            // 
            chk_UseMessageName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            chk_UseMessageName.BackColor = Color.Transparent;
            chk_UseMessageName.BackgroundColor = Color.White;
            chk_UseMessageName.BorderColor = Color.FromArgb(155, 155, 155);
            chk_UseMessageName.Checked = true;
            chk_UseMessageName.CheckSignColor = Color.FromArgb(65, 177, 225);
            chk_UseMessageName.CheckState = MetroSet_UI.Enums.CheckState.Checked;
            chk_UseMessageName.Cursor = Cursors.Hand;
            chk_UseMessageName.DisabledBorderColor = Color.FromArgb(205, 205, 205);
            chk_UseMessageName.Font = new Font("Microsoft Sans Serif", 10F);
            chk_UseMessageName.IsDerivedStyle = true;
            chk_UseMessageName.Location = new Point(3, 352);
            chk_UseMessageName.Name = "chk_UseMessageName";
            chk_UseMessageName.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            chk_UseMessageName.Size = new Size(186, 16);
            chk_UseMessageName.Style = MetroSet_UI.Enums.Style.Light;
            chk_UseMessageName.StyleManager = null;
            chk_UseMessageName.TabIndex = 12;
            chk_UseMessageName.Text = "Use Message Names";
            chk_UseMessageName.ThemeAuthor = "Narwin";
            chk_UseMessageName.ThemeName = "MetroLite";
            // 
            // txt_Flowscript
            // 
            tlp_Flowscript.SetColumnSpan(txt_Flowscript, 2);
            txt_Flowscript.Dock = DockStyle.Fill;
            txt_Flowscript.Enabled = false;
            txt_Flowscript.Location = new Point(3, 3);
            txt_Flowscript.Multiline = true;
            txt_Flowscript.Name = "txt_Flowscript";
            txt_Flowscript.ScrollBars = ScrollBars.Vertical;
            txt_Flowscript.Size = new Size(379, 334);
            txt_Flowscript.TabIndex = 11;
            // 
            // btn_ExportScript
            // 
            btn_ExportScript.Dock = DockStyle.Right;
            btn_ExportScript.Enabled = false;
            btn_ExportScript.Location = new Point(207, 343);
            btn_ExportScript.Name = "btn_ExportScript";
            btn_ExportScript.Size = new Size(175, 34);
            btn_ExportScript.TabIndex = 0;
            btn_ExportScript.Text = "Export Script";
            btn_ExportScript.UseVisualStyleBackColor = true;
            btn_ExportScript.Click += ExportScript_Click;
            // 
            // splitContainer_Log
            // 
            splitContainer_Log.Dock = DockStyle.Fill;
            splitContainer_Log.Location = new Point(2, 0);
            splitContainer_Log.Name = "splitContainer_Log";
            splitContainer_Log.Orientation = Orientation.Horizontal;
            // 
            // splitContainer_Log.Panel1
            // 
            splitContainer_Log.Panel1.Controls.Add(splitContainer_Directories);
            // 
            // splitContainer_Log.Panel2
            // 
            splitContainer_Log.Panel2.Controls.Add(tlp_Progress);
            splitContainer_Log.Size = new Size(1264, 562);
            splitContainer_Log.SplitterDistance = 456;
            splitContainer_Log.TabIndex = 4;
            // 
            // splitContainer_Directories
            // 
            splitContainer_Directories.Dock = DockStyle.Fill;
            splitContainer_Directories.Location = new Point(0, 0);
            splitContainer_Directories.Name = "splitContainer_Directories";
            // 
            // splitContainer_Directories.Panel1
            // 
            splitContainer_Directories.Panel1.Controls.Add(groupBox_Directories);
            // 
            // splitContainer_Directories.Panel2
            // 
            splitContainer_Directories.Panel2.Controls.Add(splitContainer_Files);
            splitContainer_Directories.Size = new Size(1264, 456);
            splitContainer_Directories.SplitterDistance = 444;
            splitContainer_Directories.TabIndex = 0;
            // 
            // groupBox_Directories
            // 
            groupBox_Directories.Controls.Add(tlp_DirsAndSearch);
            groupBox_Directories.Dock = DockStyle.Fill;
            groupBox_Directories.Location = new Point(0, 0);
            groupBox_Directories.Name = "groupBox_Directories";
            groupBox_Directories.Size = new Size(444, 456);
            groupBox_Directories.TabIndex = 0;
            groupBox_Directories.TabStop = false;
            groupBox_Directories.Text = "Directories";
            // 
            // tlp_DirsAndSearch
            // 
            tlp_DirsAndSearch.ColumnCount = 1;
            tlp_DirsAndSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp_DirsAndSearch.Controls.Add(listBox_Directories, 0, 1);
            tlp_DirsAndSearch.Controls.Add(chk_IncludeDirsInSearch, 0, 0);
            tlp_DirsAndSearch.Dock = DockStyle.Fill;
            tlp_DirsAndSearch.Location = new Point(3, 22);
            tlp_DirsAndSearch.Name = "tlp_DirsAndSearch";
            tlp_DirsAndSearch.RowCount = 2;
            tlp_DirsAndSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tlp_DirsAndSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 92F));
            tlp_DirsAndSearch.Size = new Size(438, 431);
            tlp_DirsAndSearch.TabIndex = 0;
            // 
            // listBox_Directories
            // 
            listBox_Directories.BorderStyle = BorderStyle.FixedSingle;
            listBox_Directories.Dock = DockStyle.Fill;
            listBox_Directories.Location = new Point(3, 37);
            listBox_Directories.Name = "listBox_Directories";
            listBox_Directories.Size = new Size(432, 391);
            listBox_Directories.TabIndex = 4;
            listBox_Directories.SelectedIndexChanged += ListBox_Dirs_SelectedIndexChanged;
            listBox_Directories.KeyDown += ListBox_KeyDown;
            // 
            // chk_IncludeDirsInSearch
            // 
            chk_IncludeDirsInSearch.Anchor = AnchorStyles.Left;
            chk_IncludeDirsInSearch.BackColor = Color.Transparent;
            chk_IncludeDirsInSearch.BackgroundColor = Color.White;
            chk_IncludeDirsInSearch.BorderColor = Color.FromArgb(155, 155, 155);
            chk_IncludeDirsInSearch.Checked = true;
            chk_IncludeDirsInSearch.CheckSignColor = Color.FromArgb(65, 177, 225);
            chk_IncludeDirsInSearch.CheckState = MetroSet_UI.Enums.CheckState.Checked;
            chk_IncludeDirsInSearch.Cursor = Cursors.Hand;
            chk_IncludeDirsInSearch.DisabledBorderColor = Color.FromArgb(205, 205, 205);
            chk_IncludeDirsInSearch.Font = new Font("Microsoft Sans Serif", 10F);
            chk_IncludeDirsInSearch.IsDerivedStyle = true;
            chk_IncludeDirsInSearch.Location = new Point(3, 9);
            chk_IncludeDirsInSearch.Name = "chk_IncludeDirsInSearch";
            chk_IncludeDirsInSearch.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            chk_IncludeDirsInSearch.Size = new Size(266, 16);
            chk_IncludeDirsInSearch.Style = MetroSet_UI.Enums.Style.Light;
            chk_IncludeDirsInSearch.StyleManager = null;
            chk_IncludeDirsInSearch.TabIndex = 12;
            chk_IncludeDirsInSearch.Text = "Include All Directories in Search";
            chk_IncludeDirsInSearch.ThemeAuthor = "Narwin";
            chk_IncludeDirsInSearch.ThemeName = "MetroLite";
            // 
            // splitContainer_Files
            // 
            splitContainer_Files.Dock = DockStyle.Fill;
            splitContainer_Files.Location = new Point(0, 0);
            splitContainer_Files.Name = "splitContainer_Files";
            // 
            // splitContainer_Files.Panel1
            // 
            splitContainer_Files.Panel1.Controls.Add(groupBox_Files);
            // 
            // splitContainer_Files.Panel2
            // 
            splitContainer_Files.Panel2.Controls.Add(splitContainer_Main);
            splitContainer_Files.Size = new Size(816, 456);
            splitContainer_Files.SplitterDistance = 255;
            splitContainer_Files.TabIndex = 5;
            // 
            // groupBox_Files
            // 
            groupBox_Files.Controls.Add(tlp_FilesAndSearch);
            groupBox_Files.Dock = DockStyle.Fill;
            groupBox_Files.Location = new Point(0, 0);
            groupBox_Files.Name = "groupBox_Files";
            groupBox_Files.Size = new Size(255, 456);
            groupBox_Files.TabIndex = 1;
            groupBox_Files.TabStop = false;
            groupBox_Files.Text = "Files";
            // 
            // tlp_FilesAndSearch
            // 
            tlp_FilesAndSearch.ColumnCount = 1;
            tlp_FilesAndSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp_FilesAndSearch.Controls.Add(chk_IncludeFilesInSearch, 0, 0);
            tlp_FilesAndSearch.Controls.Add(listBox_Files, 0, 1);
            tlp_FilesAndSearch.Dock = DockStyle.Fill;
            tlp_FilesAndSearch.Location = new Point(3, 22);
            tlp_FilesAndSearch.Name = "tlp_FilesAndSearch";
            tlp_FilesAndSearch.RowCount = 2;
            tlp_FilesAndSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tlp_FilesAndSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 92F));
            tlp_FilesAndSearch.Size = new Size(249, 431);
            tlp_FilesAndSearch.TabIndex = 0;
            // 
            // chk_IncludeFilesInSearch
            // 
            chk_IncludeFilesInSearch.Anchor = AnchorStyles.Left;
            chk_IncludeFilesInSearch.BackColor = Color.Transparent;
            chk_IncludeFilesInSearch.BackgroundColor = Color.White;
            chk_IncludeFilesInSearch.BorderColor = Color.FromArgb(155, 155, 155);
            chk_IncludeFilesInSearch.Checked = true;
            chk_IncludeFilesInSearch.CheckSignColor = Color.FromArgb(65, 177, 225);
            chk_IncludeFilesInSearch.CheckState = MetroSet_UI.Enums.CheckState.Checked;
            chk_IncludeFilesInSearch.Cursor = Cursors.Hand;
            chk_IncludeFilesInSearch.DisabledBorderColor = Color.FromArgb(205, 205, 205);
            chk_IncludeFilesInSearch.Font = new Font("Microsoft Sans Serif", 10F);
            chk_IncludeFilesInSearch.IsDerivedStyle = true;
            chk_IncludeFilesInSearch.Location = new Point(3, 9);
            chk_IncludeFilesInSearch.Name = "chk_IncludeFilesInSearch";
            chk_IncludeFilesInSearch.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            chk_IncludeFilesInSearch.Size = new Size(223, 16);
            chk_IncludeFilesInSearch.Style = MetroSet_UI.Enums.Style.Light;
            chk_IncludeFilesInSearch.StyleManager = null;
            chk_IncludeFilesInSearch.TabIndex = 11;
            chk_IncludeFilesInSearch.Text = "Include All Files in Search";
            chk_IncludeFilesInSearch.ThemeAuthor = "Narwin";
            chk_IncludeFilesInSearch.ThemeName = "MetroLite";
            // 
            // listBox_Files
            // 
            listBox_Files.BorderStyle = BorderStyle.FixedSingle;
            listBox_Files.Dock = DockStyle.Fill;
            listBox_Files.Location = new Point(3, 37);
            listBox_Files.Name = "listBox_Files";
            listBox_Files.Size = new Size(243, 391);
            listBox_Files.TabIndex = 2;
            listBox_Files.SelectedIndexChanged += ListBox_Files_SelectedIndexChanged;
            listBox_Files.KeyDown += ListBox_KeyDown;
            // 
            // tlp_Progress
            // 
            tlp_Progress.ColumnCount = 1;
            tlp_Progress.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp_Progress.Controls.Add(rtb_Log, 0, 1);
            tlp_Progress.Controls.Add(progressBar1, 0, 0);
            tlp_Progress.Dock = DockStyle.Fill;
            tlp_Progress.Location = new Point(0, 0);
            tlp_Progress.Name = "tlp_Progress";
            tlp_Progress.RowCount = 2;
            tlp_Progress.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tlp_Progress.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tlp_Progress.Size = new Size(1264, 102);
            tlp_Progress.TabIndex = 0;
            // 
            // rtb_Log
            // 
            rtb_Log.BorderStyle = BorderStyle.None;
            rtb_Log.Location = new Point(3, 18);
            rtb_Log.Name = "rtb_Log";
            rtb_Log.ReadOnly = true;
            rtb_Log.Size = new Size(1258, 75);
            rtb_Log.TabIndex = 1;
            rtb_Log.Text = "";
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Fill;
            progressBar1.Location = new Point(3, 3);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1258, 9);
            progressBar1.TabIndex = 2;
            // 
            // menuStrip_Main
            // 
            menuStrip_Main.ImageScalingSize = new Size(20, 20);
            menuStrip_Main.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, optionsToolStripMenuItem, toggleThemeToolStripMenuItem, autoReplaceToolStripMenuItem, refreshToolStripMenuItem });
            menuStrip_Main.Location = new Point(2, 0);
            menuStrip_Main.Name = "menuStrip_Main";
            menuStrip_Main.Padding = new Padding(3, 2, 0, 2);
            menuStrip_Main.Size = new Size(1264, 28);
            menuStrip_Main.TabIndex = 5;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, loadToolStripMenuItem, importToolStripMenuItem, exportToolStripMenuItem, exportTXTsToolStripMenuItem, createJSONDumpToolStripMenuItem, setInputPathToolStripMenuItem, setOutputPathToolStripMenuItem, setFEmulatorOutputPathToolStripMenuItem, setAtlusScriptCompilerPathToolStripMenuItem, copyLinesInVoicePackOrderToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(290, 26);
            saveToolStripMenuItem.Text = "Save Project";
            saveToolStripMenuItem.Click += SaveProject_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(290, 26);
            loadToolStripMenuItem.Text = "Load Project";
            loadToolStripMenuItem.Click += Load_Click;
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(290, 26);
            importToolStripMenuItem.Text = "Import .BMDs";
            importToolStripMenuItem.Click += ImportBMDs_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(290, 26);
            exportToolStripMenuItem.Text = "Export .BMDs";
            exportToolStripMenuItem.Click += ExportBMDs_Click;
            // 
            // exportTXTsToolStripMenuItem
            // 
            exportTXTsToolStripMenuItem.Name = "exportTXTsToolStripMenuItem";
            exportTXTsToolStripMenuItem.Size = new Size(290, 26);
            exportTXTsToolStripMenuItem.Text = "Create .TXT Dump";
            exportTXTsToolStripMenuItem.Click += ExportTXTs_Click;
            // 
            // createJSONDumpToolStripMenuItem
            // 
            createJSONDumpToolStripMenuItem.Name = "createJSONDumpToolStripMenuItem";
            createJSONDumpToolStripMenuItem.Size = new Size(290, 26);
            createJSONDumpToolStripMenuItem.Text = "Create .JSON Dump";
            createJSONDumpToolStripMenuItem.Click += JsonDump_Click;
            // 
            // setInputPathToolStripMenuItem
            // 
            setInputPathToolStripMenuItem.Name = "setInputPathToolStripMenuItem";
            setInputPathToolStripMenuItem.Size = new Size(290, 26);
            setInputPathToolStripMenuItem.Text = "Set Input Path...";
            setInputPathToolStripMenuItem.Click += SetInputPath_Click;
            // 
            // setOutputPathToolStripMenuItem
            // 
            setOutputPathToolStripMenuItem.Name = "setOutputPathToolStripMenuItem";
            setOutputPathToolStripMenuItem.Size = new Size(290, 26);
            setOutputPathToolStripMenuItem.Text = "Set CPK Output Path...";
            setOutputPathToolStripMenuItem.Click += SetCPKOutputPath_Click;
            // 
            // setFEmulatorOutputPathToolStripMenuItem
            // 
            setFEmulatorOutputPathToolStripMenuItem.Name = "setFEmulatorOutputPathToolStripMenuItem";
            setFEmulatorOutputPathToolStripMenuItem.Size = new Size(290, 26);
            setFEmulatorOutputPathToolStripMenuItem.Text = "Set FEmulator Output Path...";
            setFEmulatorOutputPathToolStripMenuItem.Click += SetFEmuOutputPath_Click;
            // 
            // setAtlusScriptCompilerPathToolStripMenuItem
            // 
            setAtlusScriptCompilerPathToolStripMenuItem.Name = "setAtlusScriptCompilerPathToolStripMenuItem";
            setAtlusScriptCompilerPathToolStripMenuItem.Size = new Size(290, 26);
            setAtlusScriptCompilerPathToolStripMenuItem.Text = "Set AtlusScriptCompiler Path...";
            setAtlusScriptCompilerPathToolStripMenuItem.Click += CompilerPath_Click;
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { outputBMDToolStripMenuItem, deleteOutputMSGToolStripMenuItem, deleteExistingDumpDirToolStripMenuItem, deleteExistingOutputDirToolStripMenuItem, showAutoReplacedFilesToolStripMenuItem, exportAutoReplacedFilesToolStripMenuItem, exportOnlyEditedMessagesToolStripMenuItem, showDecompiledFLOWToolStripMenuItem, comboBox_Encoding });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(75, 24);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // outputBMDToolStripMenuItem
            // 
            outputBMDToolStripMenuItem.Checked = true;
            outputBMDToolStripMenuItem.CheckOnClick = true;
            outputBMDToolStripMenuItem.CheckState = CheckState.Checked;
            outputBMDToolStripMenuItem.Name = "outputBMDToolStripMenuItem";
            outputBMDToolStripMenuItem.Size = new Size(284, 26);
            outputBMDToolStripMenuItem.Text = "Output BF/BMD";
            outputBMDToolStripMenuItem.CheckedChanged += MenuStrip_CheckedChanged;
            // 
            // deleteOutputMSGToolStripMenuItem
            // 
            deleteOutputMSGToolStripMenuItem.CheckOnClick = true;
            deleteOutputMSGToolStripMenuItem.Name = "deleteOutputMSGToolStripMenuItem";
            deleteOutputMSGToolStripMenuItem.Size = new Size(284, 26);
            deleteOutputMSGToolStripMenuItem.Text = "Delete Output MSG";
            deleteOutputMSGToolStripMenuItem.CheckedChanged += MenuStrip_CheckedChanged;
            // 
            // deleteExistingDumpDirToolStripMenuItem
            // 
            deleteExistingDumpDirToolStripMenuItem.Checked = true;
            deleteExistingDumpDirToolStripMenuItem.CheckOnClick = true;
            deleteExistingDumpDirToolStripMenuItem.CheckState = CheckState.Checked;
            deleteExistingDumpDirToolStripMenuItem.Name = "deleteExistingDumpDirToolStripMenuItem";
            deleteExistingDumpDirToolStripMenuItem.Size = new Size(284, 26);
            deleteExistingDumpDirToolStripMenuItem.Text = "Delete Existing Dump Dir";
            deleteExistingDumpDirToolStripMenuItem.CheckedChanged += MenuStrip_CheckedChanged;
            // 
            // deleteExistingOutputDirToolStripMenuItem
            // 
            deleteExistingOutputDirToolStripMenuItem.Checked = true;
            deleteExistingOutputDirToolStripMenuItem.CheckOnClick = true;
            deleteExistingOutputDirToolStripMenuItem.CheckState = CheckState.Checked;
            deleteExistingOutputDirToolStripMenuItem.Name = "deleteExistingOutputDirToolStripMenuItem";
            deleteExistingOutputDirToolStripMenuItem.Size = new Size(284, 26);
            deleteExistingOutputDirToolStripMenuItem.Text = "Delete Existing Output Dir";
            deleteExistingOutputDirToolStripMenuItem.CheckedChanged += MenuStrip_CheckedChanged;
            // 
            // showAutoReplacedFilesToolStripMenuItem
            // 
            showAutoReplacedFilesToolStripMenuItem.CheckOnClick = true;
            showAutoReplacedFilesToolStripMenuItem.Name = "showAutoReplacedFilesToolStripMenuItem";
            showAutoReplacedFilesToolStripMenuItem.Size = new Size(284, 26);
            showAutoReplacedFilesToolStripMenuItem.Text = "Show Auto-Replaced Files";
            showAutoReplacedFilesToolStripMenuItem.CheckedChanged += MenuStrip_CheckedChanged;
            // 
            // exportAutoReplacedFilesToolStripMenuItem
            // 
            exportAutoReplacedFilesToolStripMenuItem.CheckOnClick = true;
            exportAutoReplacedFilesToolStripMenuItem.Name = "exportAutoReplacedFilesToolStripMenuItem";
            exportAutoReplacedFilesToolStripMenuItem.Size = new Size(284, 26);
            exportAutoReplacedFilesToolStripMenuItem.Text = "Export Auto-Replaced Files";
            exportAutoReplacedFilesToolStripMenuItem.CheckedChanged += MenuStrip_CheckedChanged;
            // 
            // exportOnlyEditedMessagesToolStripMenuItem
            // 
            exportOnlyEditedMessagesToolStripMenuItem.CheckOnClick = true;
            exportOnlyEditedMessagesToolStripMenuItem.Name = "exportOnlyEditedMessagesToolStripMenuItem";
            exportOnlyEditedMessagesToolStripMenuItem.Size = new Size(284, 26);
            exportOnlyEditedMessagesToolStripMenuItem.Text = "Export Only Edited Messages";
            // 
            // showDecompiledFLOWToolStripMenuItem
            // 
            showDecompiledFLOWToolStripMenuItem.CheckOnClick = true;
            showDecompiledFLOWToolStripMenuItem.Name = "showDecompiledFLOWToolStripMenuItem";
            showDecompiledFLOWToolStripMenuItem.Size = new Size(284, 26);
            showDecompiledFLOWToolStripMenuItem.Text = "Show Decompiled .FLOW";
            showDecompiledFLOWToolStripMenuItem.CheckedChanged += MenuStrip_CheckedChanged;
            // 
            // comboBox_Encoding
            // 
            comboBox_Encoding.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Encoding.DropDownWidth = 150;
            comboBox_Encoding.Items.AddRange(new object[] { "EFIGS", "Japanese" });
            comboBox_Encoding.Name = "comboBox_Encoding";
            comboBox_Encoding.Size = new Size(151, 28);
            comboBox_Encoding.Visible = false;
            comboBox_Encoding.SelectedIndexChanged += Encoding_Changed;
            // 
            // toggleThemeToolStripMenuItem
            // 
            toggleThemeToolStripMenuItem.Name = "toggleThemeToolStripMenuItem";
            toggleThemeToolStripMenuItem.Size = new Size(118, 24);
            toggleThemeToolStripMenuItem.Text = "Toggle Theme";
            toggleThemeToolStripMenuItem.Click += ToggleTheme_Click;
            // 
            // autoReplaceToolStripMenuItem
            // 
            autoReplaceToolStripMenuItem.Name = "autoReplaceToolStripMenuItem";
            autoReplaceToolStripMenuItem.Size = new Size(123, 24);
            autoReplaceToolStripMenuItem.Text = "Auto-Replace...";
            autoReplaceToolStripMenuItem.Click += AutoReplace_Click;
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.Size = new Size(72, 24);
            refreshToolStripMenuItem.Text = "Refresh";
            refreshToolStripMenuItem.Click += Refresh_Click;
            // 
            // copyLinesInVoicePackOrderToolStripMenuItem
            // 
            copyLinesInVoicePackOrderToolStripMenuItem.Name = "copyLinesInVoicePackOrderToolStripMenuItem";
            copyLinesInVoicePackOrderToolStripMenuItem.Size = new Size(290, 26);
            copyLinesInVoicePackOrderToolStripMenuItem.Text = "Copy Lines in VoicePack order";
            copyLinesInVoicePackOrderToolStripMenuItem.Click += CopyLinesInVPOrder_Click;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1268, 564);
            Controls.Add(menuStrip_Main);
            Controls.Add(splitContainer_Log);
            DropShadowEffect = false;
            Font = new Font("Microsoft Sans Serif", 10F);
            FormBorderStyle = FormBorderStyle.Sizable;
            HeaderHeight = -40;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(700, 500);
            Name = "MainForm";
            Opacity = 0.99D;
            Padding = new Padding(2, 0, 2, 2);
            ShowHeader = true;
            ShowLeftRect = false;
            SizeGripStyle = SizeGripStyle.Show;
            Style = MetroSet_UI.Enums.Style.Dark;
            Text = "AtlusMSGEditor";
            TextColor = Color.White;
            ThemeName = "MetroDark";
            splitContainer_Main.Panel1.ResumeLayout(false);
            splitContainer_Main.Panel2.ResumeLayout(false);
            splitContainer_Main.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_Main).EndInit();
            splitContainer_Main.ResumeLayout(false);
            groupBox_Msgs.ResumeLayout(false);
            tlp_ListAndSearch.ResumeLayout(false);
            tlp_ListAndSearch.PerformLayout();
            panel_Editor.ResumeLayout(false);
            tabControl_EditorType.ResumeLayout(false);
            tabPage_Message.ResumeLayout(false);
            tlp_Editor.ResumeLayout(false);
            tlp_Editor.PerformLayout();
            tabPage_Flowscript.ResumeLayout(false);
            panel_FlowScript.ResumeLayout(false);
            tlp_Flowscript.ResumeLayout(false);
            tlp_Flowscript.PerformLayout();
            splitContainer_Log.Panel1.ResumeLayout(false);
            splitContainer_Log.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_Log).EndInit();
            splitContainer_Log.ResumeLayout(false);
            splitContainer_Directories.Panel1.ResumeLayout(false);
            splitContainer_Directories.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_Directories).EndInit();
            splitContainer_Directories.ResumeLayout(false);
            groupBox_Directories.ResumeLayout(false);
            tlp_DirsAndSearch.ResumeLayout(false);
            splitContainer_Files.Panel1.ResumeLayout(false);
            splitContainer_Files.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_Files).EndInit();
            splitContainer_Files.ResumeLayout(false);
            groupBox_Files.ResumeLayout(false);
            tlp_FilesAndSearch.ResumeLayout(false);
            tlp_Progress.ResumeLayout(false);
            menuStrip_Main.ResumeLayout(false);
            menuStrip_Main.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ColumnHeader columnHeader;
        private SplitContainer splitContainer_Main;
        private Panel panel_Editor;
        private SplitContainer splitContainer_Log;
        private SplitContainer splitContainer_Directories;
        private SplitContainer splitContainer_Files;
        private TableLayoutPanel tlp_FilesAndSearch;
        private MetroSetCheckBox chk_IncludeFilesInSearch;
        private ListBox listBox_Files;
        private GroupBox groupBox_Files;
        private GroupBox groupBox_Directories;
        private TableLayoutPanel tlp_DirsAndSearch;
        private ListBox listBox_Directories;
        private MetroSetCheckBox chk_IncludeDirsInSearch;
        private GroupBox groupBox_Msgs;
        private TableLayoutPanel tlp_ListAndSearch;
        private TextBox txt_Search;
        private ListBox listBox_Msgs;
        private TableLayoutPanel tlp_Progress;
        private RichTextBox rtb_Log;
        private ProgressBar progressBar1;
        private MetroSetTabControl tabControl_EditorType;
        private TabPage tabPage_Message;
        private TableLayoutPanel tlp_Editor;
        private Label lbl_MsgName;
        private TextBox txt_MsgName;
        private MetroSetCheckBox chk_ShowOldMsgText;
        private Label lbl_MsgTxt;
        private TextBox txt_MsgTxt;
        private Label lbl_MsgType;
        private Label lbl_Speaker;
        private TextBox txt_Speaker;
        private ComboBox comboBox_MsgType;
        private TabPage tabPage_Flowscript;
        private Panel panel_FlowScript;
        private TableLayoutPanel tlp_Flowscript;
        private TextBox txt_Flowscript;
        private Button btn_ExportScript;
        private MenuStrip menuStrip_Main;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem importToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem exportTXTsToolStripMenuItem;
        private ToolStripMenuItem createJSONDumpToolStripMenuItem;
        private ToolStripMenuItem setInputPathToolStripMenuItem;
        private ToolStripMenuItem setOutputPathToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem outputBMDToolStripMenuItem;
        private ToolStripMenuItem deleteOutputMSGToolStripMenuItem;
        private ToolStripMenuItem deleteExistingDumpDirToolStripMenuItem;
        private ToolStripMenuItem deleteExistingOutputDirToolStripMenuItem;
        private ToolStripMenuItem showAutoReplacedFilesToolStripMenuItem;
        private ToolStripMenuItem exportAutoReplacedFilesToolStripMenuItem;
        private ToolStripMenuItem showDecompiledFLOWToolStripMenuItem;
        private ToolStripComboBox comboBox_Encoding;
        private ToolStripMenuItem toggleThemeToolStripMenuItem;
        private ToolStripMenuItem autoReplaceToolStripMenuItem;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private ToolStripMenuItem exportOnlyEditedMessagesToolStripMenuItem;
        private ToolStripMenuItem setFEmulatorOutputPathToolStripMenuItem;
        private MetroSetCheckBox chk_UseMessageName;
        private ToolStripMenuItem setAtlusScriptCompilerPathToolStripMenuItem;
        private ToolStripMenuItem copyLinesInVoicePackOrderToolStripMenuItem;
    }
}