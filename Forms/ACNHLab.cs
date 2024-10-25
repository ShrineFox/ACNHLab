﻿using ACNHLab.Classes;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using ZstdNet;
using static ACNHLab.Classes.Amiibo;
using System.Text.Json;
using Microsoft.Win32;
using System.Reflection;
using ShrineFox.IO;

namespace ACNHLab
{
    public partial class ACNHLab : MetroSet_UI.Forms.MetroSetForm
    {
        AmiiboJson amiiboJson = new AmiiboJson();
        public static List<Tuple<string, string, string, string>> Amiibos = new List<Tuple<string, string, string, string>>();
        public static bool collapsed;
        public ACNHLab()
        {
            InitializeComponent();
            this.Text = $"ACNHLab v{Program.version}";
            metroSetTabControl_Workspace.SelectedIndex = 0;
            ToolStripManager.Renderer = r;
            menuStrip_Main.Renderer = r;
            treeView_Project.ImageList = Treeview.treeViewImageList;
            collapsed = false;
            Output.LogControl = richTextBox_Status;
            Output.Logging = true;
            Output.LogPath = "Log.txt";
            Output.LogToFile = true;
            SetupDropDowns();
            SetToolStripImages();
        }

        private void SetToolStripImages()
        {
            ToolStripMenuItem_Compile.Image = Image.FromFile("Icons\\application_go.png");
            ToolStripMenuItem_Unpack.Image = Image.FromFile("Icons\\folder_go.png");
            ToolStripMenuItem_RepackPAC.Image = Image.FromFile("Icons\\package.png");
            ToolStripMenuItem_RepackAs.Image = Image.FromFile("Icons\\package_go.png");
            ToolStripMenuItem_Decompile.Image = Image.FromFile("Icons\\application_xp_terminal.png");
            ToolStripMenuItem_Remove.Image = Image.FromFile("Icons\\delete.png");
            button_AddSpecies.Image = Image.FromFile("Icons\\add.png");
            btn_AddVillager.Image = Image.FromFile("Icons\\add.png");
            btn_RemoveVillager.Image = Image.FromFile("Icons\\delete.png");
            button_VillagerHouse.Image = Image.FromFile("Icons\\house.png");
            saveToolStripMenuItem_SaveVillager.Image = Image.FromFile("Icons\\disk.png");
            ToolStripMenuItem_CollapseProj.Image = Image.FromFile("Icons\\arrow_join.png");
            ToolStripMenuItem_ExpandProj.Image = Image.FromFile("Icons\\chart_organisation.png");
            ToolStripMenuItem_Rename.Image = Image.FromFile("Icons\\textfield_rename.png");
            ToolStripMenuItem_Copy.Image = Image.FromFile("Icons\\page_copy.png");
            ToolStripMenuItem_OpenAt2.Image = Image.FromFile("Icons\\folder_explore.png");
            ToolStripMenuItem_Replace.Image = Image.FromFile("Icons\\note_go.png");
            ToolStripMenuItem_RepackAWB.Image = Image.FromFile("Icons\\music.png");
            ToolStripMenuItem_RepackAFS.Image = Image.FromFile("Icons\\music.png");
            fileToolStripMenuItem.Image = Image.FromFile("Icons\\disk.png");
            newProjectToolStripMenuItem.Image = Image.FromFile("Icons\\asterisk_yellow.png");
            loadProjectToolStripMenuItem.Image = Image.FromFile("Icons\\folder_page.png");
            saveProjectToolStripMenuItem.Image = Image.FromFile("Icons\\disk_multiple.png");
            settingsToolStripMenuItem.Image = Image.FromFile("Icons\\table_gear.png");
            exportToolStripMenuItem.Image = Image.FromFile("Icons\\package_go.png");
            writeAllChangesToolStripMenuItem.Image = Image.FromFile("Icons\\application_go.png");
            toolsToolStripMenuItem.Image = Image.FromFile("Icons\\application_xp_terminal.png");
            eventEditorToolStripMenuItem.Image = Image.FromFile("Icons\\pitfall.png");
            nHSEToolStripMenuItem.Image = Image.FromFile("Icons\\leaf.png");
            ToolStripMenuItem_New.Image = Image.FromFile("Icons\\asterisk_yellow.png");
            ToolStripMenuItem_NewFolder.Image = Image.FromFile("Icons\\folder_add.png");
            ToolStripMenuItem_NewFlow.Image = Image.FromFile("Icons\\script_add.png");
            ToolStripMenuItem_NewMsg.Image = Image.FromFile("Icons\\page_add.png");
            ToolStripMenuItem_NewTxt.Image = Image.FromFile("Icons\\page_white_add.png");
        }

        private void SetupDropDowns()
        {
            // Villager Stuff
            foreach (var personality in Villagers.Personality)
                metroSetComboBox_Personality.Items.Add(personality.Item2);
            foreach (var hobby in Villagers.Hobby)
                metroSetComboBox_Hobby.Items.Add(hobby.Item2);
            foreach (var clothesType in Villagers.PreferredClothes)
                metroSetComboBox_ClothesType.Items.Add(clothesType.Item2);
            foreach (var style in Villagers.PreferredStyle)
            {
                metroSetComboBox_Style.Items.Add(style.Item2);
                metroSetComboBox_Style2.Items.Add(style.Item2);
            }
            foreach (var value in Villagers.Unknown1)
                metroSetComboBox_Unknown1.Items.Add(value.Item2);
            foreach (var socialType in Villagers.SocialType)
                metroSetComboBox_SocialType.Items.Add(socialType.Item2);
            foreach (var singPauseType in Villagers.SingPauseType)
                metroSetComboBox_SingPause.Items.Add(singPauseType.Item2);
            foreach (var singRhythmType in Villagers.SingRhythmType)
                metroSetComboBox_SingRhythm.Items.Add(singRhythmType.Item2);
            foreach (var color in Villagers.Color)
            {
                metroSetComboBox_FaveColor.Items.Add(color.Item2);
                metroSetComboBox_FaveColor2.Items.Add(color.Item2);
            }
            foreach (var melodyType in Villagers.VillageMelody)
                metroSetComboBox_Melody.Items.Add(melodyType.Item2);
            foreach (var melodyType2 in Villagers.VillageMelody2)
                metroSetComboBox_Melody2.Items.Add(melodyType2.Item2);

            // Amiibo Stuff
            metroSetComboBox_Amiibo.Items.Clear();
            metroSetComboBox_Amiibo.Items.Add("");
            metroSetComboBox_AmiiboSeries.Items.Clear();
            metroSetComboBox_AmiiboSeries.Items.Add("");
            if (File.Exists(".//Dependencies//Amiibo.json"))
            {
                amiiboJson = JsonSerializer.Deserialize<AmiiboJson>(File.ReadAllText(".//Dependencies//Amiibo.json"));
                foreach (var amiibo in amiiboJson.List)
                    Amiibos.Add(new Tuple<string, string, string, string>(amiibo.Head, amiibo.AmiiboSeries, amiibo.Name, amiibo.Type));
                foreach (var amiibo in Amiibos)
                {
                    if (!metroSetComboBox_AmiiboSeries.Items.Contains(amiibo.Item2))
                        metroSetComboBox_AmiiboSeries.Items.Add(amiibo.Item2);
                }
                Output.Log("[INFO] Refreshed Amiibo and Amiibo Series dropdowns.");
                metroSetComboBox_AmiiboSeries.SelectedIndex = 0;
            }
            else
                Output.Log("[ERROR] Could not locate file: ./Dependencies/Amiibo.json", ConsoleColor.Red);
        }

        #region ToolstripOptions
        /* Toolstrip Options*/
        private void NewProject_Click(object sender, EventArgs e)
        {
            this.Text = $"ACNHLab v{Program.version}";
            saveProjectToolStripMenuItem.Enabled = false;
            SettingsForm.settings = new SettingsForm.Settings();
            OpenSettingsForm();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            OpenSettingsForm();
        }

        private void OpenSettingsForm(string projectPath = "")
        {
            // Load settings from form
            using (var dialog = new SettingsForm())
            {
                if (dialog.ShowDialog() != DialogResult.OK)
                    return;
            }
            LoadProject();
        }

        private void LoadProject_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.Filters.Add(new CommonFileDialogFilter("ACNHLab Project", "*.yml"));
            dialog.Title = "Open Project File...";
            // Start in Projects folder
            string initialDir = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Projects");
            Directory.CreateDirectory(initialDir);
            dialog.InitialDirectory = initialDir;
            // Load Settings if YML file chosen
            var deserializer = new DeserializerBuilder().WithNamingConvention(PascalCaseNamingConvention.Instance).Build();
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                SettingsForm.settings = deserializer.Deserialize<SettingsForm.Settings>(File.ReadAllText(dialog.FileName));
                LoadProject();
            }
        }

        private void LoadProject()
        {
            if (SettingsForm.IsValid())
            {
                this.Text = $"ACNHLab v{Program.version} - {SettingsForm.settings.ProjectName}";
                Treeview_Project();
                saveProjectToolStripMenuItem.Enabled = true;
                // Load villager data from files
                Classes.Villagers.Load();
                // Update villager dropdown
                UpdateVillagerDropDown();
                // Update species dropdown
                metroSetComboBox_VillagerSpecies.Items.Clear();
                foreach (var species in Villagers.Species)
                    metroSetComboBox_VillagerSpecies.Items.Add(species.Item2);
                Output.Log("[INFO] Refreshed Species dropdown.");
                // Show selected villager's data in form
                metroSetComboBox_VillagerSpecies.SelectedIndex = metroSetComboBox_VillagerSpecies.Items.IndexOf(Villagers.List[0].Species);
                // Enable villagers tab controls
                tableLayoutPanel_Villagers.Enabled = true;
            }
        }

        private void UpdateVillagerDropDown(int selectIndex = 0)
        {
            metroSetComboBox_Villagers.Items.Clear();
            foreach (var villager in Villagers.List.Where(n => !n.Name.Replace("\0", "").Equals("")))
                metroSetComboBox_Villagers.Items.Add($"{Villagers.Species.First(s => s.Item2.Equals(villager.Species)).Item1}{villager.ID.ToString("00")} {villager.Name}");
            Output.Log("[INFO] Refreshed Villagers dropdown.");
            metroSetComboBox_Villagers.SelectedIndex = selectIndex;
        }

        private void UpdateIcon()
        {
            string temp = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Temp");

            string species = metroSetComboBox_Villagers.SelectedItem.ToString().Substring(0, 3);
            string ID = metroSetComboBox_Villagers.SelectedItem.ToString().Substring(3, 2);

            string sarcName = $"Layout_NpcIcon_{species}{ID}.Nin_NX_NVN.zs";
            string newLocation = Path.Combine(temp, sarcName);
            string iconRomfs = Path.Combine(SettingsForm.settings.ExtractedPath, "Model", sarcName);
            string textureName = Path.Combine(temp, Path.GetFileNameWithoutExtension(sarcName) + ".bftex");

            if (!Directory.Exists(temp))
            {
                Directory.CreateDirectory(temp);
            }

            File.Copy(iconRomfs, newLocation, true);

            string modelOutputDir = Path.Combine(temp, Path.GetFileNameWithoutExtension(sarcName));

            Decompressor decomp = new Decompressor();
            File.WriteAllBytes(newLocation, decomp.Unwrap(File.ReadAllBytes(newLocation)));

            SARC.ExtractToDir(newLocation, modelOutputDir);
            string modelFile = $"{modelOutputDir}\\output.bfres";

            /* 
             * BfresLibrary.ResFile bfres = new BfresLibrary.ResFile(modelFile);
            foreach (var texture in bfres.Textures)
            {
                texture.Value.Export(textureName, bfres);
            } */

            panel_VillagerImg.BackgroundImage = Image.FromFile(textureName);
        }

        private void SaveProjectAs_Click(object sender, EventArgs e)
        {
            if (SettingsForm.IsValid())
            {
                string originalProj = SettingsForm.settings.ProjectPath;
                string projDir = Path.GetDirectoryName(originalProj);
                string newName = "";
                RenameForm rename = new RenameForm(Path.GetFileNameWithoutExtension(originalProj));
                var result = rename.ShowDialog();
                if (result == DialogResult.OK)
                {
                    newName = rename.RenameText;
                    string newProj = Path.Combine(Path.GetDirectoryName(projDir), Path.Combine(newName, newName + ".yml"));
                    if (!Directory.Exists(Path.GetDirectoryName(newProj)))
                    {
                        SettingsForm.settings.ProjectName = newName;
                        SettingsForm.settings.ProjectPath = newProj;
                        Output.Log($"[INFO] Copying project files from \"{Path.GetFileNameWithoutExtension(originalProj)}\" to \"{Path.GetFileNameWithoutExtension(newProj)}\"");
                        // Copy all project files to new directory
                        Unpacker.CopyEntireDirectory(new DirectoryInfo(projDir), new DirectoryInfo(Path.GetDirectoryName(newProj)), true);
                        // Delete original project file copied with other project stuff
                        File.Delete(Path.Combine(Path.GetDirectoryName(newProj), Path.GetFileName(originalProj)));
                        // Save and reload new project
                        SettingsForm.SaveSettings();
                        LoadProject();
                    }
                    else
                        Output.Log($"[ERROR] Failed to save project as \"{newName}\", directory already exists");
                }
            }
        }

        private void ExportMod_Click(object sender, EventArgs e)
        {
            if (SettingsForm.IsValid())
            {
                // Move relevant files to output directory
                string dir = Path.GetDirectoryName(SettingsForm.settings.ProjectPath);

                foreach (var file in new string[] {
                    "Message\\String_USen.sarc.zs",
                    "Bcsv\\NmlNpcParam.bcsv",
                    "Bcsv\\AmiiboData.bcsv"})
                {
                    if (File.Exists(Path.Combine(dir, file)))
                    {
                        string modDir = SettingsForm.settings.OutputPath;
                        Directory.CreateDirectory(Path.Combine(modDir, Path.GetDirectoryName(file)));
                        File.Copy(Path.Combine(dir, file), Path.Combine(modDir, file), true);
                        Output.Log($"[INFO] Exported \"{file}\" to Output Directory.");
                    }
                }
                Output.Log($"[INFO] Finished exporting mod.");
                MessageBox.Show($"Finished exporting mod to:\n\n{SettingsForm.settings.OutputPath}", "Export Complete");
            }
        }

        private void WriteAllChanges_Click(object sender, EventArgs e)
        {
            // Update BCSVs, MSBTs and SARCs
            Villagers.Save();
            string status = $"Overwrote all files with currently loaded data!";
            Output.Log($"[INFO] {status}");
            MessageBox.Show(status, "Done Writing Data");
        }

        private void EventEditor_Click(object sender, EventArgs e)
        {
            OpenEventEditor();
        }

        private void OpenEventEditor(string bfevflPath = "")
        {
            // Check if python is installed, if so get python path
            string pythonPath = Tools.GetPythonPath("3.6", "", "eventeditor.exe");
            if (pythonPath != "")
                Output.Log($"[INFO] Python install detected: \"{pythonPath}\"");
            else
            {
                Output.Log($"[ERROR] Couldn't detect a 64-bit Python 3.6+ installation with \"eventeditor.exe\" installed!" +
                    $"\nInstall Python 3.6+, run \"pip install PyQt5\", then run \"pip install eventeditor\".");
                return;
            }
            // Check if eventeditor.exe is installed, if so run it
            string eventEditorPath = Path.Combine(Path.GetDirectoryName(pythonPath), Path.Combine("Scripts", "eventeditor.exe"));
            if (File.Exists(eventEditorPath))
                Output.Log($"[INFO] Running Python script: \"eventeditor.exe\"");
            else
            {
                Output.Log($"[ERROR] Couldn't find \"eventeditor.exe\"! Run \"pip install PyQt5\", then run \"pip install eventeditor\".");
                return;
            }

            Tools.KillCMD("eventeditor");
            Tools.CMD(eventEditorPath, bfevflPath);
        }

        private void NHSE_Click(object sender, EventArgs e)
        {
            // Launch NHSE if it exists
            string nhsePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), Path.Combine("Dependencies", Path.Combine("NHSE", "NHSE.exe")));
            if (!File.Exists(nhsePath))
            {
                Output.Log($"[ERROR] Couldn't find \"\\Dependencies\\NHSE\\NHSE.exe\"! Download and extract it to that folder.");
                return;
            }
            else
                Output.Log($"[INFO] Running program: \"NHSE.exe\"");

            Tools.CMD(nhsePath);
        }
        #endregion

        #region TreeViewEvents
        /* Treeview setup */
        private void Treeview_Project()
        {
            var projectExpansionState = treeView_Project.Nodes.GetExpansionState();

            treeView_Project.Nodes.Clear();
            if (Directory.Exists(Path.GetDirectoryName(SettingsForm.settings.ProjectPath)))
                Treeview.BuildTree(new DirectoryInfo(Path.GetDirectoryName(SettingsForm.settings.ProjectPath)), treeView_Project.Nodes);
            treeView_Project.Nodes.SetExpansionState(projectExpansionState);
        }

        /* Treeview Events */
        private void OpenLocationProject_Click(object sender, EventArgs e)
        {
            if (treeView_Project.SelectedNode != null)
            {
                string file = treeView_Project.SelectedNode.Name;
                Treeview.OpenLocation(file);
            }
            HideContextMenus();
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            if (treeView_Project.SelectedNode != null)
            {
                string originalName = treeView_Project.SelectedNode.Name;
                if (File.Exists(originalName) || Directory.Exists(originalName))
                {
                    string dir = Path.GetDirectoryName(originalName);
                    string newName = "";
                    RenameForm rename = new RenameForm(Path.GetFileNameWithoutExtension(originalName));
                    var result = rename.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        newName = Path.Combine(dir, rename.RenameText) + Path.GetExtension(originalName);
                        if (File.Exists(originalName) && !File.Exists(newName))
                        {
                            File.Copy(originalName, newName);
                            Output.Log($"[INFO] Copied \"{Path.GetFileName(originalName)}\" as \"{Path.GetFileName(newName)}\"");
                        }
                        else if (Directory.Exists(originalName) && !Directory.Exists(newName))
                        {
                            Unpacker.CopyEntireDirectory(new DirectoryInfo(originalName), new DirectoryInfo(newName));
                            Output.Log($"[INFO] Copied \"{Path.GetFileName(originalName)}\" as \"{Path.GetFileName(newName)}\"");
                        }
                        else
                            Output.Log($"[ERROR] Failed to copy \"{Path.GetFileName(originalName)}\" as \"{Path.GetFileName(newName)}\", file already exists");
                    }
                    Treeview_Project();
                }
                else
                    Output.Log($"[ERROR] Failed to copy \"{Path.GetFileName(originalName)}\", file or folder does not exist");
            }
        }

        private void Rename_Click(object sender, EventArgs e)
        {
            string originalName = treeView_Project.SelectedNode.Name;
            if (treeView_Project.SelectedNode != null)
            {
                string dir = Path.GetDirectoryName(originalName);
                string newName = "";
                RenameForm rename = new RenameForm(Path.GetFileNameWithoutExtension(originalName));
                var result = rename.ShowDialog();
                if (result == DialogResult.OK)
                {
                    newName = Path.Combine(dir, rename.RenameText) + Path.GetExtension(originalName);
                    if (File.Exists(originalName) && !File.Exists(newName))
                    {
                        File.Move(originalName, newName);
                        Output.Log($"[INFO] Renamed \"{Path.GetFileName(originalName)}\" to \"{Path.GetFileName(newName)}\"");
                    }
                    else if (Directory.Exists(originalName) && !Directory.Exists(newName))
                    {
                        Directory.Move(treeView_Project.SelectedNode.Name, newName);
                        Output.Log($"[INFO] Renamed \"{Path.GetFileName(originalName)}\" to \"{Path.GetFileName(newName)}\"");
                    }
                    else
                        Output.Log($"[ERROR] Failed to rename \"{Path.GetFileName(originalName)}\" to \"{Path.GetFileName(newName)}\", file already exists");
                    Treeview_Project();
                }
            }
        }

        private void RemoveFromProject_Click(object sender, EventArgs e)
        {
            if (treeView_Project.SelectedNode != null)
            {
                string file = treeView_Project.SelectedNode.Name;
                if (Directory.Exists(file))
                {
                    Directory.Delete(file, true);
                    Output.Log($"[INFO] Deleted directory and contents: {Path.GetFileName(file)}.");
                }
                else if (File.Exists(file))
                {
                    File.Delete(file);
                    Output.Log($"[INFO] Deleted file: {Path.GetFileName(file)}.");
                }
                else
                {
                    Output.Log($"[ERROR] Couldn't find file to delete: {Path.GetFileName(file)}.");
                    return;
                }
                Treeview_Project();
            }
            HideContextMenus();
        }

        /* Open/close right click treeview node context menus */
        private void ProjectNode_MouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ToolStripMenuItem_Copy.Visible = true;
                ToolStripMenuItem_Rename.Visible = true;
                ToolStripMenuItem_Remove.Visible = true;
                ToolStripMenuItem_ExpandProj.Visible = true;
                ToolStripMenuItem_CollapseProj.Visible = true;
                ToolStripMenuItem_New.Visible = true;
                ToolStripMenuItem_RepackAs.Visible = false;
                ToolStripMenuItem_Replace.Visible = true;
                ToolStripMenuItem_Unpack.Visible = false;
                ToolStripMenuItem_Compile.Visible = false;
                ToolStripMenuItem_Decompile.Visible = false;

                treeView_Project.SelectedNode = e.Node;
                // Hide add to project option if topmost two levels (Game/Archive) 
                // to prevent copying entire game/archive's worth of data
                if (treeView_Project.SelectedNode.Parent == null || treeView_Project.SelectedNode.Name.ToLower().EndsWith(".yml"))
                {
                    ToolStripMenuItem_Copy.Visible = false;
                    ToolStripMenuItem_Rename.Visible = false;
                    ToolStripMenuItem_Remove.Visible = false;
                }
                // Hide (de)compile, new, repack, replace & expand/collapse, unpack
                if (!Treeview.decompileTreeViewTypes.Any(x => x.Equals(Path.GetExtension(treeView_Project.SelectedNode.Name).ToLower())))
                    ToolStripMenuItem_Decompile.Visible = false;
                if (!Treeview.compileTreeViewTypes.Any(x => x.Equals(Path.GetExtension(treeView_Project.SelectedNode.Name).ToLower())))
                    ToolStripMenuItem_Compile.Visible = false;
                if (treeView_Project.SelectedNode.ImageIndex != 18)
                {
                    ToolStripMenuItem_ExpandProj.Visible = false;
                    ToolStripMenuItem_CollapseProj.Visible = false;
                    ToolStripMenuItem_New.Visible = false;
                    ToolStripMenuItem_RepackAs.Visible = false;
                }
                else
                    ToolStripMenuItem_Replace.Visible = false;
                if (!Treeview.unpackTreeViewTypes.Any(x => x.Equals(Path.GetExtension(treeView_Project.SelectedNode.Name).ToLower())))
                    ToolStripMenuItem_Unpack.Visible = false;
                contextMenuStrip_Project.Show(Cursor.Position);
            }
        }
        #endregion

        #region FormEvents
        /* Toggle file browser and log */
        private void ShowHide_Click(object sender, EventArgs e)
        {
            if (!collapsed)
            {
                tableLayoutPanel_Main.ColumnStyles[0].SizeType = SizeType.AutoSize;
                tableLayoutPanel_Main.HideColumns(new int[] { 0 });
                tableLayoutPanel_Workspace.HideRows(new int[] { 1 });
                metroSetButton_ShowHide.Text = "»";
                collapsed = true;
            }
            else
            {
                tableLayoutPanel_Main.ShowColumns(new int[] { 0 });
                tableLayoutPanel_Workspace.ShowRows(new int[] { 1 });
                tableLayoutPanel_Main.ColumnStyles[0].SizeType = SizeType.Percent;
                tableLayoutPanel_Main.ColumnStyles[0].Width = 28f;
                metroSetButton_ShowHide.Text = "«";
                collapsed = false;
            }
        }
        private void HideContextMenus()
        {
            contextMenuStrip_Project.Hide();
        }

        private void AmiiboSeries_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroSetComboBox_Amiibo.Items.Clear();
            metroSetComboBox_Amiibo.Items.Add("");

            string selected = "Animal Crossing";
            if (metroSetComboBox_AmiiboSeries.SelectedItem != null)
                selected = metroSetComboBox_AmiiboSeries.SelectedItem.ToString();

            foreach (var amiibo in Amiibos.Where(x => x.Item2.Equals(selected)))
                metroSetComboBox_Amiibo.Items.Add(amiibo.Item3 + " (" + amiibo.Item4 + ")");
            metroSetComboBox_Amiibo.SelectedIndex = 0;
        }

        private void Villager_SelectedIndexChanged(object sender, EventArgs e)
        {
            VillagerData villager = Villagers.List[metroSetComboBox_Villagers.SelectedIndex];
            // Name
            textBox_Name.Text = villager.Name;
            // Species
            metroSetComboBox_VillagerSpecies.SelectedIndex = metroSetComboBox_VillagerSpecies.Items.IndexOf(villager.Species);
            // ID
            numeric_VillagerID.Value = villager.ID;
            // TalkType
            if (villager.TalkType.Equals("Type 1"))
                metroSetRadioButton_TalkType1.Checked = true;
            else
                metroSetRadioButton_TalkType2.Checked = true;
            // Personality
            metroSetComboBox_Personality.SelectedIndex = metroSetComboBox_Personality.Items.IndexOf(villager.Personality);
            // Hobby
            metroSetComboBox_Hobby.SelectedIndex = metroSetComboBox_Hobby.Items.IndexOf(villager.Hobby);
            // Birth Month
            numeric_Month.Value = villager.BirthMonth;
            // Birth Day
            numeric_Day.Value = villager.BirthDay;
            // Amiibo
            if (villager.AmiiboSeries != "" && villager.Amiibo != "")
            {
                string amiiboName = villager.Amiibo.Replace(")", "").Replace(" (", "*");
                string amiiboType = amiiboName.Split('*')[1];
                amiiboName = amiiboName.Split('*')[0];

                var amiibo = Amiibos.First(x => x.Item2.Equals(villager.AmiiboSeries) && x.Item3.Equals(amiiboName) && x.Item4.Equals(amiiboType));
                metroSetComboBox_AmiiboSeries.SelectedIndex = metroSetComboBox_AmiiboSeries.Items.IndexOf(amiibo.Item2);
                metroSetComboBox_Amiibo.SelectedIndex = metroSetComboBox_Amiibo.Items.IndexOf(amiibo.Item3 + " (" + amiibo.Item4 + ")");
            }
            else
                metroSetComboBox_AmiiboSeries.SelectedIndex = 0;
            // Catchphrase
            textBox_Phrase.Text = villager.Catchphrase;
            // Clothes Type
            metroSetComboBox_ClothesType.SelectedIndex = metroSetComboBox_ClothesType.Items.IndexOf(villager.ClothesType);
            // Style
            metroSetComboBox_Style.SelectedIndex = metroSetComboBox_Style.Items.IndexOf(villager.Style);
            // Style 2
            metroSetComboBox_Style2.SelectedIndex = metroSetComboBox_Style2.Items.IndexOf(villager.Style2);
            // Unknown
            metroSetComboBox_Unknown1.SelectedIndex = metroSetComboBox_Unknown1.Items.IndexOf(villager.Unknown);
            // Social Type
            metroSetComboBox_SocialType.SelectedIndex = metroSetComboBox_SocialType.Items.IndexOf(villager.SocialType);
            // Sing Pause Type
            metroSetComboBox_SingPause.SelectedIndex = metroSetComboBox_SingPause.Items.IndexOf(villager.SingPauseType);
            // Sing Rhythm Type
            metroSetComboBox_SingRhythm.SelectedIndex = metroSetComboBox_SingRhythm.Items.IndexOf(villager.SingRhythmType);
            // Photo Item ID
            numeric_PhotoID.Value = villager.PhotoItemID;
            // Floor Type
            numeric_FloorType.Value = villager.FloorType;
            // Poster Item ID
            numeric_PosterID.Value = villager.PosterItemID;
            // Rain Hat Item ID
            numeric_RainHatID.Value = villager.RainHatItemID;
            // Rain Wear Item ID
            numeric_RainWearID.Value = villager.RainWearItemID;
            // Phone Pattern
            numeric_PhonePattern.Value = villager.PhonePattern;
            // Shirt Item ID
            numeric_ShirtID.Value = villager.ShirtItemID;
            // Umbrella Item ID
            numeric_UmbrellaID.Value = villager.UmbrellaItemID;
            // Fave Color
            metroSetComboBox_FaveColor.SelectedIndex = metroSetComboBox_FaveColor.Items.IndexOf(villager.FaveColor);
            // Fave Color 2
            metroSetComboBox_FaveColor2.SelectedIndex = metroSetComboBox_FaveColor2.Items.IndexOf(villager.FaveColor2);
            // Remake ID
            numeric_RemakeID.Value = villager.RemakeID;
            // Note Length
            numeric_NoteLength.Value = villager.NoteLength;
            // Village Melody
            metroSetComboBox_Melody.SelectedIndex = metroSetComboBox_Melody.Items.IndexOf(villager.VillageMelody);
            // Village Melody 2
            metroSetComboBox_Melody2.SelectedIndex = metroSetComboBox_Melody2.Items.IndexOf(villager.VillageMelody2);
            // NPC Color
            numeric_NPCColor.Value = villager.NPCColor;

            Output.Log($"[INFO] Showing Villager data in form: \"{villager.Name}\" ({Villagers.Species.First(x => x.Item2.Equals(villager.Species)).Item1}{villager.ID.ToString("00")})");

            // TODO: Show villager icon
            //UpdateIcon();
        }

        private void SaveVillager_Click(object sender, EventArgs e)
        {
            VillagerData villager = Villagers.List[metroSetComboBox_Villagers.SelectedIndex];
            // Name
            villager.Name = textBox_Name.Text;
            // Species
            villager.Species = metroSetComboBox_VillagerSpecies.SelectedItem.ToString();
            // ID
            villager.ID = Convert.ToInt32(numeric_VillagerID.Value);
            // TalkType
            if (metroSetRadioButton_TalkType1.Checked)
                villager.TalkType = "Type 1";
            else
                villager.TalkType = "Type 2";
            // Personality
            villager.Personality = metroSetComboBox_Personality.SelectedItem.ToString();
            // Hobby
            villager.Hobby = metroSetComboBox_Hobby.SelectedItem.ToString();
            // Birth Month
            villager.BirthMonth = Convert.ToInt32(numeric_Month.Value);
            // Birth Day
            villager.BirthDay = Convert.ToInt32(numeric_Day.Value);
            // Amiibo
            if (metroSetComboBox_Amiibo.SelectedItem.ToString() != "")
            {
                string amiiboName = metroSetComboBox_Amiibo.SelectedItem.ToString().Replace(")", "").Replace(" (", "*");
                string amiiboType = amiiboName.Split('*')[1];
                amiiboName = amiiboName.Split('*')[0];

                var amiibo = Amiibos.First(x => x.Item2.Equals(metroSetComboBox_AmiiboSeries.SelectedItem.ToString()) && x.Item3.Equals(amiiboName) && x.Item4.Equals(amiiboType));
                villager.AmiiboSeries = amiibo.Item2;
                villager.Amiibo = amiibo.Item3 + " (" + amiibo.Item4 + ")";
            }
            // Catchphrase
            villager.Catchphrase = textBox_Phrase.Text;
            // Clothes Type
            villager.ClothesType = metroSetComboBox_ClothesType.SelectedItem.ToString();
            // Style
            villager.Style = metroSetComboBox_Style.SelectedItem.ToString();
            // Style 2
            villager.Style2 = metroSetComboBox_Style2.SelectedItem.ToString();
            // Unknown
            villager.Unknown = metroSetComboBox_Unknown1.SelectedItem.ToString();
            // Social Type
            villager.SocialType = metroSetComboBox_SocialType.SelectedItem.ToString();
            // Sing Pause Type
            villager.SingPauseType = metroSetComboBox_SingPause.SelectedItem.ToString();
            // Sing Rhythm Type
            villager.SingRhythmType = metroSetComboBox_SingRhythm.SelectedItem.ToString();
            // Photo Item ID
            villager.PhotoItemID = Convert.ToInt32(numeric_PhotoID.Value);
            // Floor Type
            villager.FloorType = Convert.ToInt32(numeric_FloorType.Value);
            // Poster Item ID
            villager.PosterItemID = Convert.ToInt32(numeric_PosterID.Value);
            // Rain Hat Item ID
            villager.RainHatItemID = Convert.ToInt32(numeric_RainHatID.Value);
            // Rain Wear Item ID
            villager.RainWearItemID = Convert.ToInt32(numeric_RainWearID.Value);
            // Phone Pattern
            villager.PhonePattern = Convert.ToInt32(numeric_PhonePattern.Value);
            // Shirt Item ID
            villager.ShirtItemID = Convert.ToInt32(numeric_ShirtID.Value);
            // Umbrella Item ID
            villager.UmbrellaItemID = Convert.ToInt32(numeric_UmbrellaID.Value);
            // Fave Color
            villager.FaveColor = metroSetComboBox_FaveColor.SelectedItem.ToString();
            // Fave Color 2
            villager.FaveColor2 = metroSetComboBox_FaveColor2.SelectedItem.ToString();
            // Remake ID
            villager.RemakeID = Convert.ToInt32(numeric_RemakeID.Value);
            // Note Length
            villager.NoteLength = Convert.ToInt32(numeric_NoteLength.Value);
            // Village Melody
            villager.VillageMelody = metroSetComboBox_Melody.SelectedItem.ToString();
            // Village Melody 2
            villager.VillageMelody2 = metroSetComboBox_Melody2.SelectedItem.ToString();
            // NPC Color
            villager.NPCColor = Convert.ToInt32(numeric_NPCColor.Value);

            Villagers.List[metroSetComboBox_Villagers.SelectedIndex] = villager;
            string status = $"Saved changes to Villager: \"{villager.Name}\" ({Villagers.Species.First(x => x.Item2.Equals(villager.Species)).Item1}{villager.ID.ToString("00")})";
            Output.Log($"[INFO] {status}");
            MessageBox.Show(status, "Saved Villager Data");
            UpdateVillagerDropDown(metroSetComboBox_Villagers.SelectedIndex);
        }

        private void AddSpecies_Click(object sender, EventArgs e)
        {
            SpeciesAddForm species = new SpeciesAddForm();
            var result = species.ShowDialog();
            if (result == DialogResult.OK)
            {
                Classes.Villagers.Species.Add(new Tuple<string, string>(
                    species.SpeciesAbbreviation,
                    species.SpeciesName));
                metroSetComboBox_VillagerSpecies.Items.Clear();
                foreach (var race in Villagers.Species)
                    metroSetComboBox_VillagerSpecies.Items.Add(race.Item2);
                metroSetComboBox_VillagerSpecies.SelectedIndex = metroSetComboBox_VillagerSpecies.Items.IndexOf(species.SpeciesName);
                Output.Log($"[INFO] Added species: {species.SpeciesName} ({species.SpeciesAbbreviation}).");
            }
        }

        private void AddVillager_Click(object sender, EventArgs e)
        {
            VillagerData villager = new VillagerData();
            while (Villagers.List.Any(x => x.ID.Equals(villager.ID) && x.Species.Equals(villager.Species)))
            {
                villager.ID += 1;
                // TODO: Select another species if you hit the maximum (99)
            }
            Villagers.List.Add(villager);
            UpdateVillagerDropDown(metroSetComboBox_Villagers.Items.IndexOf($"{Villagers.Species.First(s => s.Item2.Equals(villager.Species)).Item1}{villager.ID.ToString("00")} {villager.Name}"));
            Output.Log($"[INFO] Added Villager: {villager.Name} ({Villagers.Species.First(s => s.Item2.Equals(villager.Species)).Item1}{villager.ID.ToString("00")}).");
        }

        private void RemoveVillager_Click(object sender, EventArgs e)
        {
            VillagerData villager = Villagers.List.First(x =>
                x.Species.Equals(metroSetComboBox_VillagerSpecies.SelectedItem.ToString()) &&
                x.ID.Equals(numeric_VillagerID.Value));
            Villagers.List.Remove(villager);
            // TODO: Select index nearest to current possible
            UpdateVillagerDropDown();
            Output.Log($"[INFO] Removed Villager: {villager.Name} ({Villagers.Species.First(s => s.Item2.Equals(villager.Species)).Item1}{villager.ID.ToString("00")}).");
        }
        #endregion

        #region Rendering
        /* Improve menustrip rendering for dark theme */
        ToolStripProfessionalRenderer r =
            new ToolStripProfessionalRenderer(new MyColorTable(Color.FromArgb(255, 20, 20, 20)));
        public class MyColorTable : ProfessionalColorTable
        {
            private Color menuItemSelectedColor;
            public MyColorTable(Color color) : base()
            {
                menuItemSelectedColor = color;
            }
            public override Color MenuItemSelected
            {
                get { return menuItemSelectedColor; }
            }
        }
        #endregion
    }

    /* Toggle TableLayoutPanel rows/columns that are set to autosize */
    public static class TableLayoutPanelExtensions
    {
        public static void HideRows(this TableLayoutPanel panel, params int[] rowNumbers)
        {
            foreach (Control c in panel.Controls)
                if (rowNumbers.Contains(panel.GetRow(c)))
                    c.Visible = false;
        }
        public static void ShowRows(this TableLayoutPanel panel, params int[] rowNumbers)
        {
            foreach (Control c in panel.Controls)
                if (rowNumbers.Contains(panel.GetRow(c)))
                    c.Visible = true;
        }
        public static void HideColumns(this TableLayoutPanel panel, params int[] colNumbers)
        {
            foreach (Control c in panel.Controls)
                if (colNumbers.Contains(panel.GetColumn(c)))
                    c.Visible = false;
        }
        public static void ShowColumns(this TableLayoutPanel panel, params int[] colNumbers)
        {
            foreach (Control c in panel.Controls)
                if (colNumbers.Contains(panel.GetColumn(c)))
                    c.Visible = true;
        }
    }
}
