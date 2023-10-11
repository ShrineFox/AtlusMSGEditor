﻿using AtlusScriptCompiler;
using AtlusScriptLibrary.Common.Logging;
using AtlusScriptLibrary.Common.Text.Encodings;
using MetroSet_UI.Forms;
using Newtonsoft.Json;
using ShrineFox.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using AtlusFileSystemLibrary;
using AtlusFileSystemLibrary.Common.IO;
using AtlusFileSystemLibrary.FileSystems.PAK;
using System.Linq;
using System.Runtime.Remoting.Contexts;

namespace AtlusMSGEditor
{
    public partial class MainForm : MetroSetForm
    {
        public Encoding userEncoding = AtlusEncoding.Persona5RoyalEFIGS;
        public string dumpInputPath = "";
        public string dumpOutPath = ".\\Dump";

        public MainForm()
        {
            InitializeComponent();

            // Setup form appearance
            ApplyTheme();
            SetLogging();
            MenuStripHelper.SetMenuStripIcons(MenuStripHelper.GetMenuStripIconPairs("Icons.txt"), this);

            comboBox_Encoding.SelectedIndex = 0;
            if (File.Exists("msgDirs.json"))
                MsgDirs = JsonConvert.DeserializeObject<List<MsgDir>>(File.ReadAllText("msgDirs.json"));

            SetDirectoryListBoxDataSource();
        }

        private List<Message> GetMessagesFromDump(string msgPath)
        {
            string[] lines = File.ReadAllText(msgPath)
                        .Replace("[s]", "").Replace("[n]", "\r\n")
                        .Replace("[f 0 5 65278][f 2 1]", "")
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
                        speakerName = msgName.Split('[')[1].Replace("]","");
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

        // Data loaded from script dump for viewing/editing in form
        public List<MsgDir> MsgDirs = new List<MsgDir>();

        // Data generated by user by editing, used to generate exported files
        public Settings UserSettings = new Settings();

        public class Settings
        {
            public List<Change> Changes { get; set; } = new List<Change>();
            public List<Tuple<string, string>> Replacements { get; set; } = new List<Tuple<string, string>>();
        }

        public class Change
        {
            public string Path { get; set; } = "";
            public string MsgName { get; set; } = "";
            public string MsgText { get; set; } = "";
            public string Speaker { get; set; } = "";
        }

        public class MsgDir
        {
            public int Id { get; set; } = 0;
            public string Path { get; set; } = "";
            public List<MsgFile> MsgFiles { get; set; } = new List<MsgFile>();
        }

        public class MsgFile
        {
            public int Id { get; set; } = 0;
            public string Path { get; set; } = "";
            public bool UsedByBf { get; set; } = false;
            public List<Message> Messages { get; set; } = new List<Message>();
        }

        public class Message
        {
            public int Id { get; set; } = 0;
            public string Name { get; set; } = "";
            public string Text { get; set; } = "";
            public string Speaker { get; set; } = "";
            public bool IsSelection { get; set; } = false;
            public Change Change { get; set; } = null;
        }

        private void ImportBMDs_Click(object sender, EventArgs e)
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
                Output.Log($"Dumping .BMDs from \"{dumpInputPath}\"...");
                ImportBMDs(Directory.GetFiles(dumpInputPath, "*", SearchOption.AllDirectories));
                Output.Log($"Done Dumping .BMDs to \"{dumpOutPath}\".");

                // Read MSG files from Dump dir to MsgDirs object
                Output.Log($"Loading .BMD dump into memory from \"{dumpOutPath}\".");
                LoadMsgsFromDumpDir();
                Output.Log($"Done loading .BMD dump.");
            }
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

            string jsonText = JsonConvert.SerializeObject(MsgDirs, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("msgDirs.json", jsonText);
        }

        private void CombineToTxt(string directory, string extension)
        {
            string txt = "";

            foreach (var file in Directory.GetFiles(directory, $"*{extension}", SearchOption.AllDirectories))
            {
                txt += $"// {FileSys.GetExtensionlessPath(file.Replace(dumpOutPath, "."))}\n";
                txt += File.ReadAllText(file) + "\n";
            }

            File.WriteAllText(extension.Replace(".","") + "Dump.txt", txt);
        }

        private void ImportBMDs(string[] importFiles)
        {
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

        private void DumpScript(string bmdPath)
        {
            string extension = ".msg";
            if (Path.GetExtension(bmdPath).ToLower() == ".bf")
                extension = ".flow";

            string outPath = bmdPath.Replace(dumpInputPath, dumpOutPath) + extension;
            Directory.CreateDirectory(Path.GetDirectoryName(outPath));

            InitializeScriptCompiler(bmdPath, outPath);

            if (!File.Exists(outPath))
            {
                try
                {
                    AtlusScriptCompiler.Program.Main(new string[] {
                bmdPath, "-Decompile",
                "-Library", "P5R",
                "-Encoding", comboBox_Encoding.SelectedItem.ToString(),
                "-Out", outPath });
                }
                catch { File.AppendAllText("dumpErrors.txt", bmdPath + "\n"); }
            }
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
    }
}