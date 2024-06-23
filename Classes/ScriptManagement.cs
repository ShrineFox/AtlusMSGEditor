using AtlusFileSystemLibrary.Common.IO;
using AtlusFileSystemLibrary.FileSystems.PAK;
using AtlusScriptCompiler;
using AtlusScriptLibrary.Common.Libraries;
using AtlusScriptLibrary.Common.Logging;
using AtlusScriptLibrary.FlowScriptLanguage;
using AtlusScriptLibrary.MessageScriptLanguage.Compiler;
using AtlusScriptLibrary.MessageScriptLanguage;
using MetroSet_UI.Forms;
using ShrineFox.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using static AtlusMSGEditor.MainForm;
using AtlusScriptLibrary.FlowScriptLanguage.Decompiler;
using AtlusScriptLibrary.Common.Text.Encodings;
using AtlusScriptLibrary.Common.Collections;

namespace AtlusMSGEditor
{
    public partial class MainForm : MetroSetForm
    {
        private List<Message> GetMessagesFromDump(string msgPath)
        {
            string[] lines = File.ReadAllText(msgPath)
                        .Replace("[f 0 5 65278][f 2 1]", "[s]")
                        .Split('\n');

            List<Message> msgs = new List<Message>();

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith("[msg ") || lines[i].StartsWith("[dlg ") || lines[i].StartsWith("[sel "))
                {
                    Message message = new Message() { IsSelection = lines[i].StartsWith("[sel ") };
                    string speakerName = "";
                    string msgName = lines[i].Replace("[msg ", "").Replace("[dlg ", "").Replace("[sel ", "").TrimEnd(']');
                    if (msgName.Contains("["))
                    {
                        speakerName = msgName.Split('[')[1].Replace("]", "");
                        msgName = msgName.Split('[')[0].TrimEnd();
                    }
                    message.Speaker = speakerName.TrimEnd('\r');
                    message.Name = msgName.Replace("]", "").Replace(" top", "").TrimEnd('\r');

                    string msgTxt = "";
                    for (int x = i + 1; x < lines.Length; x++)
                    {
                        if (lines[x].StartsWith("[msg ") || lines[x].StartsWith("[dlg ") || lines[x].StartsWith("[sel "))
                        {
                            i = x - 1;
                            break;
                        }

                        msgTxt += lines[x] + "\n";
                    }

                    message.Text = msgTxt.TrimEnd();
                    msgs.Add(message);
                }
            }

            return msgs;
        }

        private void LoadMsgsFromDumpDir()
        {
            MsgDirs = new List<MsgDir>();
            foreach (var dir in Directory.GetDirectories(formSettings.DumpOutputPath, "*", SearchOption.AllDirectories))
            {
                MsgDir msgDir = new MsgDir() { Path = dir };

                foreach (var file in Directory.GetFiles(dir, "*.msg", SearchOption.TopDirectoryOnly))
                    msgDir.MsgFiles.Add(new MsgFile()
                    {
                        Path = file,
                        Messages = GetMessagesFromDump(file),
                        UsedByBf = File.Exists(FileSys.GetExtensionlessPath(file) + ".bf")
                    });

                if (msgDir.MsgFiles.Count > 0)
                    MsgDirs.Add(msgDir);
            }
        }

        private void CombineToTxt(string directory, string extension)
        {
            string txtPath = Path.Combine(formSettings.CPKExportPath, extension.Replace(".", "") + "Dump.txt");
            Directory.CreateDirectory(formSettings.CPKExportPath);
            File.CreateText(txtPath).Close();

            foreach (var file in Directory.GetFiles(directory, $"*{extension}", SearchOption.AllDirectories))
            {
                File.AppendAllText(txtPath,
                    $"// {FileSys.GetExtensionlessPath(file)}" +
                    $"\n{File.ReadAllText(file)}\n");
            }
        }

        private void CreateTXTDump()
        {
            if (Directory.Exists(formSettings.DumpOutputPath))
            {
                // Combine .MSG and .FLOW files into single .txt files
                Output.Log($"Combining .MSGs in \"{formSettings.DumpOutputPath}\"...");
                CombineToTxt(formSettings.DumpOutputPath, ".msg");
                Output.Log($"Done Combining .MSGs.");
                Output.Log($"Combining .FLOWs in \"{formSettings.DumpOutputPath}\"...");
                CombineToTxt(formSettings.DumpOutputPath, ".flow");
                Output.Log($"Done Combining .FLOWs.");
            }
        }

        private void CreateJSONDump()
        {
            Directory.CreateDirectory(formSettings.CPKExportPath);
            string outPath = Path.Combine(formSettings.CPKExportPath, "msgDirs.json");

            //RemoveDuplicateBaseCPKFiles();
            //RemoveEmptyMsgDirs();
            //RestoreLineStart();
            //RemoveNewlineFromSEL();
            //RemoveExtraNewlines();

            string jsonText = JsonConvert.SerializeObject(MsgDirs, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(outPath, jsonText);
            MessageBox.Show($"Saved Message Dump Json file to:\n{outPath}" +
                $"\n\nMove it to \"{formSettings.DefaultJSON}\" to load automatically at startup.", "Json Dump Saved");
        }

        private void RemoveExtraNewlines()
        {
            foreach (var dir in MsgDirs)
                foreach (var file in dir.MsgFiles)
                    foreach (var msg in file.Messages)
                    {
                        msg.Text = msg.Text.Replace("[e][n][s]", "[e][s]");
                    }
        }

        private void RestoreLineStart()
        {
            foreach (var dir in MsgDirs)
                foreach (var file in dir.MsgFiles)
                    foreach (var msg in file.Messages)
                    {
                        var lines = msg.Text.Split(new string[] { "[n]" }, StringSplitOptions.None);
                        for (int i = 0; i < lines.Length; i++)
                        {
                            if (i == 0 || lines[i - 1].EndsWith("[e]"))
                            {
                                lines[i] = "[s]" + lines[i];
                            }
                        }
                        msg.Text = string.Join("[n]", lines);
                    }
        }

        private void RemoveNewlineFromSEL()
        {
            foreach (var dir in MsgDirs)
                foreach (var file in dir.MsgFiles)
                    foreach (var msg in file.Messages)
                        if (msg.IsSelection)
                            msg.Text = msg.Text.Replace("[n]", "");
        }

        private void RemoveEmptyMsgDirs()
        {
            List<MsgDir> msgDirsToRemove = new List<MsgDir>();
            foreach (var dir in MsgDirs)
            {
                if (dir.MsgFiles.Count <= 0)
                    msgDirsToRemove.Add(dir);
            }
            foreach (var removeDir in msgDirsToRemove)
            {
                MsgDirs.Remove(removeDir);
            }
        }

        private void RemoveDuplicateBaseCPKFiles()
        {
            List<MsgFile> msgFilesToRemove = new List<MsgFile>();
            foreach (var dir in MsgDirs.Where(x => x.Path.Contains("EN.CPK")))
            {
                foreach (var msg in dir.MsgFiles)
                {
                    if (MsgDirs.Any(x => x.MsgFiles.Any(y => y.Path == msg.Path.Replace("EN.CPK", "BASE.CPK"))))
                    {
                        var msgFileToRemove = MsgDirs.First(x =>
                            x.MsgFiles.Any(y => y.Path == msg.Path.Replace("EN.CPK", "BASE.CPK")))
                                .MsgFiles.First(y => y.Path == msg.Path.Replace("EN.CPK", "BASE.CPK"));
                        msgFilesToRemove.Add(msgFileToRemove);
                    }
                }
            }
            foreach (var dir in MsgDirs)
            {
                foreach (var fileToRemove in msgFilesToRemove)
                {
                    if (dir.MsgFiles.Any(x => x.Path == fileToRemove.Path))
                    {
                        dir.MsgFiles.Remove(fileToRemove);
                    }
                }
            }
        }

        private void ImportBMDs()
        {
            string importDir = WinFormsDialogs.SelectFolder("Choose Extracted CPKs Directory");
            if (Directory.Exists(importDir))
            {
                formSettings.DumpInputPath = importDir;

                if (deleteExistingDumpDirToolStripMenuItem.Checked)
                {
                    if (!WinFormsDialogs.ShowMessageBox("Delete Dump folder?",
                    $"The existing \"{formSettings.DumpOutputPath}\" directory and its contents will be deleted." +
                    $"\nAre you sure you want to continue?", MessageBoxButtons.YesNo))
                        return;

                    if (Directory.Exists(formSettings.DumpOutputPath))
                        Directory.Delete(formSettings.DumpOutputPath, true);
                }

                // Use AtlusScriptCompiler to decompile BF to FLOW and BMD to MSG in Dump dir
                Output.Log($"Decompiling .BMDs from \"{formSettings.DumpInputPath}\"...");
                DecompileBMDsFromPath(formSettings.DumpInputPath);
                Output.Log($"Done Decompiling .BMDs to \"{formSettings.DumpOutputPath}\".");

                // Read MSG files from Dump dir to MsgDirs object
                Output.Log($"Loading .BMD dump into memory from \"{formSettings.DumpOutputPath}\".");
                LoadMsgsFromDumpDir();
                Output.Log($"Done loading .BMD dump.");
            }
        }

        private void DecompileBMDsFromPath(string inputDir)
        {
            var importFiles = Directory.GetFiles(inputDir, "*", SearchOption.AllDirectories);

            foreach (var file in importFiles)
            {
                switch (Path.GetExtension(file).ToLower())
                {
                    case ".bmd":
                    case ".bf":
                        DumpScript(file);
                        break;
                    case ".pak":
                    case ".pac":
                        ProcessPAC(file);
                        break;
                    case ".bin":
                        if (file.ToUpper().EndsWith("CMM.BIN"))
                            ProcessPAC(file);
                        break;
                    default:
                        break;
                }
            }
        }

        private void ProcessPAC(string pacFile)
        {
            string extractedDir = pacFile.Replace(formSettings.DumpInputPath, formSettings.DumpOutputPath);
            if (Directory.Exists(extractedDir))
                return;

            // Extract .bf files from .PAC
            PAKFileSystem pak = new PAKFileSystem();
            if (PAKFileSystem.TryOpen(pacFile, out pak))
            {
                foreach (var fileInPAC in pak.EnumerateFiles().Where(x => x.ToLower().EndsWith(".bf") || x.ToLower().EndsWith(".bmd")))
                {
                    string normalizedFilePath = fileInPAC.Replace("../", ""); //Remove backwards relative path
                    string outputPath = Path.Combine(extractedDir, normalizedFilePath);

                    using (var stream = FileUtils.Create(outputPath))
                    using (var inputStream = pak.OpenFile(fileInPAC))
                    {
                        inputStream.CopyTo(stream);
                    }
                    using (FileSys.WaitForFile(outputPath)) { }
                    DumpScript(outputPath);
                }
                Output.VerboseLog($"Unpacked archive: \"{pacFile}\"", ConsoleColor.Green);
            }
        }

        private void DumpScript(string scriptPath)
        {
            string extension = ".msg";
            if (Path.GetExtension(scriptPath).ToLower() == ".bf")
            {
                File.Copy(scriptPath, scriptPath.Replace(formSettings.DumpInputPath, formSettings.DumpOutputPath));
                extension = ".flow";
            }

            string outPath = scriptPath.Replace(formSettings.DumpInputPath, formSettings.DumpOutputPath) + extension;
            Directory.CreateDirectory(Path.GetDirectoryName(outPath));

            InitializeScriptCompiler(scriptPath, outPath);

            if (!File.Exists(outPath))
            {
                try
                {
                    AtlusScriptCompiler.Program.Main(new string[] {
                scriptPath, "-Decompile",
                "-Library", "P5R",
                "-Encoding", comboBox_Encoding.SelectedItem.ToString(),
                "-Out", outPath });
                }
                catch { File.AppendAllText("dumpErrors.txt", scriptPath + "\n"); }
            }
        }

        private string ApplyReplacements(string text)
        {
            foreach (var replacement in UserSettings.Replacements.Where(x => !string.IsNullOrEmpty(x.TextToReplace)))
                text = Regex.Replace(text, replacement.TextToReplace, replacement.ReplacementText, RegexOptions.CultureInvariant);
            return text;
        }

        private void InitializeScriptCompiler(string inputPath, string outputPath)
        {
            AtlusScriptCompiler.Program.IsActionAssigned = false;
            AtlusScriptCompiler.Program.InputFilePath = inputPath;
            AtlusScriptCompiler.Program.OutputFilePath = outputPath;
            AtlusScriptCompiler.Program.MessageScriptEncoding = AtlusEncoding.GetByName(formSettings.UserEncoding);
            AtlusScriptCompiler.Program.MessageScriptTextEncodingName = AtlusEncoding.GetByName(formSettings.UserEncoding).EncodingName;
            switch (Path.GetExtension(inputPath).ToLower())
            {
                case ".bmd":
                    AtlusScriptCompiler.Program.InputFileFormat = InputFileFormat.MessageScriptBinary;
                    break;
                case ".bf":
                    AtlusScriptCompiler.Program.InputFileFormat = InputFileFormat.FlowScriptBinary;
                    break;
                case ".flow":
                    AtlusScriptCompiler.Program.InputFileFormat = InputFileFormat.FlowScriptTextSource;
                    break;
                case ".msg":
                    AtlusScriptCompiler.Program.InputFileFormat = InputFileFormat.MessageScriptTextSource;
                    break;
            }
            AtlusScriptCompiler.Program.Logger = new Logger($"{nameof(AtlusScriptCompiler)}_{Path.GetFileNameWithoutExtension(outputPath)}");
            AtlusScriptCompiler.Program.Listener = new FileAndConsoleLogListener(true, LogLevel.Info | LogLevel.Warning | LogLevel.Error | LogLevel.Fatal);
        }

        private void ExportBMDs()
        {
            if (Directory.Exists(formSettings.CPKExportPath) && deleteExistingOutputDirToolStripMenuItem.Checked)
            {
                if (!WinFormsDialogs.ShowMessageBox("Delete Output folder?",
                $"The existing \"{formSettings.CPKExportPath}\" directory and its contents will be deleted." +
                $"\nAre you sure you want to continue?", MessageBoxButtons.YesNo))
                    return;

                if (Directory.Exists(formSettings.DumpOutputPath))
                    Directory.Delete(formSettings.DumpOutputPath, true);
            }

            Directory.CreateDirectory(formSettings.CPKExportPath);

            Output.Log($"Creating new .MSGs in \"{formSettings.CPKExportPath}\"...");
            ExportMSGsToPath(formSettings.CPKExportPath, exportOnlyEditedMessagesToolStripMenuItem.Checked);
            Output.Log($"Done creating new .MSGs.");

            if (!exportOnlyEditedMessagesToolStripMenuItem.Checked)
            {
                if (outputBMDToolStripMenuItem.Checked)
                {
                    Output.Log($"Compiling .MSGs to .BMD in \"{formSettings.CPKExportPath}\"...");
                    CompileMSGsInPath(formSettings.CPKExportPath);
                    Output.Log($"Done compiling .MSGs to .BMD.");
                }

                if (deleteOutputMSGToolStripMenuItem.Checked)
                {
                    Output.Log($"Deleting output .MSG files...");
                    DeleteMSGsInPath(formSettings.CPKExportPath);
                    Output.Log($"Done deleting output .MSG files.");
                }
                else if (outputBMDToolStripMenuItem.Checked)
                {
                    RenameMSGsInPath(formSettings.CPKExportPath);
                }
            }

            Output.Log($"Export complete!", ConsoleColor.Green);
        }

        private void RenameMSGsInPath(string renameMsgPath)
        {
            foreach (var msg in Directory.GetFiles(renameMsgPath, "*.msg", SearchOption.AllDirectories))
                File.Move(msg, msg.Replace(".bmd",""));
        }

        private void DeleteMSGsInPath(string deleteMsgPath)
        {
            foreach (var msg in Directory.GetFiles(deleteMsgPath, "*.msg", SearchOption.AllDirectories))
                File.Delete(msg);
        }

        private void ExportMSGsToPath(string CPKExportPath, bool changedOnly = false)
        {
            for (int i = 0; i < MsgDirs.Count; i++)
            {
                ExportChangedMSGFilesInMsgDir(MsgDirs[i], CPKExportPath, changedOnly);

                double dbl = i / MsgDirs.Count;
                SetProgress(Convert.ToInt32(Math.Round(dbl, 0)));
            }
        }

        private void ExportChangedMSGFilesInMsgDir(MsgDir msgDir, string CPKExportPath, bool changedOnly)
        {
            foreach (var msgFile in msgDir.MsgFiles.Where(x =>
                    x.Messages.Any(y =>
                        y.Change != null ||
                        (exportAutoReplacedFilesToolStripMenuItem.Checked
                            && (y.Text != ApplyReplacements(y.Text) || y.Speaker != ApplyReplacements(y.Speaker)))
                    )))
            {
                ExportChangedMSGFile(msgFile, CPKExportPath, changedOnly);
            }
        }

        private void ExportChangedMSGFile(MsgFile msgFile, string CPKExportPath, bool changedOnly)
        {
            string msgTxt = "";
            foreach (var msg in msgFile.Messages)
            {
                if (!changedOnly || msg.Change != null)
                {
                    string speaker = msg.Speaker;
                    string text = msg.Text;
                    if (msg.Change != null)
                    {
                        speaker = msg.Change.Speaker;
                        text = msg.Change.MsgText;
                    }

                    if (msg.IsSelection)
                        msgTxt += "[sel ";
                    else
                        msgTxt += "[msg ";

                    msgTxt += msg.Name;
                    if (!string.IsNullOrEmpty(speaker))
                    {
                        msgTxt += $" [{ApplyReplacements(speaker)}]";
                    }
                    msgTxt += "]\n";
                    msgTxt += ApplyReplacements(text) + "\n\n";
                }
            }

            string outPath = CPKExportPath + "\\" + msgFile.Path.Substring(msgFile.Path.IndexOf("\\"));

            if (changedOnly && msgFile.Path.Contains(".BF") && Directory.Exists(formSettings.FEmuExportPath))
            {
                outPath = formSettings.FEmuExportPath + "\\" + msgFile.Path.Substring(msgFile.Path.IndexOf("\\"));
                outPath = FileSys.GetExtensionlessPath(FileSys.GetExtensionlessPath(outPath)) + ".msg";
                string dummyBfPath = CPKExportPath + "\\" + FileSys.GetExtensionlessPath(msgFile.Path.Substring(msgFile.Path.IndexOf("\\")));
                if (!File.Exists(dummyBfPath))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(dummyBfPath));
                    File.WriteAllText(dummyBfPath, "");
                }
            }

            Directory.CreateDirectory(Path.GetDirectoryName(outPath));
            File.WriteAllText(outPath, msgTxt);
        }

        private void CompileMSGsInPath(string CPKExportPath)
        {
            var msgFiles = Directory.GetFiles(CPKExportPath, "*.msg", SearchOption.AllDirectories);

            for (int i = 0; i < msgFiles.Length; i++)
            {
                string outPath = FileSys.GetExtensionlessPath(msgFiles[i]);
                string ext = Path.GetExtension(outPath).ToLower();
                if (ext == ".bf")
                {
                    InjectMSGIntoBF(msgFiles[i], outPath);
                }
                else
                {
                    CompileMSGToBMD(msgFiles[i], outPath);
                }

                double dbl = i / msgFiles.Length;
                SetProgress(Convert.ToInt32(Math.Round(dbl, 0)));
            }
        }

        private void InjectMSGIntoBF(string msgFile, string outBfPath)
        {
            string dumpBfENPath = FileSys.GetExtensionlessPath(msgFile).Replace(formSettings.CPKExportPath, formSettings.DumpInputPath + "\\" + "EN.CPK_unpacked\\");
            string dumpBfBASEPath = FileSys.GetExtensionlessPath(msgFile).Replace(formSettings.CPKExportPath, formSettings.DumpInputPath + "\\" + "BASE.CPK_unpacked\\");

            if (Path.GetExtension(dumpBfENPath).ToLower() != ".bf")
                return;

            string dumpBfPath = null;
            if (File.Exists(dumpBfENPath))
                dumpBfPath = dumpBfENPath;
            else if (File.Exists(dumpBfBASEPath))
                dumpBfPath = dumpBfBASEPath;
            else
                return;

            FlowScript flowScript = FlowScript.FromFile(dumpBfPath, null);

            using (FileStream fileStream = File.OpenRead(msgFile))
            {
                MessageScriptCompiler messageScriptCompiler = new MessageScriptCompiler(
                    AtlusScriptLibrary.MessageScriptLanguage.FormatVersion.Version1BigEndian, AtlusEncoding.GetByName(formSettings.UserEncoding));
                messageScriptCompiler.AddListener(new ConsoleLogListener(true, LogLevel.Info | LogLevel.Warning
                    | LogLevel.Error | LogLevel.Fatal));
                messageScriptCompiler.Library = LibraryLookup.GetLibrary("P5R");
                MessageScript messageScript;
                if (!messageScriptCompiler.TryCompile(fileStream, out messageScript))
                    return;
                flowScript.MessageScript = messageScript;
                Directory.CreateDirectory(Path.GetDirectoryName(outBfPath));
                /*var bin = flowScript.ToBinary();
                if (bin.SectionHeaders.Last().ElementSize == 240)
                {
                    bin.SectionHeaders.RemoveLast(bin.SectionHeaders.Last()); // doesn't seem to work
                }
                */
                flowScript.ToFile(outBfPath);
            }
        }

        public static void CopyStream(Stream input, Stream output, int bytes)
        {
            byte[] buffer = new byte[32768];
            int read;
            while (bytes > 0 &&
                   (read = input.Read(buffer, 0, Math.Min(buffer.Length, bytes))) > 0)
            {
                output.Write(buffer, 0, read);
                bytes -= read;
            }
        }

        public string GetFlowTxt(string bfPath)
        {
            if (!File.Exists(bfPath) || Path.GetExtension(bfPath).ToLower() != ".bf")
                return null;

            FlowScript flowScript = FlowScript.FromFile(bfPath, null);
            FlowScriptDecompiler decompiler = new FlowScriptDecompiler() 
                { DecompileMessageScript = false, Library = LibraryLookup.GetLibrary("P5R"), SumBits = true };

            string tempPath = ".\\temp.flow";
            InitializeScriptCompiler(bfPath, tempPath);
            if (File.Exists(tempPath))
                File.Delete(tempPath);
            if (decompiler.TryDecompile(flowScript, tempPath))
                return UpdateMessageNames(File.ReadAllLines(tempPath));
            else
                return null;
        }

        private string UpdateMessageNames(string[] flowLines)
        {
            if (!chk_UseMessageName.Checked)
                return string.Join("\r\n", flowLines);

            MsgFile msgFile = (MsgFile)listBox_Files.SelectedItem;
            
            string flowText = "";
            for (int i = 0; i < flowLines.Length; i++)
            {
                if (flowLines[i].Contains("MSG( ")
                    //|| flowLines[i].Contains("SEL( ")
                    || flowLines[i].Contains("MSG_MIND( "))
                {
                    string FUNC = "";
                    string extraParameter = "";

                    switch (flowLines[i])
                    {
                        case string a when a.Contains("MSG( "): FUNC = "MSG"; break;
                        case string b when b.Contains("MSG_MIND( "): FUNC = "MSG_MIND"; extraParameter = ", 0"; break;
                        //case string c when c.Contains("SEL( "): FUNC = "SEL"; break;
                    }

                    string tryIsolatingMSGId = flowLines[i].Replace("MSG( ", "")
                        .Replace("MSG_MIND( ", "")
                        //.Replace("SEL( ", "")
                        .Replace(" );", "").Replace(", 0", "").Trim();
                    
                    if (Int32.TryParse(tryIsolatingMSGId, out int msgId))
                    {
                        int spaceCount = flowLines[i].TakeWhile(Char.IsWhiteSpace).Count();
                        string newLine = $"{FUNC}( {msgFile.Messages.First(x => x.Id.Equals(msgId)).Name}{extraParameter} );\r\n";
                        flowText += newLine.PadLeft(spaceCount, ' ');
                    }
                    else
                        flowText += flowLines[i] + "\r\n";
                }
                else
                    flowText += flowLines[i] + "\r\n";
            }

            return flowText;
        }

        private void CompileMSGToBMD(string msgFile, string outPath)
        {
            InitializeScriptCompiler(msgFile, outPath);

            Invoke(new MethodInvoker(() =>
            {
                AtlusScriptCompiler.Program.Main(new string[] {
                    msgFile, "-Compile",
                    "-Library", "P5R",
                    "-Encoding", comboBox_Encoding.SelectedItem.ToString(),
                    "-OutFormat", "V1BE",
                    "-Out", outPath });
            }));
        }

        public void ExportFlowTxt()
        {
            var msgFile = (MsgFile)listBox_Files.SelectedItem;
            if (!Directory.Exists(formSettings.FEmuExportPath) || msgFile == null)
            {
                MessageBox.Show("FEmulator output path was not found!");
                return;
            }

            string flowPath = formSettings.FEmuExportPath + "\\" + FileSys.GetExtensionlessPath(FileSys.GetExtensionlessPath(msgFile.Path.Substring(msgFile.Path.IndexOf("\\")))) + ".flow";
            Directory.CreateDirectory(Path.GetDirectoryName(flowPath));

            string msgPath = flowPath.Replace(".flow",".msg");
            string flowText = txt_Flowscript.Text;

            /*
            bool isMsgChanged = listBox_Msgs.Items.Count > 0 && (msgFile.Messages.Any(y => y.Change != null ||
                (exportAutoReplacedFilesToolStripMenuItem.Checked && (y.Text != ApplyReplacements(y.Text) || y.Speaker != ApplyReplacements(y.Speaker)))));

            if (isMsgChanged)
            {
                flowText = $"import(\"{Path.GetFileName(msgPath)}\");\n\n" + flowText;
            }
            
            if (isMsgChanged)
                ExportChangedMSGFile(msgFile, msgPath, true);
            */

            File.WriteAllText(flowPath, flowText);

            if (Directory.Exists(formSettings.CPKExportPath))
            {
                string dummyBfPath = formSettings.CPKExportPath + "\\" + FileSys.GetExtensionlessPath(msgFile.Path.Substring(msgFile.Path.IndexOf("\\")));
                if (!File.Exists(dummyBfPath))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(dummyBfPath));
                    File.WriteAllText(dummyBfPath, "");
                }
            }

            DialogResult result = MessageBox.Show($"The .flow file was saved to:\n\n\"{flowPath}\"", "Exported. flow", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
                Exe.Run("explorer.exe", Path.GetDirectoryName(flowPath), hideWindow: false);
        }
    }
}
