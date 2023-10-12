using System.Windows.Forms;

namespace AtlusMSGEditor
{
    partial class AutoReplaceForm : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoReplaceForm));
            this.tlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.dgv_Replacements = new System.Windows.Forms.DataGridView();
            this.tlp_Main.SuspendLayout();
            this.tlp_Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Replacements)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_Main
            // 
            this.tlp_Main.ColumnCount = 2;
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Main.Controls.Add(this.tlp_Buttons, 1, 1);
            this.tlp_Main.Controls.Add(this.dgv_Replacements, 0, 0);
            this.tlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Main.Location = new System.Drawing.Point(1, 43);
            this.tlp_Main.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlp_Main.Name = "tlp_Main";
            this.tlp_Main.RowCount = 2;
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.66666F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tlp_Main.Size = new System.Drawing.Size(490, 233);
            this.tlp_Main.TabIndex = 0;
            // 
            // tlp_Buttons
            // 
            this.tlp_Buttons.ColumnCount = 2;
            this.tlp_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Buttons.Controls.Add(this.btn_Cancel, 0, 0);
            this.tlp_Buttons.Controls.Add(this.btn_Save, 1, 0);
            this.tlp_Buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Buttons.Location = new System.Drawing.Point(247, 203);
            this.tlp_Buttons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlp_Buttons.Name = "tlp_Buttons";
            this.tlp_Buttons.RowCount = 1;
            this.tlp_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Buttons.Size = new System.Drawing.Size(241, 28);
            this.tlp_Buttons.TabIndex = 0;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Cancel.Location = new System.Drawing.Point(2, 2);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(116, 24);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Save.Location = new System.Drawing.Point(122, 2);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(117, 24);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // dgv_Replacements
            // 
            this.dgv_Replacements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Replacements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlp_Main.SetColumnSpan(this.dgv_Replacements, 2);
            this.dgv_Replacements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Replacements.Location = new System.Drawing.Point(2, 2);
            this.dgv_Replacements.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_Replacements.Name = "dgv_Replacements";
            this.dgv_Replacements.RowHeadersWidth = 51;
            this.dgv_Replacements.RowTemplate.Height = 24;
            this.dgv_Replacements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_Replacements.Size = new System.Drawing.Size(486, 197);
            this.dgv_Replacements.TabIndex = 1;
            // 
            // AutoReplaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 277);
            this.Controls.Add(this.tlp_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AutoReplaceForm";
            this.Padding = new System.Windows.Forms.Padding(1, 43, 1, 1);
            this.Text = "AtlusMSGEditor - Auto Replace";
            this.tlp_Main.ResumeLayout(false);
            this.tlp_Buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Replacements)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_Main;
        private System.Windows.Forms.TableLayoutPanel tlp_Buttons;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.DataGridView dgv_Replacements;
    }
}