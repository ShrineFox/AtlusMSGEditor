using ShrineFox.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using static AtlusMSGEditor.MainForm;

namespace AtlusMSGEditor
{
    public partial class AutoReplaceForm : Form
    {
        public List<Replacement> Replacements { get; set; } = new List<Replacement>();

        public AutoReplaceForm()
        {
            InitializeComponent();
            Replacements = MainForm.UserSettings.Replacements.Copy();

            var source = new BindingSource();
            source.DataSource = Replacements;

            dgv_Replacements.AutoGenerateColumns = true;
            dgv_Replacements.DataSource = source;
            dgv_Replacements.Columns[0].HeaderText = "Text to Replace";
            dgv_Replacements.Columns[1].HeaderText = "Replacement Text";
        }
    }
}
