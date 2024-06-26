﻿using MetroSet_UI.Controls;
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
            this.splitContainer_Main = new System.Windows.Forms.SplitContainer();
            this.groupBox_Msgs = new System.Windows.Forms.GroupBox();
            this.tlp_ListAndSearch = new System.Windows.Forms.TableLayoutPanel();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.listBox_Msgs = new System.Windows.Forms.ListBox();
            this.panel_Editor = new System.Windows.Forms.Panel();
            this.tabControl_EditorType = new MetroSet_UI.Controls.MetroSetTabControl();
            this.tabPage_Message = new System.Windows.Forms.TabPage();
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
            this.tabPage_Flowscript = new System.Windows.Forms.TabPage();
            this.panel_FlowScript = new System.Windows.Forms.Panel();
            this.tlp_Flowscript = new System.Windows.Forms.TableLayoutPanel();
            this.chk_UseMessageName = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.txt_Flowscript = new System.Windows.Forms.TextBox();
            this.btn_ExportScript = new System.Windows.Forms.Button();
            this.splitContainer_Log = new System.Windows.Forms.SplitContainer();
            this.splitContainer_Directories = new System.Windows.Forms.SplitContainer();
            this.groupBox_Directories = new System.Windows.Forms.GroupBox();
            this.tlp_DirsAndSearch = new System.Windows.Forms.TableLayoutPanel();
            this.listBox_Directories = new System.Windows.Forms.ListBox();
            this.chk_IncludeDirsInSearch = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.splitContainer_Files = new System.Windows.Forms.SplitContainer();
            this.groupBox_Files = new System.Windows.Forms.GroupBox();
            this.tlp_FilesAndSearch = new System.Windows.Forms.TableLayoutPanel();
            this.chk_IncludeFilesInSearch = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.listBox_Files = new System.Windows.Forms.ListBox();
            this.tlp_Progress = new System.Windows.Forms.TableLayoutPanel();
            this.rtb_Log = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportTXTsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createJSONDumpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setInputPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setOutputPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setFEmulatorOutputPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputBMDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteOutputMSGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteExistingDumpDirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteExistingOutputDirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAutoReplacedFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAutoReplacedFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportOnlyEditedMessagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDecompiledFLOWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox_Encoding = new System.Windows.Forms.ToolStripComboBox();
            this.toggleThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoReplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Main)).BeginInit();
            this.splitContainer_Main.Panel1.SuspendLayout();
            this.splitContainer_Main.Panel2.SuspendLayout();
            this.splitContainer_Main.SuspendLayout();
            this.groupBox_Msgs.SuspendLayout();
            this.tlp_ListAndSearch.SuspendLayout();
            this.panel_Editor.SuspendLayout();
            this.tabControl_EditorType.SuspendLayout();
            this.tabPage_Message.SuspendLayout();
            this.tlp_Editor.SuspendLayout();
            this.tabPage_Flowscript.SuspendLayout();
            this.panel_FlowScript.SuspendLayout();
            this.tlp_Flowscript.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Log)).BeginInit();
            this.splitContainer_Log.Panel1.SuspendLayout();
            this.splitContainer_Log.Panel2.SuspendLayout();
            this.splitContainer_Log.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Directories)).BeginInit();
            this.splitContainer_Directories.Panel1.SuspendLayout();
            this.splitContainer_Directories.Panel2.SuspendLayout();
            this.splitContainer_Directories.SuspendLayout();
            this.groupBox_Directories.SuspendLayout();
            this.tlp_DirsAndSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Files)).BeginInit();
            this.splitContainer_Files.Panel1.SuspendLayout();
            this.splitContainer_Files.Panel2.SuspendLayout();
            this.splitContainer_Files.SuspendLayout();
            this.groupBox_Files.SuspendLayout();
            this.tlp_FilesAndSearch.SuspendLayout();
            this.tlp_Progress.SuspendLayout();
            this.menuStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader
            // 
            this.columnHeader.Width = 100;
            // 
            // splitContainer_Main
            // 
            this.splitContainer_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Main.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Main.Name = "splitContainer_Main";
            // 
            // splitContainer_Main.Panel1
            // 
            this.splitContainer_Main.Panel1.Controls.Add(this.groupBox_Msgs);
            // 
            // splitContainer_Main.Panel2
            // 
            this.splitContainer_Main.Panel2.Controls.Add(this.panel_Editor);
            this.splitContainer_Main.Size = new System.Drawing.Size(557, 456);
            this.splitContainer_Main.SplitterDistance = 160;
            this.splitContainer_Main.TabIndex = 3;
            // 
            // groupBox_Msgs
            // 
            this.groupBox_Msgs.Controls.Add(this.tlp_ListAndSearch);
            this.groupBox_Msgs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Msgs.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Msgs.Name = "groupBox_Msgs";
            this.groupBox_Msgs.Size = new System.Drawing.Size(160, 456);
            this.groupBox_Msgs.TabIndex = 0;
            this.groupBox_Msgs.TabStop = false;
            this.groupBox_Msgs.Text = "Messages";
            // 
            // tlp_ListAndSearch
            // 
            this.tlp_ListAndSearch.ColumnCount = 1;
            this.tlp_ListAndSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_ListAndSearch.Controls.Add(this.txt_Search, 0, 0);
            this.tlp_ListAndSearch.Controls.Add(this.listBox_Msgs, 0, 1);
            this.tlp_ListAndSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_ListAndSearch.Location = new System.Drawing.Point(3, 22);
            this.tlp_ListAndSearch.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_ListAndSearch.Name = "tlp_ListAndSearch";
            this.tlp_ListAndSearch.RowCount = 2;
            this.tlp_ListAndSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlp_ListAndSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tlp_ListAndSearch.Size = new System.Drawing.Size(154, 431);
            this.tlp_ListAndSearch.TabIndex = 2;
            // 
            // txt_Search
            // 
            this.txt_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Search.Location = new System.Drawing.Point(3, 4);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(148, 26);
            this.txt_Search.TabIndex = 5;
            this.txt_Search.Text = "Search...";
            this.txt_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_KeyDown);
            // 
            // listBox_Msgs
            // 
            this.listBox_Msgs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_Msgs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Msgs.ItemHeight = 20;
            this.listBox_Msgs.Location = new System.Drawing.Point(3, 37);
            this.listBox_Msgs.Name = "listBox_Msgs";
            this.listBox_Msgs.Size = new System.Drawing.Size(148, 391);
            this.listBox_Msgs.TabIndex = 0;
            this.listBox_Msgs.SelectedIndexChanged += new System.EventHandler(this.ListBox_Msgs_SelectedIndexChanged);
            this.listBox_Msgs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListBox_KeyDown);
            // 
            // panel_Editor
            // 
            this.panel_Editor.AutoSize = true;
            this.panel_Editor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_Editor.Controls.Add(this.tabControl_EditorType);
            this.panel_Editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Editor.Location = new System.Drawing.Point(0, 0);
            this.panel_Editor.Name = "panel_Editor";
            this.panel_Editor.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panel_Editor.Size = new System.Drawing.Size(393, 456);
            this.panel_Editor.TabIndex = 0;
            // 
            // tabControl_EditorType
            // 
            this.tabControl_EditorType.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.tabControl_EditorType.AnimateTime = 200;
            this.tabControl_EditorType.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabControl_EditorType.Controls.Add(this.tabPage_Message);
            this.tabControl_EditorType.Controls.Add(this.tabPage_Flowscript);
            this.tabControl_EditorType.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl_EditorType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_EditorType.IsDerivedStyle = true;
            this.tabControl_EditorType.ItemSize = new System.Drawing.Size(100, 38);
            this.tabControl_EditorType.Location = new System.Drawing.Point(0, 30);
            this.tabControl_EditorType.Name = "tabControl_EditorType";
            this.tabControl_EditorType.SelectedIndex = 1;
            this.tabControl_EditorType.SelectedTextColor = System.Drawing.Color.White;
            this.tabControl_EditorType.Size = new System.Drawing.Size(393, 426);
            this.tabControl_EditorType.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_EditorType.Speed = 100;
            this.tabControl_EditorType.Style = MetroSet_UI.Enums.Style.Dark;
            this.tabControl_EditorType.StyleManager = null;
            this.tabControl_EditorType.TabIndex = 0;
            this.tabControl_EditorType.ThemeAuthor = "Narwin";
            this.tabControl_EditorType.ThemeName = "MetroDark";
            this.tabControl_EditorType.UnselectedTextColor = System.Drawing.Color.Gray;
            this.tabControl_EditorType.UseAnimation = false;
            // 
            // tabPage_Message
            // 
            this.tabPage_Message.AutoScroll = true;
            this.tabPage_Message.Controls.Add(this.tlp_Editor);
            this.tabPage_Message.Location = new System.Drawing.Point(4, 42);
            this.tabPage_Message.Name = "tabPage_Message";
            this.tabPage_Message.Size = new System.Drawing.Size(385, 380);
            this.tabPage_Message.TabIndex = 0;
            this.tabPage_Message.Text = "Message";
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
            this.tlp_Editor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tlp_Editor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_Editor.Size = new System.Drawing.Size(364, 464);
            this.tlp_Editor.TabIndex = 1;
            // 
            // lbl_MsgName
            // 
            this.lbl_MsgName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_MsgName.AutoSize = true;
            this.lbl_MsgName.Location = new System.Drawing.Point(35, 0);
            this.lbl_MsgName.Name = "lbl_MsgName";
            this.lbl_MsgName.Size = new System.Drawing.Size(58, 40);
            this.lbl_MsgName.TabIndex = 2;
            this.lbl_MsgName.Text = "Msg Name:";
            this.lbl_MsgName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_MsgName
            // 
            this.txt_MsgName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_MsgName.Enabled = false;
            this.txt_MsgName.Location = new System.Drawing.Point(99, 7);
            this.txt_MsgName.Name = "txt_MsgName";
            this.txt_MsgName.ReadOnly = true;
            this.txt_MsgName.Size = new System.Drawing.Size(283, 26);
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
            this.chk_ShowOldMsgText.Location = new System.Drawing.Point(99, 343);
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
            this.lbl_MsgTxt.Location = new System.Drawing.Point(10, 120);
            this.lbl_MsgTxt.Name = "lbl_MsgTxt";
            this.lbl_MsgTxt.Size = new System.Drawing.Size(83, 20);
            this.lbl_MsgTxt.TabIndex = 5;
            this.lbl_MsgTxt.Text = "Msg Text:";
            this.lbl_MsgTxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_MsgTxt
            // 
            this.txt_MsgTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_MsgTxt.Location = new System.Drawing.Point(99, 123);
            this.txt_MsgTxt.Multiline = true;
            this.txt_MsgTxt.Name = "txt_MsgTxt";
            this.txt_MsgTxt.Size = new System.Drawing.Size(283, 214);
            this.txt_MsgTxt.TabIndex = 9;
            this.txt_MsgTxt.TextChanged += new System.EventHandler(this.Desc_Changed);
            // 
            // lbl_MsgType
            // 
            this.lbl_MsgType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_MsgType.AutoSize = true;
            this.lbl_MsgType.Location = new System.Drawing.Point(43, 50);
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
            this.lbl_Speaker.Location = new System.Drawing.Point(18, 90);
            this.lbl_Speaker.Name = "lbl_Speaker";
            this.lbl_Speaker.Size = new System.Drawing.Size(75, 20);
            this.lbl_Speaker.TabIndex = 12;
            this.lbl_Speaker.Text = "Speaker:";
            this.lbl_Speaker.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_Speaker
            // 
            this.txt_Speaker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Speaker.Location = new System.Drawing.Point(99, 87);
            this.txt_Speaker.Name = "txt_Speaker";
            this.txt_Speaker.Size = new System.Drawing.Size(283, 26);
            this.txt_Speaker.TabIndex = 13;
            this.txt_Speaker.TextChanged += new System.EventHandler(this.Desc_Changed);
            // 
            // comboBox_MsgType
            // 
            this.comboBox_MsgType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_MsgType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_MsgType.Enabled = false;
            this.comboBox_MsgType.FormattingEnabled = true;
            this.comboBox_MsgType.Items.AddRange(new object[] {
            "Dialog",
            "Selection"});
            this.comboBox_MsgType.Location = new System.Drawing.Point(99, 46);
            this.comboBox_MsgType.Name = "comboBox_MsgType";
            this.comboBox_MsgType.Size = new System.Drawing.Size(283, 28);
            this.comboBox_MsgType.TabIndex = 14;
            // 
            // tabPage_Flowscript
            // 
            this.tabPage_Flowscript.AutoScroll = true;
            this.tabPage_Flowscript.Controls.Add(this.panel_FlowScript);
            this.tabPage_Flowscript.Location = new System.Drawing.Point(4, 42);
            this.tabPage_Flowscript.Name = "tabPage_Flowscript";
            this.tabPage_Flowscript.Size = new System.Drawing.Size(385, 380);
            this.tabPage_Flowscript.TabIndex = 1;
            this.tabPage_Flowscript.Text = "Script";
            // 
            // panel_FlowScript
            // 
            this.panel_FlowScript.AutoScroll = true;
            this.panel_FlowScript.Controls.Add(this.tlp_Flowscript);
            this.panel_FlowScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_FlowScript.Location = new System.Drawing.Point(0, 0);
            this.panel_FlowScript.Name = "panel_FlowScript";
            this.panel_FlowScript.Size = new System.Drawing.Size(385, 380);
            this.panel_FlowScript.TabIndex = 0;
            // 
            // tlp_Flowscript
            // 
            this.tlp_Flowscript.ColumnCount = 2;
            this.tlp_Flowscript.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Flowscript.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Flowscript.Controls.Add(this.chk_UseMessageName, 0, 1);
            this.tlp_Flowscript.Controls.Add(this.txt_Flowscript, 0, 0);
            this.tlp_Flowscript.Controls.Add(this.btn_ExportScript, 1, 1);
            this.tlp_Flowscript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Flowscript.Location = new System.Drawing.Point(0, 0);
            this.tlp_Flowscript.Name = "tlp_Flowscript";
            this.tlp_Flowscript.RowCount = 2;
            this.tlp_Flowscript.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Flowscript.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlp_Flowscript.Size = new System.Drawing.Size(385, 380);
            this.tlp_Flowscript.TabIndex = 0;
            // 
            // chk_UseMessageName
            // 
            this.chk_UseMessageName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_UseMessageName.BackColor = System.Drawing.Color.Transparent;
            this.chk_UseMessageName.BackgroundColor = System.Drawing.Color.White;
            this.chk_UseMessageName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.chk_UseMessageName.Checked = true;
            this.chk_UseMessageName.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.chk_UseMessageName.CheckState = MetroSet_UI.Enums.CheckState.Checked;
            this.chk_UseMessageName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_UseMessageName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.chk_UseMessageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chk_UseMessageName.IsDerivedStyle = true;
            this.chk_UseMessageName.Location = new System.Drawing.Point(3, 352);
            this.chk_UseMessageName.Name = "chk_UseMessageName";
            this.chk_UseMessageName.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            this.chk_UseMessageName.Size = new System.Drawing.Size(186, 16);
            this.chk_UseMessageName.Style = MetroSet_UI.Enums.Style.Light;
            this.chk_UseMessageName.StyleManager = null;
            this.chk_UseMessageName.TabIndex = 12;
            this.chk_UseMessageName.Text = "Use Message Names";
            this.chk_UseMessageName.ThemeAuthor = "Narwin";
            this.chk_UseMessageName.ThemeName = "MetroLite";
            // 
            // txt_Flowscript
            // 
            this.tlp_Flowscript.SetColumnSpan(this.txt_Flowscript, 2);
            this.txt_Flowscript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Flowscript.Enabled = false;
            this.txt_Flowscript.Location = new System.Drawing.Point(3, 3);
            this.txt_Flowscript.Multiline = true;
            this.txt_Flowscript.Name = "txt_Flowscript";
            this.txt_Flowscript.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Flowscript.Size = new System.Drawing.Size(379, 334);
            this.txt_Flowscript.TabIndex = 11;
            // 
            // btn_ExportScript
            // 
            this.btn_ExportScript.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_ExportScript.Enabled = false;
            this.btn_ExportScript.Location = new System.Drawing.Point(207, 343);
            this.btn_ExportScript.Name = "btn_ExportScript";
            this.btn_ExportScript.Size = new System.Drawing.Size(175, 34);
            this.btn_ExportScript.TabIndex = 0;
            this.btn_ExportScript.Text = "Export Script";
            this.btn_ExportScript.UseVisualStyleBackColor = true;
            this.btn_ExportScript.Click += new System.EventHandler(this.ExportScript_Click);
            // 
            // splitContainer_Log
            // 
            this.splitContainer_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Log.Location = new System.Drawing.Point(2, 0);
            this.splitContainer_Log.Name = "splitContainer_Log";
            this.splitContainer_Log.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_Log.Panel1
            // 
            this.splitContainer_Log.Panel1.Controls.Add(this.splitContainer_Directories);
            // 
            // splitContainer_Log.Panel2
            // 
            this.splitContainer_Log.Panel2.Controls.Add(this.tlp_Progress);
            this.splitContainer_Log.Size = new System.Drawing.Size(1264, 562);
            this.splitContainer_Log.SplitterDistance = 456;
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
            this.splitContainer_Directories.Panel1.Controls.Add(this.groupBox_Directories);
            // 
            // splitContainer_Directories.Panel2
            // 
            this.splitContainer_Directories.Panel2.Controls.Add(this.splitContainer_Files);
            this.splitContainer_Directories.Size = new System.Drawing.Size(1264, 456);
            this.splitContainer_Directories.SplitterDistance = 444;
            this.splitContainer_Directories.TabIndex = 0;
            // 
            // groupBox_Directories
            // 
            this.groupBox_Directories.Controls.Add(this.tlp_DirsAndSearch);
            this.groupBox_Directories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Directories.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Directories.Name = "groupBox_Directories";
            this.groupBox_Directories.Size = new System.Drawing.Size(444, 456);
            this.groupBox_Directories.TabIndex = 0;
            this.groupBox_Directories.TabStop = false;
            this.groupBox_Directories.Text = "Directories";
            // 
            // tlp_DirsAndSearch
            // 
            this.tlp_DirsAndSearch.ColumnCount = 1;
            this.tlp_DirsAndSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_DirsAndSearch.Controls.Add(this.listBox_Directories, 0, 1);
            this.tlp_DirsAndSearch.Controls.Add(this.chk_IncludeDirsInSearch, 0, 0);
            this.tlp_DirsAndSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_DirsAndSearch.Location = new System.Drawing.Point(3, 22);
            this.tlp_DirsAndSearch.Name = "tlp_DirsAndSearch";
            this.tlp_DirsAndSearch.RowCount = 2;
            this.tlp_DirsAndSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlp_DirsAndSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tlp_DirsAndSearch.Size = new System.Drawing.Size(438, 431);
            this.tlp_DirsAndSearch.TabIndex = 0;
            // 
            // listBox_Directories
            // 
            this.listBox_Directories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_Directories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Directories.ItemHeight = 20;
            this.listBox_Directories.Location = new System.Drawing.Point(3, 37);
            this.listBox_Directories.Name = "listBox_Directories";
            this.listBox_Directories.Size = new System.Drawing.Size(432, 391);
            this.listBox_Directories.TabIndex = 4;
            this.listBox_Directories.SelectedIndexChanged += new System.EventHandler(this.ListBox_Dirs_SelectedIndexChanged);
            this.listBox_Directories.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListBox_KeyDown);
            // 
            // chk_IncludeDirsInSearch
            // 
            this.chk_IncludeDirsInSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chk_IncludeDirsInSearch.BackColor = System.Drawing.Color.Transparent;
            this.chk_IncludeDirsInSearch.BackgroundColor = System.Drawing.Color.White;
            this.chk_IncludeDirsInSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.chk_IncludeDirsInSearch.Checked = true;
            this.chk_IncludeDirsInSearch.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.chk_IncludeDirsInSearch.CheckState = MetroSet_UI.Enums.CheckState.Checked;
            this.chk_IncludeDirsInSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_IncludeDirsInSearch.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.chk_IncludeDirsInSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chk_IncludeDirsInSearch.IsDerivedStyle = true;
            this.chk_IncludeDirsInSearch.Location = new System.Drawing.Point(3, 9);
            this.chk_IncludeDirsInSearch.Name = "chk_IncludeDirsInSearch";
            this.chk_IncludeDirsInSearch.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            this.chk_IncludeDirsInSearch.Size = new System.Drawing.Size(266, 16);
            this.chk_IncludeDirsInSearch.Style = MetroSet_UI.Enums.Style.Light;
            this.chk_IncludeDirsInSearch.StyleManager = null;
            this.chk_IncludeDirsInSearch.TabIndex = 12;
            this.chk_IncludeDirsInSearch.Text = "Include All Directories in Search";
            this.chk_IncludeDirsInSearch.ThemeAuthor = "Narwin";
            this.chk_IncludeDirsInSearch.ThemeName = "MetroLite";
            // 
            // splitContainer_Files
            // 
            this.splitContainer_Files.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Files.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Files.Name = "splitContainer_Files";
            // 
            // splitContainer_Files.Panel1
            // 
            this.splitContainer_Files.Panel1.Controls.Add(this.groupBox_Files);
            // 
            // splitContainer_Files.Panel2
            // 
            this.splitContainer_Files.Panel2.Controls.Add(this.splitContainer_Main);
            this.splitContainer_Files.Size = new System.Drawing.Size(816, 456);
            this.splitContainer_Files.SplitterDistance = 255;
            this.splitContainer_Files.TabIndex = 5;
            // 
            // groupBox_Files
            // 
            this.groupBox_Files.Controls.Add(this.tlp_FilesAndSearch);
            this.groupBox_Files.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Files.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Files.Name = "groupBox_Files";
            this.groupBox_Files.Size = new System.Drawing.Size(255, 456);
            this.groupBox_Files.TabIndex = 1;
            this.groupBox_Files.TabStop = false;
            this.groupBox_Files.Text = "Files";
            // 
            // tlp_FilesAndSearch
            // 
            this.tlp_FilesAndSearch.ColumnCount = 1;
            this.tlp_FilesAndSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_FilesAndSearch.Controls.Add(this.chk_IncludeFilesInSearch, 0, 0);
            this.tlp_FilesAndSearch.Controls.Add(this.listBox_Files, 0, 1);
            this.tlp_FilesAndSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_FilesAndSearch.Location = new System.Drawing.Point(3, 22);
            this.tlp_FilesAndSearch.Name = "tlp_FilesAndSearch";
            this.tlp_FilesAndSearch.RowCount = 2;
            this.tlp_FilesAndSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlp_FilesAndSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tlp_FilesAndSearch.Size = new System.Drawing.Size(249, 431);
            this.tlp_FilesAndSearch.TabIndex = 0;
            // 
            // chk_IncludeFilesInSearch
            // 
            this.chk_IncludeFilesInSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chk_IncludeFilesInSearch.BackColor = System.Drawing.Color.Transparent;
            this.chk_IncludeFilesInSearch.BackgroundColor = System.Drawing.Color.White;
            this.chk_IncludeFilesInSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.chk_IncludeFilesInSearch.Checked = true;
            this.chk_IncludeFilesInSearch.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.chk_IncludeFilesInSearch.CheckState = MetroSet_UI.Enums.CheckState.Checked;
            this.chk_IncludeFilesInSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_IncludeFilesInSearch.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.chk_IncludeFilesInSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chk_IncludeFilesInSearch.IsDerivedStyle = true;
            this.chk_IncludeFilesInSearch.Location = new System.Drawing.Point(3, 9);
            this.chk_IncludeFilesInSearch.Name = "chk_IncludeFilesInSearch";
            this.chk_IncludeFilesInSearch.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            this.chk_IncludeFilesInSearch.Size = new System.Drawing.Size(223, 16);
            this.chk_IncludeFilesInSearch.Style = MetroSet_UI.Enums.Style.Light;
            this.chk_IncludeFilesInSearch.StyleManager = null;
            this.chk_IncludeFilesInSearch.TabIndex = 11;
            this.chk_IncludeFilesInSearch.Text = "Include All Files in Search";
            this.chk_IncludeFilesInSearch.ThemeAuthor = "Narwin";
            this.chk_IncludeFilesInSearch.ThemeName = "MetroLite";
            // 
            // listBox_Files
            // 
            this.listBox_Files.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_Files.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Files.ItemHeight = 20;
            this.listBox_Files.Location = new System.Drawing.Point(3, 37);
            this.listBox_Files.Name = "listBox_Files";
            this.listBox_Files.Size = new System.Drawing.Size(243, 391);
            this.listBox_Files.TabIndex = 2;
            this.listBox_Files.SelectedIndexChanged += new System.EventHandler(this.ListBox_Files_SelectedIndexChanged);
            this.listBox_Files.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListBox_KeyDown);
            // 
            // tlp_Progress
            // 
            this.tlp_Progress.ColumnCount = 1;
            this.tlp_Progress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Progress.Controls.Add(this.rtb_Log, 0, 1);
            this.tlp_Progress.Controls.Add(this.progressBar1, 0, 0);
            this.tlp_Progress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Progress.Location = new System.Drawing.Point(0, 0);
            this.tlp_Progress.Name = "tlp_Progress";
            this.tlp_Progress.RowCount = 2;
            this.tlp_Progress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlp_Progress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tlp_Progress.Size = new System.Drawing.Size(1264, 102);
            this.tlp_Progress.TabIndex = 0;
            // 
            // rtb_Log
            // 
            this.rtb_Log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Log.Location = new System.Drawing.Point(3, 18);
            this.rtb_Log.Name = "rtb_Log";
            this.rtb_Log.ReadOnly = true;
            this.rtb_Log.Size = new System.Drawing.Size(1258, 75);
            this.rtb_Log.TabIndex = 1;
            this.rtb_Log.Text = "";
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(3, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1258, 9);
            this.progressBar1.TabIndex = 2;
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.toggleThemeToolStripMenuItem,
            this.autoReplaceToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(2, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.menuStrip_Main.Size = new System.Drawing.Size(1264, 28);
            this.menuStrip_Main.TabIndex = 5;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.exportTXTsToolStripMenuItem,
            this.createJSONDumpToolStripMenuItem,
            this.setInputPathToolStripMenuItem,
            this.setOutputPathToolStripMenuItem,
            this.setFEmulatorOutputPathToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.saveToolStripMenuItem.Text = "Save Project";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveProject_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.loadToolStripMenuItem.Text = "Load Project";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.Load_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.importToolStripMenuItem.Text = "Import .BMDs";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.ImportBMDs_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.exportToolStripMenuItem.Text = "Export .BMDs";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.ExportBMDs_Click);
            // 
            // exportTXTsToolStripMenuItem
            // 
            this.exportTXTsToolStripMenuItem.Name = "exportTXTsToolStripMenuItem";
            this.exportTXTsToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.exportTXTsToolStripMenuItem.Text = "Create .TXT Dump";
            this.exportTXTsToolStripMenuItem.Click += new System.EventHandler(this.ExportTXTs_Click);
            // 
            // createJSONDumpToolStripMenuItem
            // 
            this.createJSONDumpToolStripMenuItem.Name = "createJSONDumpToolStripMenuItem";
            this.createJSONDumpToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.createJSONDumpToolStripMenuItem.Text = "Create .JSON Dump";
            this.createJSONDumpToolStripMenuItem.Click += new System.EventHandler(this.JsonDump_Click);
            // 
            // setInputPathToolStripMenuItem
            // 
            this.setInputPathToolStripMenuItem.Name = "setInputPathToolStripMenuItem";
            this.setInputPathToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.setInputPathToolStripMenuItem.Text = "Set Input Path...";
            this.setInputPathToolStripMenuItem.Click += new System.EventHandler(this.SetInputPath_Click);
            // 
            // setOutputPathToolStripMenuItem
            // 
            this.setOutputPathToolStripMenuItem.Name = "setOutputPathToolStripMenuItem";
            this.setOutputPathToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.setOutputPathToolStripMenuItem.Text = "Set CPK Output Path...";
            this.setOutputPathToolStripMenuItem.Click += new System.EventHandler(this.SetCPKOutputPath_Click);
            // 
            // setFEmulatorOutputPathToolStripMenuItem
            // 
            this.setFEmulatorOutputPathToolStripMenuItem.Name = "setFEmulatorOutputPathToolStripMenuItem";
            this.setFEmulatorOutputPathToolStripMenuItem.Size = new System.Drawing.Size(275, 26);
            this.setFEmulatorOutputPathToolStripMenuItem.Text = "Set FEmulator Output Path...";
            this.setFEmulatorOutputPathToolStripMenuItem.Click += new System.EventHandler(this.SetFEmuOutputPath_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outputBMDToolStripMenuItem,
            this.deleteOutputMSGToolStripMenuItem,
            this.deleteExistingDumpDirToolStripMenuItem,
            this.deleteExistingOutputDirToolStripMenuItem,
            this.showAutoReplacedFilesToolStripMenuItem,
            this.exportAutoReplacedFilesToolStripMenuItem,
            this.exportOnlyEditedMessagesToolStripMenuItem,
            this.showDecompiledFLOWToolStripMenuItem,
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
            this.outputBMDToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.outputBMDToolStripMenuItem.Text = "Output BF/BMD";
            this.outputBMDToolStripMenuItem.CheckedChanged += new System.EventHandler(this.MenuStrip_CheckedChanged);
            // 
            // deleteOutputMSGToolStripMenuItem
            // 
            this.deleteOutputMSGToolStripMenuItem.CheckOnClick = true;
            this.deleteOutputMSGToolStripMenuItem.Name = "deleteOutputMSGToolStripMenuItem";
            this.deleteOutputMSGToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.deleteOutputMSGToolStripMenuItem.Text = "Delete Output MSG";
            this.deleteOutputMSGToolStripMenuItem.CheckedChanged += new System.EventHandler(this.MenuStrip_CheckedChanged);
            // 
            // deleteExistingDumpDirToolStripMenuItem
            // 
            this.deleteExistingDumpDirToolStripMenuItem.Checked = true;
            this.deleteExistingDumpDirToolStripMenuItem.CheckOnClick = true;
            this.deleteExistingDumpDirToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.deleteExistingDumpDirToolStripMenuItem.Name = "deleteExistingDumpDirToolStripMenuItem";
            this.deleteExistingDumpDirToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.deleteExistingDumpDirToolStripMenuItem.Text = "Delete Existing Dump Dir";
            this.deleteExistingDumpDirToolStripMenuItem.CheckedChanged += new System.EventHandler(this.MenuStrip_CheckedChanged);
            // 
            // deleteExistingOutputDirToolStripMenuItem
            // 
            this.deleteExistingOutputDirToolStripMenuItem.Checked = true;
            this.deleteExistingOutputDirToolStripMenuItem.CheckOnClick = true;
            this.deleteExistingOutputDirToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.deleteExistingOutputDirToolStripMenuItem.Name = "deleteExistingOutputDirToolStripMenuItem";
            this.deleteExistingOutputDirToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.deleteExistingOutputDirToolStripMenuItem.Text = "Delete Existing Output Dir";
            this.deleteExistingOutputDirToolStripMenuItem.CheckedChanged += new System.EventHandler(this.MenuStrip_CheckedChanged);
            // 
            // showAutoReplacedFilesToolStripMenuItem
            // 
            this.showAutoReplacedFilesToolStripMenuItem.CheckOnClick = true;
            this.showAutoReplacedFilesToolStripMenuItem.Name = "showAutoReplacedFilesToolStripMenuItem";
            this.showAutoReplacedFilesToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.showAutoReplacedFilesToolStripMenuItem.Text = "Show Auto-Replaced Files";
            this.showAutoReplacedFilesToolStripMenuItem.CheckedChanged += new System.EventHandler(this.MenuStrip_CheckedChanged);
            // 
            // exportAutoReplacedFilesToolStripMenuItem
            // 
            this.exportAutoReplacedFilesToolStripMenuItem.CheckOnClick = true;
            this.exportAutoReplacedFilesToolStripMenuItem.Name = "exportAutoReplacedFilesToolStripMenuItem";
            this.exportAutoReplacedFilesToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.exportAutoReplacedFilesToolStripMenuItem.Text = "Export Auto-Replaced Files";
            this.exportAutoReplacedFilesToolStripMenuItem.CheckedChanged += new System.EventHandler(this.MenuStrip_CheckedChanged);
            // 
            // exportOnlyEditedMessagesToolStripMenuItem
            // 
            this.exportOnlyEditedMessagesToolStripMenuItem.CheckOnClick = true;
            this.exportOnlyEditedMessagesToolStripMenuItem.Name = "exportOnlyEditedMessagesToolStripMenuItem";
            this.exportOnlyEditedMessagesToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.exportOnlyEditedMessagesToolStripMenuItem.Text = "Export Only Edited Messages";
            // 
            // showDecompiledFLOWToolStripMenuItem
            // 
            this.showDecompiledFLOWToolStripMenuItem.CheckOnClick = true;
            this.showDecompiledFLOWToolStripMenuItem.Name = "showDecompiledFLOWToolStripMenuItem";
            this.showDecompiledFLOWToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.showDecompiledFLOWToolStripMenuItem.Text = "Show Decompiled .FLOW";
            this.showDecompiledFLOWToolStripMenuItem.CheckedChanged += new System.EventHandler(this.MenuStrip_CheckedChanged);
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
            // autoReplaceToolStripMenuItem
            // 
            this.autoReplaceToolStripMenuItem.Name = "autoReplaceToolStripMenuItem";
            this.autoReplaceToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.autoReplaceToolStripMenuItem.Text = "Auto-Replace...";
            this.autoReplaceToolStripMenuItem.Click += new System.EventHandler(this.AutoReplace_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1268, 564);
            this.Controls.Add(this.menuStrip_Main);
            this.Controls.Add(this.splitContainer_Log);
            this.DropShadowEffect = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.HeaderHeight = -40;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.splitContainer_Main.Panel1.ResumeLayout(false);
            this.splitContainer_Main.Panel2.ResumeLayout(false);
            this.splitContainer_Main.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Main)).EndInit();
            this.splitContainer_Main.ResumeLayout(false);
            this.groupBox_Msgs.ResumeLayout(false);
            this.tlp_ListAndSearch.ResumeLayout(false);
            this.tlp_ListAndSearch.PerformLayout();
            this.panel_Editor.ResumeLayout(false);
            this.tabControl_EditorType.ResumeLayout(false);
            this.tabPage_Message.ResumeLayout(false);
            this.tlp_Editor.ResumeLayout(false);
            this.tlp_Editor.PerformLayout();
            this.tabPage_Flowscript.ResumeLayout(false);
            this.panel_FlowScript.ResumeLayout(false);
            this.tlp_Flowscript.ResumeLayout(false);
            this.tlp_Flowscript.PerformLayout();
            this.splitContainer_Log.Panel1.ResumeLayout(false);
            this.splitContainer_Log.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Log)).EndInit();
            this.splitContainer_Log.ResumeLayout(false);
            this.splitContainer_Directories.Panel1.ResumeLayout(false);
            this.splitContainer_Directories.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Directories)).EndInit();
            this.splitContainer_Directories.ResumeLayout(false);
            this.groupBox_Directories.ResumeLayout(false);
            this.tlp_DirsAndSearch.ResumeLayout(false);
            this.splitContainer_Files.Panel1.ResumeLayout(false);
            this.splitContainer_Files.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Files)).EndInit();
            this.splitContainer_Files.ResumeLayout(false);
            this.groupBox_Files.ResumeLayout(false);
            this.tlp_FilesAndSearch.ResumeLayout(false);
            this.tlp_Progress.ResumeLayout(false);
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}