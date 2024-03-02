using AtlusScriptLibrary.Common.Text.Encodings;
using MetroSet_UI.Enums;
using MetroSet_UI.Forms;
using Newtonsoft.Json;
using ShrineFox.IO;
using System.IO;
using System.Text;
using static AtlusMSGEditor.MainForm;

namespace AtlusMSGEditor
{
    public partial class MainForm : MetroSetForm
    {
        FormSettings formSettings = new FormSettings();
        bool saveFormChanges = false;

        public class FormSettings
        {
            public string UserEncoding { get; set; } = "P5R_EFIGS";
            public Style Theme { get; set; } = Style.Dark;
            public string DumpInputPath { get; set; } = "";
            public string DumpOutputPath { get; set; } = ".\\Dump";
            public string CPKExportPath { get; set; } = ".\\CPKOutput";
            public string FEmuExportPath { get; set; } = ".\\FEmuOutput";
            public string DefaultJSON { get; set; } = ".\\Dependencies\\msgDirs.json";
            public bool OutputBFandBMD { get; set; } = true;
            public bool DeleteOutputMSG { get; set; } = false;
            public bool DeleteExistingDumpDir { get; set; } = false;
            public bool DeleteExistingOutputDir { get; set; } = false;
            public bool ShowAutoReplacedFiles { get; set; } = false;
            public bool ExportAutoReplacedFiles { get; set; } = false;
            public bool ExportOnlyEditedMessages { get; set; } = true;
            public bool ShowDecompiledFLOW { get; set; } = false;
            public bool UseMessageNamesinFLOW { get; set; } = true;
            public bool AdvancedMode { get; set; } = false;
        }

        public void LoadFormSettings()
        {
            string formSettingsPath = ".\\FormSettings.json";
            if (File.Exists(formSettingsPath))
            {
                saveFormChanges = false;
                formSettings = JsonConvert.DeserializeObject<FormSettings>(File.ReadAllText(formSettingsPath));

                comboBox_Encoding.SelectedItem = formSettings.UserEncoding;
                this.Style = formSettings.Theme;
                outputBMDToolStripMenuItem.Checked = formSettings.OutputBFandBMD;
                deleteOutputMSGToolStripMenuItem.Checked = formSettings.DeleteOutputMSG;
                deleteExistingDumpDirToolStripMenuItem.Checked = formSettings.DeleteExistingDumpDir;
                deleteExistingOutputDirToolStripMenuItem.Checked = formSettings.DeleteExistingDumpDir;
                showAutoReplacedFilesToolStripMenuItem.Checked = formSettings.ShowAutoReplacedFiles;
                exportAutoReplacedFilesToolStripMenuItem.Checked = formSettings.ShowAutoReplacedFiles;
                exportOnlyEditedMessagesToolStripMenuItem.Checked = formSettings.ExportOnlyEditedMessages;
                showDecompiledFLOWToolStripMenuItem.Checked = formSettings.ShowDecompiledFLOW;
                chk_UseMessageName.Checked = formSettings.UseMessageNamesinFLOW;
                if (!formSettings.AdvancedMode)
                {
                    importToolStripMenuItem.Visible = false;
                    createJSONDumpToolStripMenuItem.Visible = false;
                    exportTXTsToolStripMenuItem.Visible = false;
                    deleteExistingDumpDirToolStripMenuItem.Visible = false;
                }
            }
        }

        public void SaveFormSettings()
        {
            if (!saveFormChanges)
                return;

            string formSettingsPath = ".\\FormSettings.json";

            if (comboBox_Encoding.SelectedItem != null)
                formSettings.UserEncoding = comboBox_Encoding.SelectedItem.ToString();
            formSettings.OutputBFandBMD = outputBMDToolStripMenuItem.Checked;
            formSettings.DeleteOutputMSG = deleteOutputMSGToolStripMenuItem.Checked;
            formSettings.DeleteExistingDumpDir = deleteExistingDumpDirToolStripMenuItem.Checked;
            formSettings.DeleteExistingDumpDir = deleteExistingOutputDirToolStripMenuItem.Checked;
            formSettings.ShowAutoReplacedFiles = showAutoReplacedFilesToolStripMenuItem.Checked;
            formSettings.ShowAutoReplacedFiles = exportAutoReplacedFilesToolStripMenuItem.Checked;
            formSettings.ExportOnlyEditedMessages = exportOnlyEditedMessagesToolStripMenuItem.Checked;
            formSettings.ShowDecompiledFLOW = showDecompiledFLOWToolStripMenuItem.Checked;
            formSettings.UseMessageNamesinFLOW = chk_UseMessageName.Checked;

            File.WriteAllText(formSettingsPath, JsonConvert.SerializeObject(formSettings, Formatting.Indented));
        }
    }
}