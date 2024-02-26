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
            foreach (var dir in Directory.GetDirectories(dumpOutPath, "*", SearchOption.AllDirectories))
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
            string txtPath = Path.Combine(exportPath, extension.Replace(".", "") + "Dump.txt");
            Directory.CreateDirectory(exportPath);
            File.CreateText(txtPath).Close();

            foreach (var file in Directory.GetFiles(directory, $"*{extension}", SearchOption.AllDirectories))
            {
                File.AppendAllText(txtPath,
                    $"// {FileSys.GetExtensionlessPath(file.Replace(dumpOutPath, "."))}" +
                    $"\n{File.ReadAllText(file)}\n");
            }
        }

        private void CreateTXTDump()
        {
            if (Directory.Exists(dumpOutPath))
            {
                // Combine .MSG and .FLOW files into single .txt files
                Output.Log($"Combining .MSGs in \"{dumpOutPath}\"...");
                CombineToTxt(dumpOutPath, ".msg");
                Output.Log($"Done Combining .MSGs.");
                Output.Log($"Combining .FLOWs in \"{dumpOutPath}\"...");
                CombineToTxt(dumpOutPath, ".flow");
                Output.Log($"Done Combining .FLOWs.");
            }
        }

        private void CreateJSONDump()
        {
            Directory.CreateDirectory(exportPath);
            string outPath = Path.Combine(exportPath, "msgDirs.json");
            string jsonText = JsonConvert.SerializeObject(MsgDirs, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(outPath, jsonText);
            MessageBox.Show($"Saved Message Dump Json file to:\n{outPath}" +
                $"\n\nMove it to \"{defaultJson}\" to load automatically at startup.", "Json Dump Saved");
        }

        private void ImportBMDs()
        {
            string importDir = WinFormsDialogs.SelectFolder("Choose Extracted CPKs Directory");
            if (Directory.Exists(importDir))
            {
                dumpInputPath = importDir;

                if (deleteExistingDumpDirToolStripMenuItem.Checked)
                {
                    if (!WinFormsDialogs.ShowMessageBox("Delete Dump folder?",
                    $"The existing \"{dumpOutPath}\" directory and its contents will be deleted." +
                    $"\nAre you sure you want to continue?", MessageBoxButtons.YesNo))
                        return;

                    if (Directory.Exists(dumpOutPath))
                        Directory.Delete(dumpOutPath, true);
                }

                // Use AtlusScriptCompiler to decompile BF to FLOW and BMD to MSG in Dump dir
                Output.Log($"Decompiling .BMDs from \"{dumpInputPath}\"...");
                DecompileBMDsFromPath(dumpInputPath);
                Output.Log($"Done Decompiling .BMDs to \"{dumpOutPath}\".");

                // Read MSG files from Dump dir to MsgDirs object
                Output.Log($"Loading .BMD dump into memory from \"{dumpOutPath}\".");
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
            string extractedDir = pacFile.Replace(dumpInputPath, dumpOutPath);
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
                File.Copy(scriptPath, scriptPath.Replace(dumpInputPath, dumpOutPath));
                extension = ".flow";
            }

            string outPath = scriptPath.Replace(dumpInputPath, dumpOutPath) + extension;
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
            AtlusScriptCompiler.Program.MessageScriptEncoding = userEncoding;
            AtlusScriptCompiler.Program.MessageScriptTextEncodingName = userEncoding.EncodingName;
            if (Path.GetExtension(inputPath).ToLower() == ".bmd")
                AtlusScriptCompiler.Program.InputFileFormat = InputFileFormat.MessageScriptBinary;
            else if (Path.GetExtension(inputPath).ToLower() == ".bf")
                AtlusScriptCompiler.Program.InputFileFormat = InputFileFormat.FlowScriptBinary;
            AtlusScriptCompiler.Program.Logger = new Logger($"{nameof(AtlusScriptCompiler)}_{Path.GetFileNameWithoutExtension(outputPath)}");
            AtlusScriptCompiler.Program.Listener = new FileAndConsoleLogListener(true, LogLevel.Info | LogLevel.Warning | LogLevel.Error | LogLevel.Fatal);
        }

        private void ExportBMDs()
        {
            if (Directory.Exists(exportPath) && deleteExistingOutputDirToolStripMenuItem.Checked)
            {
                if (!WinFormsDialogs.ShowMessageBox("Delete Output folder?",
                $"The existing \"{exportPath}\" directory and its contents will be deleted." +
                $"\nAre you sure you want to continue?", MessageBoxButtons.YesNo))
                    return;

                if (Directory.Exists(dumpOutPath))
                    Directory.Delete(dumpOutPath, true);
            }

            Directory.CreateDirectory(exportPath);

            Output.Log($"Creating new .MSGs in \"{exportPath}\"...");
            ExportMSGsToPath(exportPath);
            Output.Log($"Done creating new .MSGs.");

            if (outputBMDToolStripMenuItem.Checked)
            {
                Output.Log($"Compiling .MSGs to .BMD in \"{exportPath}\"...");
                CompileMSGsInPath(exportPath);
                Output.Log($"Done compiling .MSGs to .BMD.");
            }

            if (deleteOutputMSGToolStripMenuItem.Checked)
            {
                Output.Log($"Deleting output .MSG files...");
                DeleteMSGsInPath(exportPath);
                Output.Log($"Done deleting output .MSG files.");
            }

            Output.Log($"Export complete!", ConsoleColor.Green);
        }

        private void DeleteMSGsInPath(string exportPath)
        {
            foreach (var msg in Directory.GetFiles(exportPath, "*.msg", SearchOption.AllDirectories))
                File.Delete(msg);
        }

        private void ExportMSGsToPath(string path)
        {
            for (int i = 0; i < MsgDirs.Count; i++)
            {
                foreach (var file in MsgDirs[i].MsgFiles.Where(x =>
                    x.Messages.Any(y =>
                        y.Change != null ||
                        (exportAutoReplacedFilesToolStripMenuItem.Checked 
                            && (y.Text != ApplyReplacements(y.Text) || y.Speaker != ApplyReplacements(y.Speaker)) )
                    )))
                {
                    string msgTxt = "";
                    foreach (var msg in file.Messages)
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
                    string outPath = file.Path.Replace(dumpOutPath, path);
                    Directory.CreateDirectory(Path.GetDirectoryName(outPath));
                    File.WriteAllText(outPath, msgTxt);
                }

                double dbl = i / MsgDirs.Count;
                SetProgress(Convert.ToInt32(Math.Round(dbl, 0)));
            }
        }

        private void CompileMSGsInPath(string path)
        {
            var msgFiles = Directory.GetFiles(path, "*.msg", SearchOption.AllDirectories);

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
            string dumpBfPath = FileSys.GetExtensionlessPath(msgFile).Replace(exportPath, dumpInputPath);

            if (!File.Exists(dumpBfPath) || Path.GetExtension(dumpBfPath).ToLower() != ".bf")
                return;

            FlowScript flowScript = FlowScript.FromFile(dumpBfPath, null);

            using (FileStream fileStream = File.OpenRead(msgFile))
            {
                MessageScriptCompiler messageScriptCompiler = new MessageScriptCompiler(
                    AtlusScriptLibrary.MessageScriptLanguage.FormatVersion.Version1BigEndian, userEncoding);
                messageScriptCompiler.AddListener(new ConsoleLogListener(true, LogLevel.Info | LogLevel.Warning
                    | LogLevel.Error | LogLevel.Fatal));
                messageScriptCompiler.Library = LibraryLookup.GetLibrary("P5R");
                MessageScript messageScript;
                if (!messageScriptCompiler.TryCompile(fileStream, out messageScript))
                    return;
                flowScript.MessageScript = messageScript;
                Directory.CreateDirectory(Path.GetDirectoryName(outBfPath));
                flowScript.ToFile(outBfPath);
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
                return File.ReadAllText(tempPath);
            else
                return null;
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
    }
}
