﻿using MetroSet_UI.Controls;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace ACNHLab
{
    public partial class ACNHLab : MetroSet_UI.Forms.MetroSetForm
    {
        public static IntPtr assetPanelHandle;
        public static IntPtr assetEditorHandle;
        public static IntPtr scriptingPanelHandle;
        public static IntPtr scriptEditorHandle;
        public static int formWidth;
        public static int formHeight;
        public static string assetEditor = "";
        public static bool collapsed;
        public ACNHLab()
        {
            InitializeComponent();
            Program.status = new Status(this.richTextBox_Status);
            Program.status.Update("Create a new project or load an existing one to get started.");
            metroSetTabControl_Workspace.SelectedIndex = 0;
            ToolStripManager.Renderer = r;
            menuStrip_Main.Renderer = r;
            treeView_Project.ImageList = Treeview.treeViewImageList;
            scriptingPanelHandle = panel_Scripting.Handle;
            collapsed = false;
            #if DEBUG
            metroSetTabControl_Workspace.Controls.Add(new TabPage(Text = "Debug"));
            #endif
        }

        #region ToolstripOptions
        /* Toolstrip Options*/
        private void NewProject_Click(object sender, EventArgs e)
        {
            this.Text = $"ACNHLab v0.1";
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
                this.Text = $"ACNHLab v0.1 - {SettingsForm.settings.ProjectName}";
                Treeview_Project();
                saveProjectToolStripMenuItem.Enabled = true;
                Classes.Villagers.Load();
            }
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
                        Program.status.Update($"[INFO] Copying project files from \"{Path.GetFileNameWithoutExtension(originalProj)}\" to \"{Path.GetFileNameWithoutExtension(newProj)}\"");
                        // Copy all project files to new directory
                        Unpacker.CopyEntireDirectory(new DirectoryInfo(projDir), new DirectoryInfo(Path.GetDirectoryName(newProj)), true);
                        // Delete original project file copied with other project stuff
                        File.Delete(Path.Combine(Path.GetDirectoryName(newProj), Path.GetFileName(originalProj)));
                        // Save and reload new project
                        SettingsForm.SaveSettings();
                        LoadProject();
                    }
                    else
                        Program.status.Update($"[ERROR] Failed to save project as \"{newName}\", directory already exists");
                }
            }
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
                            Program.status.Update($"[INFO] Copied \"{Path.GetFileName(originalName)}\" as \"{Path.GetFileName(newName)}\"");
                        }
                        else if (Directory.Exists(originalName) && !Directory.Exists(newName))
                        {
                            Unpacker.CopyEntireDirectory(new DirectoryInfo(originalName), new DirectoryInfo(newName));
                            Program.status.Update($"[INFO] Copied \"{Path.GetFileName(originalName)}\" as \"{Path.GetFileName(newName)}\"");
                        }
                        else
                            Program.status.Update($"[ERROR] Failed to copy \"{Path.GetFileName(originalName)}\" as \"{Path.GetFileName(newName)}\", file already exists");
                    }
                    Treeview_Project();
                }
                else
                    Program.status.Update($"[ERROR] Failed to copy \"{Path.GetFileName(originalName)}\", file or folder does not exist");
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
                        Program.status.Update($"[INFO] Renamed \"{Path.GetFileName(originalName)}\" to \"{Path.GetFileName(newName)}\"");
                    }
                    else if (Directory.Exists(originalName) && !Directory.Exists(newName))
                    {
                        Directory.Move(treeView_Project.SelectedNode.Name, newName);
                        Program.status.Update($"[INFO] Renamed \"{Path.GetFileName(originalName)}\" to \"{Path.GetFileName(newName)}\"");
                    }
                    else
                        Program.status.Update($"[ERROR] Failed to rename \"{Path.GetFileName(originalName)}\" to \"{Path.GetFileName(newName)}\", file already exists");
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
                    Program.status.Update($"[INFO] Deleted directory and contents: {Path.GetFileName(file)}.");
                }
                else if (File.Exists(file))
                {
                    File.Delete(file);
                    Program.status.Update($"[INFO] Deleted file: {Path.GetFileName(file)}.");
                }
                else
                {
                    Program.status.Update($"[ERROR] Couldn't find file to delete: {Path.GetFileName(file)}.");
                    return;
                }
                Treeview_Project();
            }
            HideContextMenus();
        }

        private void ProjectNode_DoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {

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

        private void Workspace_SelectedTabChanged(object sender, EventArgs e)
        {
            if (metroSetTabControl_Workspace.SelectedTab.Text.Equals("Debug"))
            {
                metroSetTabControl_Workspace.SelectedTab.Controls.Clear();
                metroSetTabControl_Workspace.SelectedTab.Controls.Add(Classes.Bcsv.dataGridView1);
            }
                
        }
    }

    /* Append to Status Text from other classes and forms */
    public class Status
    {
        RichTextBox rtb;
        public Status(RichTextBox rtb)
        {
            this.rtb = rtb;
        }

        public void Update(string msg)
        {
            rtb.Text += "\n" + msg;
            rtb.SelectionStart = rtb.Text.Length;
            rtb.ScrollToCaret();
        }
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
