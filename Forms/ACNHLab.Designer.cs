﻿
using System.Drawing;

namespace ACNHLab
{
    partial class ACNHLab : MetroSet_UI.Forms.MetroSetForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACNHLab));
            this.tableLayoutPanel_Container = new System.Windows.Forms.TableLayoutPanel();
            this.metroSetProgressBar_Main = new MetroSet_UI.Controls.MetroSetProgressBar();
            this.styleManager = new MetroSet_UI.Components.StyleManager();
            this.tableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.metroSetTabControl_GameProject = new MetroSet_UI.Controls.MetroSetTabControl();
            this.tabPage_Project = new System.Windows.Forms.TabPage();
            this.treeView_Project = new System.Windows.Forms.TreeView();
            this.metroSetButton_ShowHide = new MetroSet_UI.Controls.MetroSetButton();
            this.panel_Workspace = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_Workspace = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBox_Status = new System.Windows.Forms.RichTextBox();
            this.panel_WorkspaceTabs = new System.Windows.Forms.Panel();
            this.metroSetTabControl_Workspace = new MetroSet_UI.Controls.MetroSetTabControl();
            this.tabPage_Villagers = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel_Villagers = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_VillagerList = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip_Villagers = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem_SaveVillager = new System.Windows.Forms.ToolStripMenuItem();
            this.metroSetComboBox_Villagers = new MetroSet_UI.Controls.MetroSetComboBox();
            this.panel_VillagerImg = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_VillagerAddRemove = new System.Windows.Forms.TableLayoutPanel();
            this.button_VillagerHouse = new System.Windows.Forms.Button();
            this.btn_RemoveVillager = new System.Windows.Forms.Button();
            this.btn_AddVillager = new System.Windows.Forms.Button();
            this.panel_VillagerParams = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_VillagerParams = new System.Windows.Forms.TableLayoutPanel();
            this.metroSetComboBox_AmiiboSeries = new MetroSet_UI.Controls.MetroSetComboBox();
            this.textBox_Phrase = new System.Windows.Forms.TextBox();
            this.metroSetComboBox_Amiibo = new MetroSet_UI.Controls.MetroSetComboBox();
            this.metroSetLabel_NPCColor = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel_Melody2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel_ShirtID = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel_Catchphrase = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel_AmiiboSeries = new MetroSet_UI.Controls.MetroSetLabel();
            this.tableLayoutPanel_Birthday = new System.Windows.Forms.TableLayoutPanel();
            this.numeric_Day = new System.Windows.Forms.NumericUpDown();
            this.numeric_Month = new System.Windows.Forms.NumericUpDown();
            this.metroSetLabel_Birthday = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetComboBox_Hobby = new MetroSet_UI.Controls.MetroSetComboBox();
            this.metroSetLabel_Hobby = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel_VillagerSpecies = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel_VillagerName = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel_VillagerID = new MetroSet_UI.Controls.MetroSetLabel();
            this.numeric_VillagerID = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel_VillagerSpeciesAdd = new System.Windows.Forms.TableLayoutPanel();
            this.button_AddSpecies = new System.Windows.Forms.Button();
            this.metroSetComboBox_VillagerSpecies = new MetroSet_UI.Controls.MetroSetComboBox();
            this.metroSetLabel_VillagerGender = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel_Personality = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetComboBox_Personality = new MetroSet_UI.Controls.MetroSetComboBox();
            this.tableLayoutPanel_VillagerGender = new System.Windows.Forms.TableLayoutPanel();
            this.metroSetRadioButton_TalkType2 = new MetroSet_UI.Controls.MetroSetRadioButton();
            this.metroSetRadioButton_TalkType1 = new MetroSet_UI.Controls.MetroSetRadioButton();
            this.metroSetLabel_ClothesType = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetComboBox_ClothesType = new MetroSet_UI.Controls.MetroSetComboBox();
            this.metroSetComboBox_Style = new MetroSet_UI.Controls.MetroSetComboBox();
            this.metroSetLabel_Style2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetComboBox_Style2 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.metroSetLabel_Unknown1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetComboBox_Unknown1 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.metroSetLabel_SocialType = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetComboBox_SocialType = new MetroSet_UI.Controls.MetroSetComboBox();
            this.metroSetComboBox_SingPause = new MetroSet_UI.Controls.MetroSetComboBox();
            this.metroSetLabel_SingPause = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetComboBox_SingRhythm = new MetroSet_UI.Controls.MetroSetComboBox();
            this.metroSetLabel_SingRhythm = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel_PhotoID = new MetroSet_UI.Controls.MetroSetLabel();
            this.numeric_PhotoID = new System.Windows.Forms.NumericUpDown();
            this.metroSetLabel_FloorType = new MetroSet_UI.Controls.MetroSetLabel();
            this.numeric_FloorType = new System.Windows.Forms.NumericUpDown();
            this.metroSetLabel_PosterID = new MetroSet_UI.Controls.MetroSetLabel();
            this.numeric_PosterID = new System.Windows.Forms.NumericUpDown();
            this.metroSetLabel_RainHatID = new MetroSet_UI.Controls.MetroSetLabel();
            this.numeric_RainHatID = new System.Windows.Forms.NumericUpDown();
            this.metroSetLabel_RainWearID = new MetroSet_UI.Controls.MetroSetLabel();
            this.numeric_RainWearID = new System.Windows.Forms.NumericUpDown();
            this.metroSetLabel_PhonePattern = new MetroSet_UI.Controls.MetroSetLabel();
            this.numeric_PhonePattern = new System.Windows.Forms.NumericUpDown();
            this.numeric_ShirtID = new System.Windows.Forms.NumericUpDown();
            this.metroSetLabel_UmbrellaID = new MetroSet_UI.Controls.MetroSetLabel();
            this.numeric_UmbrellaID = new System.Windows.Forms.NumericUpDown();
            this.metroSetComboBox_FaveColor = new MetroSet_UI.Controls.MetroSetComboBox();
            this.metroSetLabel_FaveColor = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetComboBox_FaveColor2 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.metroSetLabel_FaveColor2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel_RemakeID = new MetroSet_UI.Controls.MetroSetLabel();
            this.numeric_RemakeID = new System.Windows.Forms.NumericUpDown();
            this.metroSetLabel_NoteLength = new MetroSet_UI.Controls.MetroSetLabel();
            this.numeric_NoteLength = new System.Windows.Forms.NumericUpDown();
            this.metroSetComboBox_Melody = new MetroSet_UI.Controls.MetroSetComboBox();
            this.metroSetLabel_Melody = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetComboBox_Melody2 = new MetroSet_UI.Controls.MetroSetComboBox();
            this.numeric_NPCColor = new System.Windows.Forms.NumericUpDown();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.tabPage_Furniture = new System.Windows.Forms.TabPage();
            this.panel_Scripting = new System.Windows.Forms.Panel();
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeAllChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nHSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_Project = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_New = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_NewFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_NewFlow = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_NewMsg = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_NewTxt = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Decompile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Compile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Unpack = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_RepackAs = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_RepackPAC = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_RepackAFS = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_RepackAWB = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Replace = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Remove = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_OpenAt2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Rename = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_ExpandProj = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_CollapseProj = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel_Container.SuspendLayout();
            this.tableLayoutPanel_Main.SuspendLayout();
            this.metroSetTabControl_GameProject.SuspendLayout();
            this.tabPage_Project.SuspendLayout();
            this.panel_Workspace.SuspendLayout();
            this.tableLayoutPanel_Workspace.SuspendLayout();
            this.panel_WorkspaceTabs.SuspendLayout();
            this.metroSetTabControl_Workspace.SuspendLayout();
            this.tabPage_Villagers.SuspendLayout();
            this.tableLayoutPanel_Villagers.SuspendLayout();
            this.tableLayoutPanel_VillagerList.SuspendLayout();
            this.menuStrip_Villagers.SuspendLayout();
            this.tableLayoutPanel_VillagerAddRemove.SuspendLayout();
            this.panel_VillagerParams.SuspendLayout();
            this.tableLayoutPanel_VillagerParams.SuspendLayout();
            this.tableLayoutPanel_Birthday.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Day)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Month)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_VillagerID)).BeginInit();
            this.tableLayoutPanel_VillagerSpeciesAdd.SuspendLayout();
            this.tableLayoutPanel_VillagerGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_PhotoID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_FloorType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_PosterID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_RainHatID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_RainWearID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_PhonePattern)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_ShirtID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_UmbrellaID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_RemakeID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_NoteLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_NPCColor)).BeginInit();
            this.tabPage_Furniture.SuspendLayout();
            this.menuStrip_Main.SuspendLayout();
            this.contextMenuStrip_Project.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_Container
            // 
            this.tableLayoutPanel_Container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tableLayoutPanel_Container.ColumnCount = 1;
            this.tableLayoutPanel_Container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Container.Controls.Add(this.metroSetProgressBar_Main, 0, 2);
            this.tableLayoutPanel_Container.Controls.Add(this.tableLayoutPanel_Main, 0, 1);
            this.tableLayoutPanel_Container.Location = new System.Drawing.Point(-5, 3);
            this.tableLayoutPanel_Container.Name = "tableLayoutPanel_Container";
            this.tableLayoutPanel_Container.RowCount = 3;
            this.tableLayoutPanel_Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel_Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.tableLayoutPanel_Container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel_Container.Size = new System.Drawing.Size(953, 491);
            this.tableLayoutPanel_Container.TabIndex = 1;
            // 
            // metroSetProgressBar_Main
            // 
            this.metroSetProgressBar_Main.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.metroSetProgressBar_Main.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.metroSetProgressBar_Main.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.metroSetProgressBar_Main.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.metroSetProgressBar_Main.DisabledProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetProgressBar_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetProgressBar_Main.IsDerivedStyle = true;
            this.metroSetProgressBar_Main.Location = new System.Drawing.Point(0, 485);
            this.metroSetProgressBar_Main.Margin = new System.Windows.Forms.Padding(0);
            this.metroSetProgressBar_Main.Maximum = 100;
            this.metroSetProgressBar_Main.Minimum = 0;
            this.metroSetProgressBar_Main.Name = "metroSetProgressBar_Main";
            this.metroSetProgressBar_Main.Orientation = MetroSet_UI.Enums.ProgressOrientation.Horizontal;
            this.metroSetProgressBar_Main.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetProgressBar_Main.Size = new System.Drawing.Size(953, 6);
            this.metroSetProgressBar_Main.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetProgressBar_Main.StyleManager = this.styleManager;
            this.metroSetProgressBar_Main.TabIndex = 1;
            this.metroSetProgressBar_Main.ThemeAuthor = "ShrineFox";
            this.metroSetProgressBar_Main.ThemeName = "MetroDarkBlue";
            this.metroSetProgressBar_Main.Value = 0;
            // 
            // styleManager
            // 
            this.styleManager.CustomTheme = "C:\\Users\\ryans\\Documents\\GitHub\\ACNHLab\\ThemeFile.xml";
            this.styleManager.MetroForm = this;
            this.styleManager.Style = MetroSet_UI.Enums.Style.Dark;
            this.styleManager.ThemeAuthor = "ShrineFox";
            this.styleManager.ThemeName = "MetroDarkBlue";
            // 
            // tableLayoutPanel_Main
            // 
            this.tableLayoutPanel_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tableLayoutPanel_Main.ColumnCount = 3;
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel_Main.Controls.Add(this.metroSetTabControl_GameProject, 0, 0);
            this.tableLayoutPanel_Main.Controls.Add(this.metroSetButton_ShowHide, 1, 0);
            this.tableLayoutPanel_Main.Controls.Add(this.panel_Workspace, 2, 0);
            this.tableLayoutPanel_Main.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
            this.tableLayoutPanel_Main.RowCount = 1;
            this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Main.Size = new System.Drawing.Size(947, 455);
            this.tableLayoutPanel_Main.TabIndex = 3;
            // 
            // metroSetTabControl_GameProject
            // 
            this.metroSetTabControl_GameProject.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.metroSetTabControl_GameProject.AnimateTime = 200;
            this.metroSetTabControl_GameProject.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetTabControl_GameProject.Controls.Add(this.tabPage_Project);
            this.metroSetTabControl_GameProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroSetTabControl_GameProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetTabControl_GameProject.HotTrack = true;
            this.metroSetTabControl_GameProject.IsDerivedStyle = true;
            this.metroSetTabControl_GameProject.ItemSize = new System.Drawing.Size(100, 38);
            this.metroSetTabControl_GameProject.Location = new System.Drawing.Point(3, 3);
            this.metroSetTabControl_GameProject.Name = "metroSetTabControl_GameProject";
            this.metroSetTabControl_GameProject.SelectedIndex = 0;
            this.metroSetTabControl_GameProject.SelectedTextColor = System.Drawing.Color.White;
            this.metroSetTabControl_GameProject.Size = new System.Drawing.Size(259, 449);
            this.metroSetTabControl_GameProject.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroSetTabControl_GameProject.Speed = 50;
            this.metroSetTabControl_GameProject.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetTabControl_GameProject.StyleManager = null;
            this.metroSetTabControl_GameProject.TabIndex = 2;
            this.metroSetTabControl_GameProject.ThemeAuthor = "Narwin";
            this.metroSetTabControl_GameProject.ThemeName = "MetroDark";
            this.metroSetTabControl_GameProject.UnselectedTextColor = System.Drawing.Color.Gray;
            this.metroSetTabControl_GameProject.UseAnimation = false;
            // 
            // tabPage_Project
            // 
            this.tabPage_Project.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tabPage_Project.Controls.Add(this.treeView_Project);
            this.tabPage_Project.Location = new System.Drawing.Point(4, 42);
            this.tabPage_Project.Name = "tabPage_Project";
            this.tabPage_Project.Size = new System.Drawing.Size(251, 403);
            this.tabPage_Project.TabIndex = 1;
            this.tabPage_Project.Text = "Project";
            // 
            // treeView_Project
            // 
            this.treeView_Project.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.treeView_Project.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView_Project.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_Project.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.treeView_Project.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.treeView_Project.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.treeView_Project.Location = new System.Drawing.Point(0, 0);
            this.treeView_Project.Name = "treeView_Project";
            this.treeView_Project.Size = new System.Drawing.Size(251, 403);
            this.treeView_Project.TabIndex = 1;
            this.treeView_Project.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ProjectNode_MouseClick);
            // 
            // metroSetButton_ShowHide
            // 
            this.metroSetButton_ShowHide.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.metroSetButton_ShowHide.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.metroSetButton_ShowHide.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton_ShowHide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetButton_ShowHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.metroSetButton_ShowHide.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetButton_ShowHide.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetButton_ShowHide.HoverTextColor = System.Drawing.Color.Silver;
            this.metroSetButton_ShowHide.IsDerivedStyle = true;
            this.metroSetButton_ShowHide.Location = new System.Drawing.Point(268, 3);
            this.metroSetButton_ShowHide.Name = "metroSetButton_ShowHide";
            this.metroSetButton_ShowHide.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetButton_ShowHide.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetButton_ShowHide.NormalTextColor = System.Drawing.Color.Gray;
            this.metroSetButton_ShowHide.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetButton_ShowHide.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetButton_ShowHide.PressTextColor = System.Drawing.Color.Silver;
            this.metroSetButton_ShowHide.Size = new System.Drawing.Size(12, 449);
            this.metroSetButton_ShowHide.Style = MetroSet_UI.Enums.Style.Custom;
            this.metroSetButton_ShowHide.StyleManager = null;
            this.metroSetButton_ShowHide.TabIndex = 3;
            this.metroSetButton_ShowHide.Text = "«";
            this.metroSetButton_ShowHide.ThemeAuthor = "Narwin";
            this.metroSetButton_ShowHide.ThemeName = "MetroDark";
            this.metroSetButton_ShowHide.Click += new System.EventHandler(this.ShowHide_Click);
            // 
            // panel_Workspace
            // 
            this.panel_Workspace.Controls.Add(this.tableLayoutPanel_Workspace);
            this.panel_Workspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Workspace.Location = new System.Drawing.Point(286, 3);
            this.panel_Workspace.Name = "panel_Workspace";
            this.panel_Workspace.Size = new System.Drawing.Size(658, 449);
            this.panel_Workspace.TabIndex = 4;
            // 
            // tableLayoutPanel_Workspace
            // 
            this.tableLayoutPanel_Workspace.ColumnCount = 1;
            this.tableLayoutPanel_Workspace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Workspace.Controls.Add(this.richTextBox_Status, 0, 1);
            this.tableLayoutPanel_Workspace.Controls.Add(this.panel_WorkspaceTabs, 0, 0);
            this.tableLayoutPanel_Workspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Workspace.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Workspace.Name = "tableLayoutPanel_Workspace";
            this.tableLayoutPanel_Workspace.RowCount = 2;
            this.tableLayoutPanel_Workspace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel_Workspace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_Workspace.Size = new System.Drawing.Size(658, 449);
            this.tableLayoutPanel_Workspace.TabIndex = 1;
            // 
            // richTextBox_Status
            // 
            this.richTextBox_Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.richTextBox_Status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.richTextBox_Status.ForeColor = System.Drawing.Color.DarkGray;
            this.richTextBox_Status.Location = new System.Drawing.Point(3, 362);
            this.richTextBox_Status.Name = "richTextBox_Status";
            this.richTextBox_Status.ReadOnly = true;
            this.richTextBox_Status.Size = new System.Drawing.Size(652, 84);
            this.richTextBox_Status.TabIndex = 2;
            this.richTextBox_Status.Text = "Welcome to ACNHLab!\nCreate a new project or load an existing one to get started.\n" +
    "";
            // 
            // panel_WorkspaceTabs
            // 
            this.panel_WorkspaceTabs.AutoScroll = true;
            this.panel_WorkspaceTabs.Controls.Add(this.metroSetTabControl_Workspace);
            this.panel_WorkspaceTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_WorkspaceTabs.Location = new System.Drawing.Point(3, 3);
            this.panel_WorkspaceTabs.Name = "panel_WorkspaceTabs";
            this.panel_WorkspaceTabs.Size = new System.Drawing.Size(652, 353);
            this.panel_WorkspaceTabs.TabIndex = 3;
            // 
            // metroSetTabControl_Workspace
            // 
            this.metroSetTabControl_Workspace.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.metroSetTabControl_Workspace.AnimateTime = 100;
            this.metroSetTabControl_Workspace.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetTabControl_Workspace.Controls.Add(this.tabPage_Villagers);
            this.metroSetTabControl_Workspace.Controls.Add(this.tabPage_Furniture);
            this.metroSetTabControl_Workspace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroSetTabControl_Workspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetTabControl_Workspace.HotTrack = true;
            this.metroSetTabControl_Workspace.IsDerivedStyle = true;
            this.metroSetTabControl_Workspace.ItemSize = new System.Drawing.Size(100, 38);
            this.metroSetTabControl_Workspace.Location = new System.Drawing.Point(0, 0);
            this.metroSetTabControl_Workspace.Name = "metroSetTabControl_Workspace";
            this.metroSetTabControl_Workspace.SelectedIndex = 0;
            this.metroSetTabControl_Workspace.SelectedTextColor = System.Drawing.Color.White;
            this.metroSetTabControl_Workspace.Size = new System.Drawing.Size(652, 353);
            this.metroSetTabControl_Workspace.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroSetTabControl_Workspace.Speed = 200;
            this.metroSetTabControl_Workspace.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetTabControl_Workspace.StyleManager = null;
            this.metroSetTabControl_Workspace.TabIndex = 2;
            this.metroSetTabControl_Workspace.TabStyle = MetroSet_UI.Enums.TabStyle.Style2;
            this.metroSetTabControl_Workspace.ThemeAuthor = "Narwin";
            this.metroSetTabControl_Workspace.ThemeName = "MetroDark";
            this.metroSetTabControl_Workspace.UnselectedTextColor = System.Drawing.Color.Gray;
            this.metroSetTabControl_Workspace.UseAnimation = false;
            // 
            // tabPage_Villagers
            // 
            this.tabPage_Villagers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tabPage_Villagers.Controls.Add(this.tableLayoutPanel_Villagers);
            this.tabPage_Villagers.Location = new System.Drawing.Point(4, 42);
            this.tabPage_Villagers.Name = "tabPage_Villagers";
            this.tabPage_Villagers.Size = new System.Drawing.Size(644, 307);
            this.tabPage_Villagers.TabIndex = 0;
            this.tabPage_Villagers.Text = "Villagers";
            // 
            // tableLayoutPanel_Villagers
            // 
            this.tableLayoutPanel_Villagers.AutoScroll = true;
            this.tableLayoutPanel_Villagers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel_Villagers.ColumnCount = 2;
            this.tableLayoutPanel_Villagers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel_Villagers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel_Villagers.Controls.Add(this.tableLayoutPanel_VillagerList, 0, 0);
            this.tableLayoutPanel_Villagers.Controls.Add(this.panel_VillagerParams, 1, 0);
            this.tableLayoutPanel_Villagers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Villagers.Enabled = false;
            this.tableLayoutPanel_Villagers.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_Villagers.Name = "tableLayoutPanel_Villagers";
            this.tableLayoutPanel_Villagers.RowCount = 1;
            this.tableLayoutPanel_Villagers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Villagers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 307F));
            this.tableLayoutPanel_Villagers.Size = new System.Drawing.Size(644, 307);
            this.tableLayoutPanel_Villagers.TabIndex = 0;
            // 
            // tableLayoutPanel_VillagerList
            // 
            this.tableLayoutPanel_VillagerList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_VillagerList.AutoSize = true;
            this.tableLayoutPanel_VillagerList.ColumnCount = 1;
            this.tableLayoutPanel_VillagerList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_VillagerList.Controls.Add(this.menuStrip_Villagers, 0, 0);
            this.tableLayoutPanel_VillagerList.Controls.Add(this.metroSetComboBox_Villagers, 0, 2);
            this.tableLayoutPanel_VillagerList.Controls.Add(this.panel_VillagerImg, 0, 1);
            this.tableLayoutPanel_VillagerList.Controls.Add(this.tableLayoutPanel_VillagerAddRemove, 0, 3);
            this.tableLayoutPanel_VillagerList.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_VillagerList.Name = "tableLayoutPanel_VillagerList";
            this.tableLayoutPanel_VillagerList.RowCount = 4;
            this.tableLayoutPanel_VillagerList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel_VillagerList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.707F));
            this.tableLayoutPanel_VillagerList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.57318F));
            this.tableLayoutPanel_VillagerList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.71982F));
            this.tableLayoutPanel_VillagerList.Size = new System.Drawing.Size(251, 301);
            this.tableLayoutPanel_VillagerList.TabIndex = 0;
            // 
            // menuStrip_Villagers
            // 
            this.menuStrip_Villagers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.menuStrip_Villagers.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip_Villagers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_Villagers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem_SaveVillager});
            this.menuStrip_Villagers.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Villagers.Name = "menuStrip_Villagers";
            this.menuStrip_Villagers.Size = new System.Drawing.Size(251, 33);
            this.menuStrip_Villagers.TabIndex = 5;
            this.menuStrip_Villagers.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem_SaveVillager
            // 
            this.saveToolStripMenuItem_SaveVillager.ForeColor = System.Drawing.Color.Silver;
            this.saveToolStripMenuItem_SaveVillager.Name = "saveToolStripMenuItem_SaveVillager";
            this.saveToolStripMenuItem_SaveVillager.Size = new System.Drawing.Size(138, 29);
            this.saveToolStripMenuItem_SaveVillager.Text = "Save Changes";
            this.saveToolStripMenuItem_SaveVillager.Click += new System.EventHandler(this.SaveVillager_Click);
            // 
            // metroSetComboBox_Villagers
            // 
            this.metroSetComboBox_Villagers.AllowDrop = true;
            this.metroSetComboBox_Villagers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetComboBox_Villagers.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetComboBox_Villagers.BackColor = System.Drawing.Color.Transparent;
            this.metroSetComboBox_Villagers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.metroSetComboBox_Villagers.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetComboBox_Villagers.CausesValidation = false;
            this.metroSetComboBox_Villagers.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.metroSetComboBox_Villagers.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetComboBox_Villagers.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetComboBox_Villagers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroSetComboBox_Villagers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroSetComboBox_Villagers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.metroSetComboBox_Villagers.FormattingEnabled = true;
            this.metroSetComboBox_Villagers.IsDerivedStyle = true;
            this.metroSetComboBox_Villagers.ItemHeight = 20;
            this.metroSetComboBox_Villagers.Location = new System.Drawing.Point(3, 231);
            this.metroSetComboBox_Villagers.Name = "metroSetComboBox_Villagers";
            this.metroSetComboBox_Villagers.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetComboBox_Villagers.SelectedItemForeColor = System.Drawing.Color.White;
            this.metroSetComboBox_Villagers.Size = new System.Drawing.Size(245, 26);
            this.metroSetComboBox_Villagers.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetComboBox_Villagers.StyleManager = null;
            this.metroSetComboBox_Villagers.TabIndex = 0;
            this.metroSetComboBox_Villagers.ThemeAuthor = "Narwin";
            this.metroSetComboBox_Villagers.ThemeName = "MetroDark";
            this.metroSetComboBox_Villagers.SelectedIndexChanged += new System.EventHandler(this.Villager_SelectedIndexChanged);
            // 
            // panel_VillagerImg
            // 
            this.panel_VillagerImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_VillagerImg.Location = new System.Drawing.Point(3, 38);
            this.panel_VillagerImg.Name = "panel_VillagerImg";
            this.panel_VillagerImg.Size = new System.Drawing.Size(245, 187);
            this.panel_VillagerImg.TabIndex = 1;
            // 
            // tableLayoutPanel_VillagerAddRemove
            // 
            this.tableLayoutPanel_VillagerAddRemove.ColumnCount = 3;
            this.tableLayoutPanel_VillagerAddRemove.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_VillagerAddRemove.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_VillagerAddRemove.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_VillagerAddRemove.Controls.Add(this.button_VillagerHouse, 0, 0);
            this.tableLayoutPanel_VillagerAddRemove.Controls.Add(this.btn_RemoveVillager, 1, 0);
            this.tableLayoutPanel_VillagerAddRemove.Controls.Add(this.btn_AddVillager, 0, 0);
            this.tableLayoutPanel_VillagerAddRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_VillagerAddRemove.Location = new System.Drawing.Point(3, 264);
            this.tableLayoutPanel_VillagerAddRemove.Name = "tableLayoutPanel_VillagerAddRemove";
            this.tableLayoutPanel_VillagerAddRemove.RowCount = 1;
            this.tableLayoutPanel_VillagerAddRemove.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_VillagerAddRemove.Size = new System.Drawing.Size(245, 34);
            this.tableLayoutPanel_VillagerAddRemove.TabIndex = 2;
            // 
            // button_VillagerHouse
            // 
            this.button_VillagerHouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_VillagerHouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_VillagerHouse.Enabled = false;
            this.button_VillagerHouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_VillagerHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.button_VillagerHouse.ForeColor = System.Drawing.Color.Silver;
            this.button_VillagerHouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_VillagerHouse.Location = new System.Drawing.Point(84, 3);
            this.button_VillagerHouse.Name = "button_VillagerHouse";
            this.button_VillagerHouse.Size = new System.Drawing.Size(75, 28);
            this.button_VillagerHouse.TabIndex = 48;
            this.button_VillagerHouse.Text = "Home";
            this.button_VillagerHouse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_VillagerHouse.UseVisualStyleBackColor = false;
            // 
            // btn_RemoveVillager
            // 
            this.btn_RemoveVillager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_RemoveVillager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_RemoveVillager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemoveVillager.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btn_RemoveVillager.ForeColor = System.Drawing.Color.Silver;
            this.btn_RemoveVillager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RemoveVillager.Location = new System.Drawing.Point(165, 3);
            this.btn_RemoveVillager.Name = "btn_RemoveVillager";
            this.btn_RemoveVillager.Size = new System.Drawing.Size(77, 28);
            this.btn_RemoveVillager.TabIndex = 1;
            this.btn_RemoveVillager.Text = "Delete";
            this.btn_RemoveVillager.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_RemoveVillager.UseVisualStyleBackColor = false;
            this.btn_RemoveVillager.Click += new System.EventHandler(this.RemoveVillager_Click);
            // 
            // btn_AddVillager
            // 
            this.btn_AddVillager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_AddVillager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_AddVillager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddVillager.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btn_AddVillager.ForeColor = System.Drawing.Color.Silver;
            this.btn_AddVillager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddVillager.Location = new System.Drawing.Point(3, 3);
            this.btn_AddVillager.Name = "btn_AddVillager";
            this.btn_AddVillager.Size = new System.Drawing.Size(75, 28);
            this.btn_AddVillager.TabIndex = 0;
            this.btn_AddVillager.Text = "Add  ";
            this.btn_AddVillager.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AddVillager.UseVisualStyleBackColor = false;
            this.btn_AddVillager.Click += new System.EventHandler(this.AddVillager_Click);
            // 
            // panel_VillagerParams
            // 
            this.panel_VillagerParams.AutoScroll = true;
            this.panel_VillagerParams.Controls.Add(this.tableLayoutPanel_VillagerParams);
            this.panel_VillagerParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_VillagerParams.Location = new System.Drawing.Point(260, 3);
            this.panel_VillagerParams.Name = "panel_VillagerParams";
            this.panel_VillagerParams.Size = new System.Drawing.Size(381, 301);
            this.panel_VillagerParams.TabIndex = 1;
            // 
            // tableLayoutPanel_VillagerParams
            // 
            this.tableLayoutPanel_VillagerParams.AutoSize = true;
            this.tableLayoutPanel_VillagerParams.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel_VillagerParams.ColumnCount = 2;
            this.tableLayoutPanel_VillagerParams.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel_VillagerParams.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetComboBox_AmiiboSeries, 1, 7);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.textBox_Phrase, 1, 9);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetComboBox_Amiibo, 1, 8);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetLabel_NPCColor, 0, 31);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetLabel_Melody2, 0, 30);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetLabel_ShirtID, 0, 23);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetLabel1, 0, 11);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetLabel_Catchphrase, 0, 9);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetLabel_AmiiboSeries, 0, 7);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.tableLayoutPanel_Birthday, 1, 6);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetLabel_Birthday, 0, 6);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetComboBox_Hobby, 1, 5);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetLabel_Hobby, 0, 5);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetLabel_VillagerSpecies, 0, 1);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetLabel_VillagerName, 0, 0);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetLabel_VillagerID, 0, 2);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.numeric_VillagerID, 1, 2);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.tableLayoutPanel_VillagerSpeciesAdd, 1, 1);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetLabel_VillagerGender, 0, 3);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetLabel_Personality, 0, 4);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetComboBox_Personality, 1, 4);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.tableLayoutPanel_VillagerGender, 1, 3);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetLabel_ClothesType, 0, 10);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetComboBox_ClothesType, 1, 10);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetComboBox_Style, 1, 11);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetLabel_Style2, 0, 12);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetComboBox_Style2, 1, 12);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetLabel_Unknown1, 0, 13);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetComboBox_Unknown1, 1, 13);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetLabel_SocialType, 0, 14);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetComboBox_SocialType, 1, 14);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetComboBox_SingPause, 1, 15);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetLabel_SingPause, 0, 15);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetComboBox_SingRhythm, 1, 16);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetLabel_SingRhythm, 0, 16);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetLabel_PhotoID, 0, 17);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.numeric_PhotoID, 1, 17);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetLabel_FloorType, 0, 18);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.numeric_FloorType, 1, 18);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetLabel_PosterID, 0, 19);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.numeric_PosterID, 1, 19);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetLabel_RainHatID, 0, 20);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.numeric_RainHatID, 1, 20);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetLabel_RainWearID, 0, 21);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.numeric_RainWearID, 1, 21);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetLabel_PhonePattern, 0, 22);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.numeric_PhonePattern, 1, 22);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.numeric_ShirtID, 1, 23);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetLabel_UmbrellaID, 0, 24);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.numeric_UmbrellaID, 1, 24);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetComboBox_FaveColor, 1, 25);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetLabel_FaveColor, 0, 25);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetComboBox_FaveColor2, 1, 26);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetLabel_FaveColor2, 0, 26);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetLabel_RemakeID, 0, 27);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.numeric_RemakeID, 1, 27);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetLabel_NoteLength, 0, 28);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.numeric_NoteLength, 1, 28);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetComboBox_Melody, 1, 29);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetLabel_Melody, 0, 29);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetComboBox_Melody2, 1, 30);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.numeric_NPCColor, 1, 31);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.textBox_Name, 1, 0);
            this.tableLayoutPanel_VillagerParams.Controls.Add(this.metroSetLabel2, 0, 8);
            this.tableLayoutPanel_VillagerParams.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel_VillagerParams.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_VillagerParams.Name = "tableLayoutPanel_VillagerParams";
            this.tableLayoutPanel_VillagerParams.RowCount = 32;
            this.tableLayoutPanel_VillagerParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_VillagerParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_VillagerParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_VillagerParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_VillagerParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_VillagerParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_VillagerParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_VillagerParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_VillagerParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_VillagerParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_VillagerParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_VillagerParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_VillagerParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_VillagerParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_VillagerParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_VillagerParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_VillagerParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_VillagerParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_VillagerParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_VillagerParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_VillagerParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_VillagerParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_VillagerParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_VillagerParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_VillagerParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_VillagerParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_VillagerParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_VillagerParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_VillagerParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_VillagerParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_VillagerParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_VillagerParams.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel_VillagerParams.Size = new System.Drawing.Size(355, 1280);
            this.tableLayoutPanel_VillagerParams.TabIndex = 2;
            // 
            // metroSetComboBox_AmiiboSeries
            // 
            this.metroSetComboBox_AmiiboSeries.AllowDrop = true;
            this.metroSetComboBox_AmiiboSeries.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetComboBox_AmiiboSeries.BackColor = System.Drawing.Color.Transparent;
            this.metroSetComboBox_AmiiboSeries.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.metroSetComboBox_AmiiboSeries.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetComboBox_AmiiboSeries.CausesValidation = false;
            this.metroSetComboBox_AmiiboSeries.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.metroSetComboBox_AmiiboSeries.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetComboBox_AmiiboSeries.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetComboBox_AmiiboSeries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetComboBox_AmiiboSeries.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroSetComboBox_AmiiboSeries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroSetComboBox_AmiiboSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.metroSetComboBox_AmiiboSeries.FormattingEnabled = true;
            this.metroSetComboBox_AmiiboSeries.IsDerivedStyle = true;
            this.metroSetComboBox_AmiiboSeries.ItemHeight = 20;
            this.metroSetComboBox_AmiiboSeries.Location = new System.Drawing.Point(109, 283);
            this.metroSetComboBox_AmiiboSeries.Name = "metroSetComboBox_AmiiboSeries";
            this.metroSetComboBox_AmiiboSeries.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetComboBox_AmiiboSeries.SelectedItemForeColor = System.Drawing.Color.White;
            this.metroSetComboBox_AmiiboSeries.Size = new System.Drawing.Size(243, 26);
            this.metroSetComboBox_AmiiboSeries.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetComboBox_AmiiboSeries.StyleManager = null;
            this.metroSetComboBox_AmiiboSeries.TabIndex = 98;
            this.metroSetComboBox_AmiiboSeries.ThemeAuthor = "Narwin";
            this.metroSetComboBox_AmiiboSeries.ThemeName = "MetroDark";
            this.metroSetComboBox_AmiiboSeries.SelectedIndexChanged += new System.EventHandler(this.AmiiboSeries_SelectedIndexChanged);
            // 
            // textBox_Phrase
            // 
            this.textBox_Phrase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox_Phrase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Phrase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Phrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox_Phrase.ForeColor = System.Drawing.Color.Silver;
            this.textBox_Phrase.Location = new System.Drawing.Point(109, 363);
            this.textBox_Phrase.Name = "textBox_Phrase";
            this.textBox_Phrase.Size = new System.Drawing.Size(243, 32);
            this.textBox_Phrase.TabIndex = 96;
            // 
            // metroSetComboBox_Amiibo
            // 
            this.metroSetComboBox_Amiibo.AllowDrop = true;
            this.metroSetComboBox_Amiibo.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetComboBox_Amiibo.BackColor = System.Drawing.Color.Transparent;
            this.metroSetComboBox_Amiibo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.metroSetComboBox_Amiibo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetComboBox_Amiibo.CausesValidation = false;
            this.metroSetComboBox_Amiibo.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.metroSetComboBox_Amiibo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetComboBox_Amiibo.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetComboBox_Amiibo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetComboBox_Amiibo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroSetComboBox_Amiibo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroSetComboBox_Amiibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.metroSetComboBox_Amiibo.FormattingEnabled = true;
            this.metroSetComboBox_Amiibo.IsDerivedStyle = true;
            this.metroSetComboBox_Amiibo.ItemHeight = 20;
            this.metroSetComboBox_Amiibo.Location = new System.Drawing.Point(109, 323);
            this.metroSetComboBox_Amiibo.Name = "metroSetComboBox_Amiibo";
            this.metroSetComboBox_Amiibo.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetComboBox_Amiibo.SelectedItemForeColor = System.Drawing.Color.White;
            this.metroSetComboBox_Amiibo.Size = new System.Drawing.Size(243, 26);
            this.metroSetComboBox_Amiibo.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetComboBox_Amiibo.StyleManager = null;
            this.metroSetComboBox_Amiibo.TabIndex = 33;
            this.metroSetComboBox_Amiibo.ThemeAuthor = "Narwin";
            this.metroSetComboBox_Amiibo.ThemeName = "MetroDark";
            // 
            // metroSetLabel_NPCColor
            // 
            this.metroSetLabel_NPCColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetLabel_NPCColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.metroSetLabel_NPCColor.IsDerivedStyle = true;
            this.metroSetLabel_NPCColor.Location = new System.Drawing.Point(3, 1240);
            this.metroSetLabel_NPCColor.Name = "metroSetLabel_NPCColor";
            this.metroSetLabel_NPCColor.Size = new System.Drawing.Size(100, 40);
            this.metroSetLabel_NPCColor.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel_NPCColor.StyleManager = null;
            this.metroSetLabel_NPCColor.TabIndex = 93;
            this.metroSetLabel_NPCColor.Text = "NPC Color:";
            this.metroSetLabel_NPCColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel_NPCColor.ThemeAuthor = "Narwin";
            this.metroSetLabel_NPCColor.ThemeName = "MetroDark";
            // 
            // metroSetLabel_Melody2
            // 
            this.metroSetLabel_Melody2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetLabel_Melody2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.metroSetLabel_Melody2.IsDerivedStyle = true;
            this.metroSetLabel_Melody2.Location = new System.Drawing.Point(3, 1200);
            this.metroSetLabel_Melody2.Name = "metroSetLabel_Melody2";
            this.metroSetLabel_Melody2.Size = new System.Drawing.Size(100, 40);
            this.metroSetLabel_Melody2.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel_Melody2.StyleManager = null;
            this.metroSetLabel_Melody2.TabIndex = 92;
            this.metroSetLabel_Melody2.Text = "Melody 2:";
            this.metroSetLabel_Melody2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel_Melody2.ThemeAuthor = "Narwin";
            this.metroSetLabel_Melody2.ThemeName = "MetroDark";
            // 
            // metroSetLabel_ShirtID
            // 
            this.metroSetLabel_ShirtID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetLabel_ShirtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel_ShirtID.IsDerivedStyle = true;
            this.metroSetLabel_ShirtID.Location = new System.Drawing.Point(3, 920);
            this.metroSetLabel_ShirtID.Name = "metroSetLabel_ShirtID";
            this.metroSetLabel_ShirtID.Size = new System.Drawing.Size(100, 40);
            this.metroSetLabel_ShirtID.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel_ShirtID.StyleManager = null;
            this.metroSetLabel_ShirtID.TabIndex = 77;
            this.metroSetLabel_ShirtID.Text = "Shirt ID:";
            this.metroSetLabel_ShirtID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel_ShirtID.ThemeAuthor = "Narwin";
            this.metroSetLabel_ShirtID.ThemeName = "MetroDark";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(3, 440);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(100, 40);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 53;
            this.metroSetLabel1.Text = "Style:";
            this.metroSetLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroDark";
            // 
            // metroSetLabel_Catchphrase
            // 
            this.metroSetLabel_Catchphrase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetLabel_Catchphrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel_Catchphrase.IsDerivedStyle = true;
            this.metroSetLabel_Catchphrase.Location = new System.Drawing.Point(3, 360);
            this.metroSetLabel_Catchphrase.Name = "metroSetLabel_Catchphrase";
            this.metroSetLabel_Catchphrase.Size = new System.Drawing.Size(100, 40);
            this.metroSetLabel_Catchphrase.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel_Catchphrase.StyleManager = null;
            this.metroSetLabel_Catchphrase.TabIndex = 46;
            this.metroSetLabel_Catchphrase.Text = "Phrase:";
            this.metroSetLabel_Catchphrase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel_Catchphrase.ThemeAuthor = "Narwin";
            this.metroSetLabel_Catchphrase.ThemeName = "MetroDark";
            // 
            // metroSetLabel_AmiiboSeries
            // 
            this.metroSetLabel_AmiiboSeries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetLabel_AmiiboSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.metroSetLabel_AmiiboSeries.IsDerivedStyle = true;
            this.metroSetLabel_AmiiboSeries.Location = new System.Drawing.Point(3, 280);
            this.metroSetLabel_AmiiboSeries.Name = "metroSetLabel_AmiiboSeries";
            this.metroSetLabel_AmiiboSeries.Size = new System.Drawing.Size(100, 40);
            this.metroSetLabel_AmiiboSeries.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel_AmiiboSeries.StyleManager = null;
            this.metroSetLabel_AmiiboSeries.TabIndex = 44;
            this.metroSetLabel_AmiiboSeries.Text = "Amiibo Series:";
            this.metroSetLabel_AmiiboSeries.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel_AmiiboSeries.ThemeAuthor = "Narwin";
            this.metroSetLabel_AmiiboSeries.ThemeName = "MetroDark";
            // 
            // tableLayoutPanel_Birthday
            // 
            this.tableLayoutPanel_Birthday.ColumnCount = 2;
            this.tableLayoutPanel_Birthday.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Birthday.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Birthday.Controls.Add(this.numeric_Day, 0, 0);
            this.tableLayoutPanel_Birthday.Controls.Add(this.numeric_Month, 0, 0);
            this.tableLayoutPanel_Birthday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_Birthday.Location = new System.Drawing.Point(109, 243);
            this.tableLayoutPanel_Birthday.Name = "tableLayoutPanel_Birthday";
            this.tableLayoutPanel_Birthday.RowCount = 1;
            this.tableLayoutPanel_Birthday.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Birthday.Size = new System.Drawing.Size(243, 34);
            this.tableLayoutPanel_Birthday.TabIndex = 43;
            // 
            // numeric_Day
            // 
            this.numeric_Day.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.numeric_Day.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeric_Day.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numeric_Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numeric_Day.ForeColor = System.Drawing.Color.Silver;
            this.numeric_Day.Location = new System.Drawing.Point(124, 3);
            this.numeric_Day.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numeric_Day.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_Day.Name = "numeric_Day";
            this.numeric_Day.Size = new System.Drawing.Size(116, 30);
            this.numeric_Day.TabIndex = 30;
            this.numeric_Day.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            // 
            // numeric_Month
            // 
            this.numeric_Month.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.numeric_Month.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeric_Month.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numeric_Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numeric_Month.ForeColor = System.Drawing.Color.Silver;
            this.numeric_Month.Location = new System.Drawing.Point(3, 3);
            this.numeric_Month.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numeric_Month.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_Month.Name = "numeric_Month";
            this.numeric_Month.Size = new System.Drawing.Size(115, 30);
            this.numeric_Month.TabIndex = 29;
            this.numeric_Month.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // metroSetLabel_Birthday
            // 
            this.metroSetLabel_Birthday.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetLabel_Birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel_Birthday.IsDerivedStyle = true;
            this.metroSetLabel_Birthday.Location = new System.Drawing.Point(3, 240);
            this.metroSetLabel_Birthday.Name = "metroSetLabel_Birthday";
            this.metroSetLabel_Birthday.Size = new System.Drawing.Size(100, 40);
            this.metroSetLabel_Birthday.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel_Birthday.StyleManager = null;
            this.metroSetLabel_Birthday.TabIndex = 42;
            this.metroSetLabel_Birthday.Text = "Birthday:";
            this.metroSetLabel_Birthday.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel_Birthday.ThemeAuthor = "Narwin";
            this.metroSetLabel_Birthday.ThemeName = "MetroDark";
            // 
            // metroSetComboBox_Hobby
            // 
            this.metroSetComboBox_Hobby.AllowDrop = true;
            this.metroSetComboBox_Hobby.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetComboBox_Hobby.BackColor = System.Drawing.Color.Transparent;
            this.metroSetComboBox_Hobby.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.metroSetComboBox_Hobby.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetComboBox_Hobby.CausesValidation = false;
            this.metroSetComboBox_Hobby.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.metroSetComboBox_Hobby.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetComboBox_Hobby.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetComboBox_Hobby.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetComboBox_Hobby.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroSetComboBox_Hobby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroSetComboBox_Hobby.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.metroSetComboBox_Hobby.FormattingEnabled = true;
            this.metroSetComboBox_Hobby.IsDerivedStyle = true;
            this.metroSetComboBox_Hobby.ItemHeight = 20;
            this.metroSetComboBox_Hobby.Location = new System.Drawing.Point(109, 203);
            this.metroSetComboBox_Hobby.Name = "metroSetComboBox_Hobby";
            this.metroSetComboBox_Hobby.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetComboBox_Hobby.SelectedItemForeColor = System.Drawing.Color.White;
            this.metroSetComboBox_Hobby.Size = new System.Drawing.Size(243, 26);
            this.metroSetComboBox_Hobby.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetComboBox_Hobby.StyleManager = null;
            this.metroSetComboBox_Hobby.TabIndex = 41;
            this.metroSetComboBox_Hobby.ThemeAuthor = "Narwin";
            this.metroSetComboBox_Hobby.ThemeName = "MetroDark";
            // 
            // metroSetLabel_Hobby
            // 
            this.metroSetLabel_Hobby.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetLabel_Hobby.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel_Hobby.IsDerivedStyle = true;
            this.metroSetLabel_Hobby.Location = new System.Drawing.Point(3, 200);
            this.metroSetLabel_Hobby.Name = "metroSetLabel_Hobby";
            this.metroSetLabel_Hobby.Size = new System.Drawing.Size(100, 40);
            this.metroSetLabel_Hobby.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel_Hobby.StyleManager = null;
            this.metroSetLabel_Hobby.TabIndex = 40;
            this.metroSetLabel_Hobby.Text = "Hobby:";
            this.metroSetLabel_Hobby.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel_Hobby.ThemeAuthor = "Narwin";
            this.metroSetLabel_Hobby.ThemeName = "MetroDark";
            // 
            // metroSetLabel_VillagerSpecies
            // 
            this.metroSetLabel_VillagerSpecies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetLabel_VillagerSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel_VillagerSpecies.IsDerivedStyle = true;
            this.metroSetLabel_VillagerSpecies.Location = new System.Drawing.Point(3, 40);
            this.metroSetLabel_VillagerSpecies.Name = "metroSetLabel_VillagerSpecies";
            this.metroSetLabel_VillagerSpecies.Size = new System.Drawing.Size(100, 40);
            this.metroSetLabel_VillagerSpecies.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel_VillagerSpecies.StyleManager = null;
            this.metroSetLabel_VillagerSpecies.TabIndex = 32;
            this.metroSetLabel_VillagerSpecies.Text = "Species:";
            this.metroSetLabel_VillagerSpecies.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel_VillagerSpecies.ThemeAuthor = "Narwin";
            this.metroSetLabel_VillagerSpecies.ThemeName = "MetroDark";
            // 
            // metroSetLabel_VillagerName
            // 
            this.metroSetLabel_VillagerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetLabel_VillagerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel_VillagerName.IsDerivedStyle = true;
            this.metroSetLabel_VillagerName.Location = new System.Drawing.Point(3, 0);
            this.metroSetLabel_VillagerName.Name = "metroSetLabel_VillagerName";
            this.metroSetLabel_VillagerName.Size = new System.Drawing.Size(100, 40);
            this.metroSetLabel_VillagerName.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel_VillagerName.StyleManager = null;
            this.metroSetLabel_VillagerName.TabIndex = 26;
            this.metroSetLabel_VillagerName.Text = "Name:";
            this.metroSetLabel_VillagerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel_VillagerName.ThemeAuthor = "Narwin";
            this.metroSetLabel_VillagerName.ThemeName = "MetroDark";
            // 
            // metroSetLabel_VillagerID
            // 
            this.metroSetLabel_VillagerID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetLabel_VillagerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel_VillagerID.IsDerivedStyle = true;
            this.metroSetLabel_VillagerID.Location = new System.Drawing.Point(3, 80);
            this.metroSetLabel_VillagerID.Name = "metroSetLabel_VillagerID";
            this.metroSetLabel_VillagerID.Size = new System.Drawing.Size(100, 40);
            this.metroSetLabel_VillagerID.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel_VillagerID.StyleManager = null;
            this.metroSetLabel_VillagerID.TabIndex = 31;
            this.metroSetLabel_VillagerID.Text = "ID:";
            this.metroSetLabel_VillagerID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel_VillagerID.ThemeAuthor = "Narwin";
            this.metroSetLabel_VillagerID.ThemeName = "MetroDark";
            // 
            // numeric_VillagerID
            // 
            this.numeric_VillagerID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.numeric_VillagerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeric_VillagerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numeric_VillagerID.ForeColor = System.Drawing.Color.Silver;
            this.numeric_VillagerID.Location = new System.Drawing.Point(109, 83);
            this.numeric_VillagerID.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numeric_VillagerID.Name = "numeric_VillagerID";
            this.numeric_VillagerID.Size = new System.Drawing.Size(243, 30);
            this.numeric_VillagerID.TabIndex = 28;
            // 
            // tableLayoutPanel_VillagerSpeciesAdd
            // 
            this.tableLayoutPanel_VillagerSpeciesAdd.ColumnCount = 2;
            this.tableLayoutPanel_VillagerSpeciesAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.18008F));
            this.tableLayoutPanel_VillagerSpeciesAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.81992F));
            this.tableLayoutPanel_VillagerSpeciesAdd.Controls.Add(this.button_AddSpecies, 1, 0);
            this.tableLayoutPanel_VillagerSpeciesAdd.Controls.Add(this.metroSetComboBox_VillagerSpecies, 0, 0);
            this.tableLayoutPanel_VillagerSpeciesAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_VillagerSpeciesAdd.Location = new System.Drawing.Point(109, 43);
            this.tableLayoutPanel_VillagerSpeciesAdd.Name = "tableLayoutPanel_VillagerSpeciesAdd";
            this.tableLayoutPanel_VillagerSpeciesAdd.RowCount = 1;
            this.tableLayoutPanel_VillagerSpeciesAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_VillagerSpeciesAdd.Size = new System.Drawing.Size(243, 34);
            this.tableLayoutPanel_VillagerSpeciesAdd.TabIndex = 34;
            // 
            // button_AddSpecies
            // 
            this.button_AddSpecies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_AddSpecies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_AddSpecies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.button_AddSpecies.ForeColor = System.Drawing.Color.Silver;
            this.button_AddSpecies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_AddSpecies.Location = new System.Drawing.Point(180, 3);
            this.button_AddSpecies.Name = "button_AddSpecies";
            this.button_AddSpecies.Size = new System.Drawing.Size(60, 28);
            this.button_AddSpecies.TabIndex = 34;
            this.button_AddSpecies.Text = "Add";
            this.button_AddSpecies.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_AddSpecies.UseVisualStyleBackColor = false;
            this.button_AddSpecies.Click += new System.EventHandler(this.AddSpecies_Click);
            // 
            // metroSetComboBox_VillagerSpecies
            // 
            this.metroSetComboBox_VillagerSpecies.AllowDrop = true;
            this.metroSetComboBox_VillagerSpecies.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetComboBox_VillagerSpecies.BackColor = System.Drawing.Color.Transparent;
            this.metroSetComboBox_VillagerSpecies.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.metroSetComboBox_VillagerSpecies.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetComboBox_VillagerSpecies.CausesValidation = false;
            this.metroSetComboBox_VillagerSpecies.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.metroSetComboBox_VillagerSpecies.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetComboBox_VillagerSpecies.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetComboBox_VillagerSpecies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetComboBox_VillagerSpecies.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroSetComboBox_VillagerSpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroSetComboBox_VillagerSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.metroSetComboBox_VillagerSpecies.FormattingEnabled = true;
            this.metroSetComboBox_VillagerSpecies.IsDerivedStyle = true;
            this.metroSetComboBox_VillagerSpecies.ItemHeight = 20;
            this.metroSetComboBox_VillagerSpecies.Location = new System.Drawing.Point(3, 3);
            this.metroSetComboBox_VillagerSpecies.Name = "metroSetComboBox_VillagerSpecies";
            this.metroSetComboBox_VillagerSpecies.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetComboBox_VillagerSpecies.SelectedItemForeColor = System.Drawing.Color.White;
            this.metroSetComboBox_VillagerSpecies.Size = new System.Drawing.Size(171, 26);
            this.metroSetComboBox_VillagerSpecies.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetComboBox_VillagerSpecies.StyleManager = null;
            this.metroSetComboBox_VillagerSpecies.TabIndex = 33;
            this.metroSetComboBox_VillagerSpecies.ThemeAuthor = "Narwin";
            this.metroSetComboBox_VillagerSpecies.ThemeName = "MetroDark";
            // 
            // metroSetLabel_VillagerGender
            // 
            this.metroSetLabel_VillagerGender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetLabel_VillagerGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel_VillagerGender.IsDerivedStyle = true;
            this.metroSetLabel_VillagerGender.Location = new System.Drawing.Point(3, 120);
            this.metroSetLabel_VillagerGender.Name = "metroSetLabel_VillagerGender";
            this.metroSetLabel_VillagerGender.Size = new System.Drawing.Size(100, 40);
            this.metroSetLabel_VillagerGender.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel_VillagerGender.StyleManager = null;
            this.metroSetLabel_VillagerGender.TabIndex = 35;
            this.metroSetLabel_VillagerGender.Text = "Talk Style:";
            this.metroSetLabel_VillagerGender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel_VillagerGender.ThemeAuthor = "Narwin";
            this.metroSetLabel_VillagerGender.ThemeName = "MetroDark";
            // 
            // metroSetLabel_Personality
            // 
            this.metroSetLabel_Personality.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetLabel_Personality.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel_Personality.IsDerivedStyle = true;
            this.metroSetLabel_Personality.Location = new System.Drawing.Point(3, 160);
            this.metroSetLabel_Personality.Name = "metroSetLabel_Personality";
            this.metroSetLabel_Personality.Size = new System.Drawing.Size(100, 40);
            this.metroSetLabel_Personality.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel_Personality.StyleManager = null;
            this.metroSetLabel_Personality.TabIndex = 37;
            this.metroSetLabel_Personality.Text = "Personality:";
            this.metroSetLabel_Personality.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel_Personality.ThemeAuthor = "Narwin";
            this.metroSetLabel_Personality.ThemeName = "MetroDark";
            // 
            // metroSetComboBox_Personality
            // 
            this.metroSetComboBox_Personality.AllowDrop = true;
            this.metroSetComboBox_Personality.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetComboBox_Personality.BackColor = System.Drawing.Color.Transparent;
            this.metroSetComboBox_Personality.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.metroSetComboBox_Personality.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetComboBox_Personality.CausesValidation = false;
            this.metroSetComboBox_Personality.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.metroSetComboBox_Personality.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetComboBox_Personality.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetComboBox_Personality.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetComboBox_Personality.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroSetComboBox_Personality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroSetComboBox_Personality.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.metroSetComboBox_Personality.FormattingEnabled = true;
            this.metroSetComboBox_Personality.IsDerivedStyle = true;
            this.metroSetComboBox_Personality.ItemHeight = 20;
            this.metroSetComboBox_Personality.Location = new System.Drawing.Point(109, 163);
            this.metroSetComboBox_Personality.Name = "metroSetComboBox_Personality";
            this.metroSetComboBox_Personality.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetComboBox_Personality.SelectedItemForeColor = System.Drawing.Color.White;
            this.metroSetComboBox_Personality.Size = new System.Drawing.Size(243, 26);
            this.metroSetComboBox_Personality.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetComboBox_Personality.StyleManager = null;
            this.metroSetComboBox_Personality.TabIndex = 38;
            this.metroSetComboBox_Personality.ThemeAuthor = "Narwin";
            this.metroSetComboBox_Personality.ThemeName = "MetroDark";
            // 
            // tableLayoutPanel_VillagerGender
            // 
            this.tableLayoutPanel_VillagerGender.ColumnCount = 2;
            this.tableLayoutPanel_VillagerGender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_VillagerGender.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_VillagerGender.Controls.Add(this.metroSetRadioButton_TalkType2, 1, 0);
            this.tableLayoutPanel_VillagerGender.Controls.Add(this.metroSetRadioButton_TalkType1, 0, 0);
            this.tableLayoutPanel_VillagerGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_VillagerGender.Location = new System.Drawing.Point(109, 123);
            this.tableLayoutPanel_VillagerGender.Name = "tableLayoutPanel_VillagerGender";
            this.tableLayoutPanel_VillagerGender.RowCount = 1;
            this.tableLayoutPanel_VillagerGender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_VillagerGender.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel_VillagerGender.Size = new System.Drawing.Size(243, 34);
            this.tableLayoutPanel_VillagerGender.TabIndex = 39;
            // 
            // metroSetRadioButton_TalkType2
            // 
            this.metroSetRadioButton_TalkType2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetRadioButton_TalkType2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetRadioButton_TalkType2.Checked = false;
            this.metroSetRadioButton_TalkType2.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetRadioButton_TalkType2.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.metroSetRadioButton_TalkType2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.metroSetRadioButton_TalkType2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetRadioButton_TalkType2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetRadioButton_TalkType2.Group = 0;
            this.metroSetRadioButton_TalkType2.IsDerivedStyle = true;
            this.metroSetRadioButton_TalkType2.Location = new System.Drawing.Point(124, 3);
            this.metroSetRadioButton_TalkType2.Name = "metroSetRadioButton_TalkType2";
            this.metroSetRadioButton_TalkType2.Size = new System.Drawing.Size(116, 17);
            this.metroSetRadioButton_TalkType2.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetRadioButton_TalkType2.StyleManager = null;
            this.metroSetRadioButton_TalkType2.TabIndex = 1;
            this.metroSetRadioButton_TalkType2.Text = "Type 2";
            this.metroSetRadioButton_TalkType2.ThemeAuthor = "Narwin";
            this.metroSetRadioButton_TalkType2.ThemeName = "MetroDark";
            // 
            // metroSetRadioButton_TalkType1
            // 
            this.metroSetRadioButton_TalkType1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetRadioButton_TalkType1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetRadioButton_TalkType1.Checked = true;
            this.metroSetRadioButton_TalkType1.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetRadioButton_TalkType1.CheckState = MetroSet_UI.Enums.CheckState.Checked;
            this.metroSetRadioButton_TalkType1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.metroSetRadioButton_TalkType1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetRadioButton_TalkType1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetRadioButton_TalkType1.Group = 0;
            this.metroSetRadioButton_TalkType1.IsDerivedStyle = true;
            this.metroSetRadioButton_TalkType1.Location = new System.Drawing.Point(3, 3);
            this.metroSetRadioButton_TalkType1.Name = "metroSetRadioButton_TalkType1";
            this.metroSetRadioButton_TalkType1.Size = new System.Drawing.Size(115, 17);
            this.metroSetRadioButton_TalkType1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetRadioButton_TalkType1.StyleManager = null;
            this.metroSetRadioButton_TalkType1.TabIndex = 0;
            this.metroSetRadioButton_TalkType1.Text = "Type 1";
            this.metroSetRadioButton_TalkType1.ThemeAuthor = "Narwin";
            this.metroSetRadioButton_TalkType1.ThemeName = "MetroDark";
            // 
            // metroSetLabel_ClothesType
            // 
            this.metroSetLabel_ClothesType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetLabel_ClothesType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.metroSetLabel_ClothesType.IsDerivedStyle = true;
            this.metroSetLabel_ClothesType.Location = new System.Drawing.Point(3, 400);
            this.metroSetLabel_ClothesType.Name = "metroSetLabel_ClothesType";
            this.metroSetLabel_ClothesType.Size = new System.Drawing.Size(100, 40);
            this.metroSetLabel_ClothesType.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel_ClothesType.StyleManager = null;
            this.metroSetLabel_ClothesType.TabIndex = 51;
            this.metroSetLabel_ClothesType.Text = "Clothes Type:";
            this.metroSetLabel_ClothesType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel_ClothesType.ThemeAuthor = "Narwin";
            this.metroSetLabel_ClothesType.ThemeName = "MetroDark";
            // 
            // metroSetComboBox_ClothesType
            // 
            this.metroSetComboBox_ClothesType.AllowDrop = true;
            this.metroSetComboBox_ClothesType.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetComboBox_ClothesType.BackColor = System.Drawing.Color.Transparent;
            this.metroSetComboBox_ClothesType.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.metroSetComboBox_ClothesType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetComboBox_ClothesType.CausesValidation = false;
            this.metroSetComboBox_ClothesType.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.metroSetComboBox_ClothesType.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetComboBox_ClothesType.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetComboBox_ClothesType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetComboBox_ClothesType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroSetComboBox_ClothesType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroSetComboBox_ClothesType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.metroSetComboBox_ClothesType.FormattingEnabled = true;
            this.metroSetComboBox_ClothesType.IsDerivedStyle = true;
            this.metroSetComboBox_ClothesType.ItemHeight = 20;
            this.metroSetComboBox_ClothesType.Location = new System.Drawing.Point(109, 403);
            this.metroSetComboBox_ClothesType.Name = "metroSetComboBox_ClothesType";
            this.metroSetComboBox_ClothesType.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetComboBox_ClothesType.SelectedItemForeColor = System.Drawing.Color.White;
            this.metroSetComboBox_ClothesType.Size = new System.Drawing.Size(243, 26);
            this.metroSetComboBox_ClothesType.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetComboBox_ClothesType.StyleManager = null;
            this.metroSetComboBox_ClothesType.TabIndex = 52;
            this.metroSetComboBox_ClothesType.ThemeAuthor = "Narwin";
            this.metroSetComboBox_ClothesType.ThemeName = "MetroDark";
            // 
            // metroSetComboBox_Style
            // 
            this.metroSetComboBox_Style.AllowDrop = true;
            this.metroSetComboBox_Style.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetComboBox_Style.BackColor = System.Drawing.Color.Transparent;
            this.metroSetComboBox_Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.metroSetComboBox_Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetComboBox_Style.CausesValidation = false;
            this.metroSetComboBox_Style.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.metroSetComboBox_Style.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetComboBox_Style.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetComboBox_Style.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetComboBox_Style.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroSetComboBox_Style.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroSetComboBox_Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.metroSetComboBox_Style.FormattingEnabled = true;
            this.metroSetComboBox_Style.IsDerivedStyle = true;
            this.metroSetComboBox_Style.ItemHeight = 20;
            this.metroSetComboBox_Style.Location = new System.Drawing.Point(109, 443);
            this.metroSetComboBox_Style.Name = "metroSetComboBox_Style";
            this.metroSetComboBox_Style.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetComboBox_Style.SelectedItemForeColor = System.Drawing.Color.White;
            this.metroSetComboBox_Style.Size = new System.Drawing.Size(243, 26);
            this.metroSetComboBox_Style.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetComboBox_Style.StyleManager = null;
            this.metroSetComboBox_Style.TabIndex = 54;
            this.metroSetComboBox_Style.ThemeAuthor = "Narwin";
            this.metroSetComboBox_Style.ThemeName = "MetroDark";
            // 
            // metroSetLabel_Style2
            // 
            this.metroSetLabel_Style2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetLabel_Style2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel_Style2.IsDerivedStyle = true;
            this.metroSetLabel_Style2.Location = new System.Drawing.Point(3, 480);
            this.metroSetLabel_Style2.Name = "metroSetLabel_Style2";
            this.metroSetLabel_Style2.Size = new System.Drawing.Size(100, 40);
            this.metroSetLabel_Style2.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel_Style2.StyleManager = null;
            this.metroSetLabel_Style2.TabIndex = 55;
            this.metroSetLabel_Style2.Text = "Style 2:";
            this.metroSetLabel_Style2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel_Style2.ThemeAuthor = "Narwin";
            this.metroSetLabel_Style2.ThemeName = "MetroDark";
            // 
            // metroSetComboBox_Style2
            // 
            this.metroSetComboBox_Style2.AllowDrop = true;
            this.metroSetComboBox_Style2.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetComboBox_Style2.BackColor = System.Drawing.Color.Transparent;
            this.metroSetComboBox_Style2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.metroSetComboBox_Style2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetComboBox_Style2.CausesValidation = false;
            this.metroSetComboBox_Style2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.metroSetComboBox_Style2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetComboBox_Style2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetComboBox_Style2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetComboBox_Style2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroSetComboBox_Style2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroSetComboBox_Style2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.metroSetComboBox_Style2.FormattingEnabled = true;
            this.metroSetComboBox_Style2.IsDerivedStyle = true;
            this.metroSetComboBox_Style2.ItemHeight = 20;
            this.metroSetComboBox_Style2.Location = new System.Drawing.Point(109, 483);
            this.metroSetComboBox_Style2.Name = "metroSetComboBox_Style2";
            this.metroSetComboBox_Style2.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetComboBox_Style2.SelectedItemForeColor = System.Drawing.Color.White;
            this.metroSetComboBox_Style2.Size = new System.Drawing.Size(243, 26);
            this.metroSetComboBox_Style2.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetComboBox_Style2.StyleManager = null;
            this.metroSetComboBox_Style2.TabIndex = 56;
            this.metroSetComboBox_Style2.ThemeAuthor = "Narwin";
            this.metroSetComboBox_Style2.ThemeName = "MetroDark";
            // 
            // metroSetLabel_Unknown1
            // 
            this.metroSetLabel_Unknown1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetLabel_Unknown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel_Unknown1.IsDerivedStyle = true;
            this.metroSetLabel_Unknown1.Location = new System.Drawing.Point(3, 520);
            this.metroSetLabel_Unknown1.Name = "metroSetLabel_Unknown1";
            this.metroSetLabel_Unknown1.Size = new System.Drawing.Size(100, 40);
            this.metroSetLabel_Unknown1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel_Unknown1.StyleManager = null;
            this.metroSetLabel_Unknown1.TabIndex = 57;
            this.metroSetLabel_Unknown1.Text = "Unknown:";
            this.metroSetLabel_Unknown1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel_Unknown1.ThemeAuthor = "Narwin";
            this.metroSetLabel_Unknown1.ThemeName = "MetroDark";
            // 
            // metroSetComboBox_Unknown1
            // 
            this.metroSetComboBox_Unknown1.AllowDrop = true;
            this.metroSetComboBox_Unknown1.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetComboBox_Unknown1.BackColor = System.Drawing.Color.Transparent;
            this.metroSetComboBox_Unknown1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.metroSetComboBox_Unknown1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetComboBox_Unknown1.CausesValidation = false;
            this.metroSetComboBox_Unknown1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.metroSetComboBox_Unknown1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetComboBox_Unknown1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetComboBox_Unknown1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetComboBox_Unknown1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroSetComboBox_Unknown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroSetComboBox_Unknown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.metroSetComboBox_Unknown1.FormattingEnabled = true;
            this.metroSetComboBox_Unknown1.IsDerivedStyle = true;
            this.metroSetComboBox_Unknown1.ItemHeight = 20;
            this.metroSetComboBox_Unknown1.Location = new System.Drawing.Point(109, 523);
            this.metroSetComboBox_Unknown1.Name = "metroSetComboBox_Unknown1";
            this.metroSetComboBox_Unknown1.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetComboBox_Unknown1.SelectedItemForeColor = System.Drawing.Color.White;
            this.metroSetComboBox_Unknown1.Size = new System.Drawing.Size(243, 26);
            this.metroSetComboBox_Unknown1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetComboBox_Unknown1.StyleManager = null;
            this.metroSetComboBox_Unknown1.TabIndex = 58;
            this.metroSetComboBox_Unknown1.ThemeAuthor = "Narwin";
            this.metroSetComboBox_Unknown1.ThemeName = "MetroDark";
            // 
            // metroSetLabel_SocialType
            // 
            this.metroSetLabel_SocialType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetLabel_SocialType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.metroSetLabel_SocialType.IsDerivedStyle = true;
            this.metroSetLabel_SocialType.Location = new System.Drawing.Point(3, 560);
            this.metroSetLabel_SocialType.Name = "metroSetLabel_SocialType";
            this.metroSetLabel_SocialType.Size = new System.Drawing.Size(100, 40);
            this.metroSetLabel_SocialType.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel_SocialType.StyleManager = null;
            this.metroSetLabel_SocialType.TabIndex = 59;
            this.metroSetLabel_SocialType.Text = "Social Type:";
            this.metroSetLabel_SocialType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel_SocialType.ThemeAuthor = "Narwin";
            this.metroSetLabel_SocialType.ThemeName = "MetroDark";
            // 
            // metroSetComboBox_SocialType
            // 
            this.metroSetComboBox_SocialType.AllowDrop = true;
            this.metroSetComboBox_SocialType.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetComboBox_SocialType.BackColor = System.Drawing.Color.Transparent;
            this.metroSetComboBox_SocialType.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.metroSetComboBox_SocialType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetComboBox_SocialType.CausesValidation = false;
            this.metroSetComboBox_SocialType.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.metroSetComboBox_SocialType.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetComboBox_SocialType.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetComboBox_SocialType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetComboBox_SocialType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroSetComboBox_SocialType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroSetComboBox_SocialType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.metroSetComboBox_SocialType.FormattingEnabled = true;
            this.metroSetComboBox_SocialType.IsDerivedStyle = true;
            this.metroSetComboBox_SocialType.ItemHeight = 20;
            this.metroSetComboBox_SocialType.Location = new System.Drawing.Point(109, 563);
            this.metroSetComboBox_SocialType.Name = "metroSetComboBox_SocialType";
            this.metroSetComboBox_SocialType.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetComboBox_SocialType.SelectedItemForeColor = System.Drawing.Color.White;
            this.metroSetComboBox_SocialType.Size = new System.Drawing.Size(243, 26);
            this.metroSetComboBox_SocialType.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetComboBox_SocialType.StyleManager = null;
            this.metroSetComboBox_SocialType.TabIndex = 60;
            this.metroSetComboBox_SocialType.ThemeAuthor = "Narwin";
            this.metroSetComboBox_SocialType.ThemeName = "MetroDark";
            // 
            // metroSetComboBox_SingPause
            // 
            this.metroSetComboBox_SingPause.AllowDrop = true;
            this.metroSetComboBox_SingPause.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetComboBox_SingPause.BackColor = System.Drawing.Color.Transparent;
            this.metroSetComboBox_SingPause.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.metroSetComboBox_SingPause.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetComboBox_SingPause.CausesValidation = false;
            this.metroSetComboBox_SingPause.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.metroSetComboBox_SingPause.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetComboBox_SingPause.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetComboBox_SingPause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetComboBox_SingPause.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroSetComboBox_SingPause.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroSetComboBox_SingPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.metroSetComboBox_SingPause.FormattingEnabled = true;
            this.metroSetComboBox_SingPause.IsDerivedStyle = true;
            this.metroSetComboBox_SingPause.ItemHeight = 20;
            this.metroSetComboBox_SingPause.Location = new System.Drawing.Point(109, 603);
            this.metroSetComboBox_SingPause.Name = "metroSetComboBox_SingPause";
            this.metroSetComboBox_SingPause.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetComboBox_SingPause.SelectedItemForeColor = System.Drawing.Color.White;
            this.metroSetComboBox_SingPause.Size = new System.Drawing.Size(243, 26);
            this.metroSetComboBox_SingPause.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetComboBox_SingPause.StyleManager = null;
            this.metroSetComboBox_SingPause.TabIndex = 62;
            this.metroSetComboBox_SingPause.ThemeAuthor = "Narwin";
            this.metroSetComboBox_SingPause.ThemeName = "MetroDark";
            // 
            // metroSetLabel_SingPause
            // 
            this.metroSetLabel_SingPause.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetLabel_SingPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.metroSetLabel_SingPause.IsDerivedStyle = true;
            this.metroSetLabel_SingPause.Location = new System.Drawing.Point(3, 600);
            this.metroSetLabel_SingPause.Name = "metroSetLabel_SingPause";
            this.metroSetLabel_SingPause.Size = new System.Drawing.Size(100, 40);
            this.metroSetLabel_SingPause.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel_SingPause.StyleManager = null;
            this.metroSetLabel_SingPause.TabIndex = 61;
            this.metroSetLabel_SingPause.Text = "Sing Pause:";
            this.metroSetLabel_SingPause.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel_SingPause.ThemeAuthor = "Narwin";
            this.metroSetLabel_SingPause.ThemeName = "MetroDark";
            // 
            // metroSetComboBox_SingRhythm
            // 
            this.metroSetComboBox_SingRhythm.AllowDrop = true;
            this.metroSetComboBox_SingRhythm.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetComboBox_SingRhythm.BackColor = System.Drawing.Color.Transparent;
            this.metroSetComboBox_SingRhythm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.metroSetComboBox_SingRhythm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetComboBox_SingRhythm.CausesValidation = false;
            this.metroSetComboBox_SingRhythm.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.metroSetComboBox_SingRhythm.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetComboBox_SingRhythm.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetComboBox_SingRhythm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetComboBox_SingRhythm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroSetComboBox_SingRhythm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroSetComboBox_SingRhythm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.metroSetComboBox_SingRhythm.FormattingEnabled = true;
            this.metroSetComboBox_SingRhythm.IsDerivedStyle = true;
            this.metroSetComboBox_SingRhythm.ItemHeight = 20;
            this.metroSetComboBox_SingRhythm.Location = new System.Drawing.Point(109, 643);
            this.metroSetComboBox_SingRhythm.Name = "metroSetComboBox_SingRhythm";
            this.metroSetComboBox_SingRhythm.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetComboBox_SingRhythm.SelectedItemForeColor = System.Drawing.Color.White;
            this.metroSetComboBox_SingRhythm.Size = new System.Drawing.Size(243, 26);
            this.metroSetComboBox_SingRhythm.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetComboBox_SingRhythm.StyleManager = null;
            this.metroSetComboBox_SingRhythm.TabIndex = 64;
            this.metroSetComboBox_SingRhythm.ThemeAuthor = "Narwin";
            this.metroSetComboBox_SingRhythm.ThemeName = "MetroDark";
            // 
            // metroSetLabel_SingRhythm
            // 
            this.metroSetLabel_SingRhythm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetLabel_SingRhythm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.metroSetLabel_SingRhythm.IsDerivedStyle = true;
            this.metroSetLabel_SingRhythm.Location = new System.Drawing.Point(3, 640);
            this.metroSetLabel_SingRhythm.Name = "metroSetLabel_SingRhythm";
            this.metroSetLabel_SingRhythm.Size = new System.Drawing.Size(100, 40);
            this.metroSetLabel_SingRhythm.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel_SingRhythm.StyleManager = null;
            this.metroSetLabel_SingRhythm.TabIndex = 63;
            this.metroSetLabel_SingRhythm.Text = "Sing Rhythm:";
            this.metroSetLabel_SingRhythm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel_SingRhythm.ThemeAuthor = "Narwin";
            this.metroSetLabel_SingRhythm.ThemeName = "MetroDark";
            // 
            // metroSetLabel_PhotoID
            // 
            this.metroSetLabel_PhotoID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetLabel_PhotoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.metroSetLabel_PhotoID.IsDerivedStyle = true;
            this.metroSetLabel_PhotoID.Location = new System.Drawing.Point(3, 680);
            this.metroSetLabel_PhotoID.Name = "metroSetLabel_PhotoID";
            this.metroSetLabel_PhotoID.Size = new System.Drawing.Size(100, 40);
            this.metroSetLabel_PhotoID.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel_PhotoID.StyleManager = null;
            this.metroSetLabel_PhotoID.TabIndex = 66;
            this.metroSetLabel_PhotoID.Text = "Photo Item ID:";
            this.metroSetLabel_PhotoID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel_PhotoID.ThemeAuthor = "Narwin";
            this.metroSetLabel_PhotoID.ThemeName = "MetroDark";
            // 
            // numeric_PhotoID
            // 
            this.numeric_PhotoID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.numeric_PhotoID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeric_PhotoID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numeric_PhotoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numeric_PhotoID.ForeColor = System.Drawing.Color.Silver;
            this.numeric_PhotoID.Location = new System.Drawing.Point(109, 683);
            this.numeric_PhotoID.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numeric_PhotoID.Name = "numeric_PhotoID";
            this.numeric_PhotoID.Size = new System.Drawing.Size(243, 30);
            this.numeric_PhotoID.TabIndex = 65;
            // 
            // metroSetLabel_FloorType
            // 
            this.metroSetLabel_FloorType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetLabel_FloorType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel_FloorType.IsDerivedStyle = true;
            this.metroSetLabel_FloorType.Location = new System.Drawing.Point(3, 720);
            this.metroSetLabel_FloorType.Name = "metroSetLabel_FloorType";
            this.metroSetLabel_FloorType.Size = new System.Drawing.Size(100, 40);
            this.metroSetLabel_FloorType.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel_FloorType.StyleManager = null;
            this.metroSetLabel_FloorType.TabIndex = 67;
            this.metroSetLabel_FloorType.Text = "Floor Type:";
            this.metroSetLabel_FloorType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel_FloorType.ThemeAuthor = "Narwin";
            this.metroSetLabel_FloorType.ThemeName = "MetroDark";
            // 
            // numeric_FloorType
            // 
            this.numeric_FloorType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.numeric_FloorType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numeric_FloorType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numeric_FloorType.ForeColor = System.Drawing.Color.Silver;
            this.numeric_FloorType.Location = new System.Drawing.Point(109, 723);
            this.numeric_FloorType.Maximum = new decimal(new int[] {
            54,
            0,
            0,
            0});
            this.numeric_FloorType.Name = "numeric_FloorType";
            this.numeric_FloorType.Size = new System.Drawing.Size(243, 30);
            this.numeric_FloorType.TabIndex = 68;
            // 
            // metroSetLabel_PosterID
            // 
            this.metroSetLabel_PosterID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetLabel_PosterID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.metroSetLabel_PosterID.IsDerivedStyle = true;
            this.metroSetLabel_PosterID.Location = new System.Drawing.Point(3, 760);
            this.metroSetLabel_PosterID.Name = "metroSetLabel_PosterID";
            this.metroSetLabel_PosterID.Size = new System.Drawing.Size(100, 40);
            this.metroSetLabel_PosterID.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel_PosterID.StyleManager = null;
            this.metroSetLabel_PosterID.TabIndex = 70;
            this.metroSetLabel_PosterID.Text = "Poster Item ID:";
            this.metroSetLabel_PosterID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel_PosterID.ThemeAuthor = "Narwin";
            this.metroSetLabel_PosterID.ThemeName = "MetroDark";
            // 
            // numeric_PosterID
            // 
            this.numeric_PosterID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.numeric_PosterID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numeric_PosterID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numeric_PosterID.ForeColor = System.Drawing.Color.Silver;
            this.numeric_PosterID.Location = new System.Drawing.Point(109, 763);
            this.numeric_PosterID.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numeric_PosterID.Name = "numeric_PosterID";
            this.numeric_PosterID.Size = new System.Drawing.Size(243, 30);
            this.numeric_PosterID.TabIndex = 69;
            // 
            // metroSetLabel_RainHatID
            // 
            this.metroSetLabel_RainHatID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetLabel_RainHatID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.metroSetLabel_RainHatID.IsDerivedStyle = true;
            this.metroSetLabel_RainHatID.Location = new System.Drawing.Point(3, 800);
            this.metroSetLabel_RainHatID.Name = "metroSetLabel_RainHatID";
            this.metroSetLabel_RainHatID.Size = new System.Drawing.Size(100, 40);
            this.metroSetLabel_RainHatID.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel_RainHatID.StyleManager = null;
            this.metroSetLabel_RainHatID.TabIndex = 71;
            this.metroSetLabel_RainHatID.Text = "Rain Hat ID:";
            this.metroSetLabel_RainHatID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel_RainHatID.ThemeAuthor = "Narwin";
            this.metroSetLabel_RainHatID.ThemeName = "MetroDark";
            // 
            // numeric_RainHatID
            // 
            this.numeric_RainHatID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.numeric_RainHatID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numeric_RainHatID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numeric_RainHatID.ForeColor = System.Drawing.Color.Silver;
            this.numeric_RainHatID.Location = new System.Drawing.Point(109, 803);
            this.numeric_RainHatID.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numeric_RainHatID.Name = "numeric_RainHatID";
            this.numeric_RainHatID.Size = new System.Drawing.Size(243, 30);
            this.numeric_RainHatID.TabIndex = 72;
            // 
            // metroSetLabel_RainWearID
            // 
            this.metroSetLabel_RainWearID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetLabel_RainWearID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.metroSetLabel_RainWearID.IsDerivedStyle = true;
            this.metroSetLabel_RainWearID.Location = new System.Drawing.Point(3, 840);
            this.metroSetLabel_RainWearID.Name = "metroSetLabel_RainWearID";
            this.metroSetLabel_RainWearID.Size = new System.Drawing.Size(100, 40);
            this.metroSetLabel_RainWearID.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel_RainWearID.StyleManager = null;
            this.metroSetLabel_RainWearID.TabIndex = 73;
            this.metroSetLabel_RainWearID.Text = "Rain Wear ID:";
            this.metroSetLabel_RainWearID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel_RainWearID.ThemeAuthor = "Narwin";
            this.metroSetLabel_RainWearID.ThemeName = "MetroDark";
            // 
            // numeric_RainWearID
            // 
            this.numeric_RainWearID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.numeric_RainWearID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numeric_RainWearID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numeric_RainWearID.ForeColor = System.Drawing.Color.Silver;
            this.numeric_RainWearID.Location = new System.Drawing.Point(109, 843);
            this.numeric_RainWearID.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numeric_RainWearID.Name = "numeric_RainWearID";
            this.numeric_RainWearID.Size = new System.Drawing.Size(243, 30);
            this.numeric_RainWearID.TabIndex = 74;
            // 
            // metroSetLabel_PhonePattern
            // 
            this.metroSetLabel_PhonePattern.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetLabel_PhonePattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.metroSetLabel_PhonePattern.IsDerivedStyle = true;
            this.metroSetLabel_PhonePattern.Location = new System.Drawing.Point(3, 880);
            this.metroSetLabel_PhonePattern.Name = "metroSetLabel_PhonePattern";
            this.metroSetLabel_PhonePattern.Size = new System.Drawing.Size(100, 40);
            this.metroSetLabel_PhonePattern.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel_PhonePattern.StyleManager = null;
            this.metroSetLabel_PhonePattern.TabIndex = 75;
            this.metroSetLabel_PhonePattern.Text = "Phone Pattern:";
            this.metroSetLabel_PhonePattern.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel_PhonePattern.ThemeAuthor = "Narwin";
            this.metroSetLabel_PhonePattern.ThemeName = "MetroDark";
            // 
            // numeric_PhonePattern
            // 
            this.numeric_PhonePattern.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.numeric_PhonePattern.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numeric_PhonePattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numeric_PhonePattern.ForeColor = System.Drawing.Color.Silver;
            this.numeric_PhonePattern.Location = new System.Drawing.Point(109, 883);
            this.numeric_PhonePattern.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numeric_PhonePattern.Name = "numeric_PhonePattern";
            this.numeric_PhonePattern.Size = new System.Drawing.Size(243, 30);
            this.numeric_PhonePattern.TabIndex = 76;
            // 
            // numeric_ShirtID
            // 
            this.numeric_ShirtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.numeric_ShirtID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numeric_ShirtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numeric_ShirtID.ForeColor = System.Drawing.Color.Silver;
            this.numeric_ShirtID.Location = new System.Drawing.Point(109, 923);
            this.numeric_ShirtID.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numeric_ShirtID.Name = "numeric_ShirtID";
            this.numeric_ShirtID.Size = new System.Drawing.Size(243, 30);
            this.numeric_ShirtID.TabIndex = 78;
            // 
            // metroSetLabel_UmbrellaID
            // 
            this.metroSetLabel_UmbrellaID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetLabel_UmbrellaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.metroSetLabel_UmbrellaID.IsDerivedStyle = true;
            this.metroSetLabel_UmbrellaID.Location = new System.Drawing.Point(3, 960);
            this.metroSetLabel_UmbrellaID.Name = "metroSetLabel_UmbrellaID";
            this.metroSetLabel_UmbrellaID.Size = new System.Drawing.Size(100, 40);
            this.metroSetLabel_UmbrellaID.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel_UmbrellaID.StyleManager = null;
            this.metroSetLabel_UmbrellaID.TabIndex = 79;
            this.metroSetLabel_UmbrellaID.Text = "Umbrella ID:";
            this.metroSetLabel_UmbrellaID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel_UmbrellaID.ThemeAuthor = "Narwin";
            this.metroSetLabel_UmbrellaID.ThemeName = "MetroDark";
            // 
            // numeric_UmbrellaID
            // 
            this.numeric_UmbrellaID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.numeric_UmbrellaID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numeric_UmbrellaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numeric_UmbrellaID.ForeColor = System.Drawing.Color.Silver;
            this.numeric_UmbrellaID.Location = new System.Drawing.Point(109, 963);
            this.numeric_UmbrellaID.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numeric_UmbrellaID.Name = "numeric_UmbrellaID";
            this.numeric_UmbrellaID.Size = new System.Drawing.Size(243, 30);
            this.numeric_UmbrellaID.TabIndex = 80;
            // 
            // metroSetComboBox_FaveColor
            // 
            this.metroSetComboBox_FaveColor.AllowDrop = true;
            this.metroSetComboBox_FaveColor.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetComboBox_FaveColor.BackColor = System.Drawing.Color.Transparent;
            this.metroSetComboBox_FaveColor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.metroSetComboBox_FaveColor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetComboBox_FaveColor.CausesValidation = false;
            this.metroSetComboBox_FaveColor.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.metroSetComboBox_FaveColor.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetComboBox_FaveColor.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetComboBox_FaveColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetComboBox_FaveColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroSetComboBox_FaveColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroSetComboBox_FaveColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.metroSetComboBox_FaveColor.FormattingEnabled = true;
            this.metroSetComboBox_FaveColor.IsDerivedStyle = true;
            this.metroSetComboBox_FaveColor.ItemHeight = 20;
            this.metroSetComboBox_FaveColor.Location = new System.Drawing.Point(109, 1003);
            this.metroSetComboBox_FaveColor.Name = "metroSetComboBox_FaveColor";
            this.metroSetComboBox_FaveColor.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetComboBox_FaveColor.SelectedItemForeColor = System.Drawing.Color.White;
            this.metroSetComboBox_FaveColor.Size = new System.Drawing.Size(243, 26);
            this.metroSetComboBox_FaveColor.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetComboBox_FaveColor.StyleManager = null;
            this.metroSetComboBox_FaveColor.TabIndex = 82;
            this.metroSetComboBox_FaveColor.ThemeAuthor = "Narwin";
            this.metroSetComboBox_FaveColor.ThemeName = "MetroDark";
            // 
            // metroSetLabel_FaveColor
            // 
            this.metroSetLabel_FaveColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetLabel_FaveColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel_FaveColor.IsDerivedStyle = true;
            this.metroSetLabel_FaveColor.Location = new System.Drawing.Point(3, 1000);
            this.metroSetLabel_FaveColor.Name = "metroSetLabel_FaveColor";
            this.metroSetLabel_FaveColor.Size = new System.Drawing.Size(100, 40);
            this.metroSetLabel_FaveColor.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel_FaveColor.StyleManager = null;
            this.metroSetLabel_FaveColor.TabIndex = 81;
            this.metroSetLabel_FaveColor.Text = "Fave Color:";
            this.metroSetLabel_FaveColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel_FaveColor.ThemeAuthor = "Narwin";
            this.metroSetLabel_FaveColor.ThemeName = "MetroDark";
            // 
            // metroSetComboBox_FaveColor2
            // 
            this.metroSetComboBox_FaveColor2.AllowDrop = true;
            this.metroSetComboBox_FaveColor2.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetComboBox_FaveColor2.BackColor = System.Drawing.Color.Transparent;
            this.metroSetComboBox_FaveColor2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.metroSetComboBox_FaveColor2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetComboBox_FaveColor2.CausesValidation = false;
            this.metroSetComboBox_FaveColor2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.metroSetComboBox_FaveColor2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetComboBox_FaveColor2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetComboBox_FaveColor2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetComboBox_FaveColor2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroSetComboBox_FaveColor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroSetComboBox_FaveColor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.metroSetComboBox_FaveColor2.FormattingEnabled = true;
            this.metroSetComboBox_FaveColor2.IsDerivedStyle = true;
            this.metroSetComboBox_FaveColor2.ItemHeight = 20;
            this.metroSetComboBox_FaveColor2.Location = new System.Drawing.Point(109, 1043);
            this.metroSetComboBox_FaveColor2.Name = "metroSetComboBox_FaveColor2";
            this.metroSetComboBox_FaveColor2.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetComboBox_FaveColor2.SelectedItemForeColor = System.Drawing.Color.White;
            this.metroSetComboBox_FaveColor2.Size = new System.Drawing.Size(243, 26);
            this.metroSetComboBox_FaveColor2.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetComboBox_FaveColor2.StyleManager = null;
            this.metroSetComboBox_FaveColor2.TabIndex = 84;
            this.metroSetComboBox_FaveColor2.ThemeAuthor = "Narwin";
            this.metroSetComboBox_FaveColor2.ThemeName = "MetroDark";
            // 
            // metroSetLabel_FaveColor2
            // 
            this.metroSetLabel_FaveColor2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetLabel_FaveColor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.metroSetLabel_FaveColor2.IsDerivedStyle = true;
            this.metroSetLabel_FaveColor2.Location = new System.Drawing.Point(3, 1040);
            this.metroSetLabel_FaveColor2.Name = "metroSetLabel_FaveColor2";
            this.metroSetLabel_FaveColor2.Size = new System.Drawing.Size(100, 40);
            this.metroSetLabel_FaveColor2.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel_FaveColor2.StyleManager = null;
            this.metroSetLabel_FaveColor2.TabIndex = 83;
            this.metroSetLabel_FaveColor2.Text = "Fave Color 2:";
            this.metroSetLabel_FaveColor2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel_FaveColor2.ThemeAuthor = "Narwin";
            this.metroSetLabel_FaveColor2.ThemeName = "MetroDark";
            // 
            // metroSetLabel_RemakeID
            // 
            this.metroSetLabel_RemakeID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetLabel_RemakeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.metroSetLabel_RemakeID.IsDerivedStyle = true;
            this.metroSetLabel_RemakeID.Location = new System.Drawing.Point(3, 1080);
            this.metroSetLabel_RemakeID.Name = "metroSetLabel_RemakeID";
            this.metroSetLabel_RemakeID.Size = new System.Drawing.Size(100, 40);
            this.metroSetLabel_RemakeID.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel_RemakeID.StyleManager = null;
            this.metroSetLabel_RemakeID.TabIndex = 85;
            this.metroSetLabel_RemakeID.Text = "Remake ID:";
            this.metroSetLabel_RemakeID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel_RemakeID.ThemeAuthor = "Narwin";
            this.metroSetLabel_RemakeID.ThemeName = "MetroDark";
            // 
            // numeric_RemakeID
            // 
            this.numeric_RemakeID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.numeric_RemakeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeric_RemakeID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numeric_RemakeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numeric_RemakeID.ForeColor = System.Drawing.Color.Silver;
            this.numeric_RemakeID.Location = new System.Drawing.Point(109, 1083);
            this.numeric_RemakeID.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numeric_RemakeID.Name = "numeric_RemakeID";
            this.numeric_RemakeID.Size = new System.Drawing.Size(243, 30);
            this.numeric_RemakeID.TabIndex = 86;
            // 
            // metroSetLabel_NoteLength
            // 
            this.metroSetLabel_NoteLength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetLabel_NoteLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.metroSetLabel_NoteLength.IsDerivedStyle = true;
            this.metroSetLabel_NoteLength.Location = new System.Drawing.Point(3, 1120);
            this.metroSetLabel_NoteLength.Name = "metroSetLabel_NoteLength";
            this.metroSetLabel_NoteLength.Size = new System.Drawing.Size(100, 40);
            this.metroSetLabel_NoteLength.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel_NoteLength.StyleManager = null;
            this.metroSetLabel_NoteLength.TabIndex = 87;
            this.metroSetLabel_NoteLength.Text = "Note Length:";
            this.metroSetLabel_NoteLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel_NoteLength.ThemeAuthor = "Narwin";
            this.metroSetLabel_NoteLength.ThemeName = "MetroDark";
            // 
            // numeric_NoteLength
            // 
            this.numeric_NoteLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.numeric_NoteLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeric_NoteLength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numeric_NoteLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numeric_NoteLength.ForeColor = System.Drawing.Color.Silver;
            this.numeric_NoteLength.Location = new System.Drawing.Point(109, 1123);
            this.numeric_NoteLength.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numeric_NoteLength.Name = "numeric_NoteLength";
            this.numeric_NoteLength.Size = new System.Drawing.Size(243, 30);
            this.numeric_NoteLength.TabIndex = 88;
            this.numeric_NoteLength.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // metroSetComboBox_Melody
            // 
            this.metroSetComboBox_Melody.AllowDrop = true;
            this.metroSetComboBox_Melody.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetComboBox_Melody.BackColor = System.Drawing.Color.Transparent;
            this.metroSetComboBox_Melody.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.metroSetComboBox_Melody.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetComboBox_Melody.CausesValidation = false;
            this.metroSetComboBox_Melody.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.metroSetComboBox_Melody.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetComboBox_Melody.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetComboBox_Melody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetComboBox_Melody.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroSetComboBox_Melody.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroSetComboBox_Melody.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.metroSetComboBox_Melody.FormattingEnabled = true;
            this.metroSetComboBox_Melody.IsDerivedStyle = true;
            this.metroSetComboBox_Melody.ItemHeight = 20;
            this.metroSetComboBox_Melody.Location = new System.Drawing.Point(109, 1163);
            this.metroSetComboBox_Melody.Name = "metroSetComboBox_Melody";
            this.metroSetComboBox_Melody.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetComboBox_Melody.SelectedItemForeColor = System.Drawing.Color.White;
            this.metroSetComboBox_Melody.Size = new System.Drawing.Size(243, 26);
            this.metroSetComboBox_Melody.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetComboBox_Melody.StyleManager = null;
            this.metroSetComboBox_Melody.TabIndex = 90;
            this.metroSetComboBox_Melody.ThemeAuthor = "Narwin";
            this.metroSetComboBox_Melody.ThemeName = "MetroDark";
            // 
            // metroSetLabel_Melody
            // 
            this.metroSetLabel_Melody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetLabel_Melody.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.metroSetLabel_Melody.IsDerivedStyle = true;
            this.metroSetLabel_Melody.Location = new System.Drawing.Point(3, 1160);
            this.metroSetLabel_Melody.Name = "metroSetLabel_Melody";
            this.metroSetLabel_Melody.Size = new System.Drawing.Size(100, 40);
            this.metroSetLabel_Melody.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel_Melody.StyleManager = null;
            this.metroSetLabel_Melody.TabIndex = 89;
            this.metroSetLabel_Melody.Text = "Melody:";
            this.metroSetLabel_Melody.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel_Melody.ThemeAuthor = "Narwin";
            this.metroSetLabel_Melody.ThemeName = "MetroDark";
            // 
            // metroSetComboBox_Melody2
            // 
            this.metroSetComboBox_Melody2.AllowDrop = true;
            this.metroSetComboBox_Melody2.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetComboBox_Melody2.BackColor = System.Drawing.Color.Transparent;
            this.metroSetComboBox_Melody2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.metroSetComboBox_Melody2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetComboBox_Melody2.CausesValidation = false;
            this.metroSetComboBox_Melody2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.metroSetComboBox_Melody2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetComboBox_Melody2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetComboBox_Melody2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetComboBox_Melody2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroSetComboBox_Melody2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroSetComboBox_Melody2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.metroSetComboBox_Melody2.FormattingEnabled = true;
            this.metroSetComboBox_Melody2.IsDerivedStyle = true;
            this.metroSetComboBox_Melody2.ItemHeight = 20;
            this.metroSetComboBox_Melody2.Location = new System.Drawing.Point(109, 1203);
            this.metroSetComboBox_Melody2.Name = "metroSetComboBox_Melody2";
            this.metroSetComboBox_Melody2.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetComboBox_Melody2.SelectedItemForeColor = System.Drawing.Color.White;
            this.metroSetComboBox_Melody2.Size = new System.Drawing.Size(243, 26);
            this.metroSetComboBox_Melody2.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetComboBox_Melody2.StyleManager = null;
            this.metroSetComboBox_Melody2.TabIndex = 91;
            this.metroSetComboBox_Melody2.ThemeAuthor = "Narwin";
            this.metroSetComboBox_Melody2.ThemeName = "MetroDark";
            // 
            // numeric_NPCColor
            // 
            this.numeric_NPCColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.numeric_NPCColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeric_NPCColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numeric_NPCColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numeric_NPCColor.ForeColor = System.Drawing.Color.Silver;
            this.numeric_NPCColor.Location = new System.Drawing.Point(109, 1243);
            this.numeric_NPCColor.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numeric_NPCColor.Name = "numeric_NPCColor";
            this.numeric_NPCColor.Size = new System.Drawing.Size(243, 30);
            this.numeric_NPCColor.TabIndex = 94;
            this.numeric_NPCColor.Value = new decimal(new int[] {
            72,
            0,
            0,
            0});
            // 
            // textBox_Name
            // 
            this.textBox_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox_Name.ForeColor = System.Drawing.Color.Silver;
            this.textBox_Name.Location = new System.Drawing.Point(109, 3);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(243, 32);
            this.textBox_Name.TabIndex = 95;
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(3, 320);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(100, 40);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 97;
            this.metroSetLabel2.Text = "Amiibo:";
            this.metroSetLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroDark";
            // 
            // tabPage_Furniture
            // 
            this.tabPage_Furniture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tabPage_Furniture.Controls.Add(this.panel_Scripting);
            this.tabPage_Furniture.Location = new System.Drawing.Point(4, 42);
            this.tabPage_Furniture.Name = "tabPage_Furniture";
            this.tabPage_Furniture.Size = new System.Drawing.Size(644, 307);
            this.tabPage_Furniture.TabIndex = 1;
            this.tabPage_Furniture.Text = "Furniture";
            // 
            // panel_Scripting
            // 
            this.panel_Scripting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Scripting.Location = new System.Drawing.Point(0, 0);
            this.panel_Scripting.Name = "panel_Scripting";
            this.panel_Scripting.Size = new System.Drawing.Size(644, 307);
            this.panel_Scripting.TabIndex = 3;
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.AutoSize = false;
            this.menuStrip_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.menuStrip_Main.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.writeAllChangesToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip_Main.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip_Main.Location = new System.Drawing.Point(2, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(938, 28);
            this.menuStrip_Main.TabIndex = 2;
            this.menuStrip_Main.Text = "menuStrip_Main";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.loadProjectToolStripMenuItem,
            this.saveProjectToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.fileToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.newProjectToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.newProjectToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(247, 34);
            this.newProjectToolStripMenuItem.Text = "New Project";
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.NewProject_Click);
            // 
            // loadProjectToolStripMenuItem
            // 
            this.loadProjectToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.loadProjectToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.loadProjectToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.loadProjectToolStripMenuItem.Name = "loadProjectToolStripMenuItem";
            this.loadProjectToolStripMenuItem.Size = new System.Drawing.Size(247, 34);
            this.loadProjectToolStripMenuItem.Text = "Load Project";
            this.loadProjectToolStripMenuItem.Click += new System.EventHandler(this.LoadProject_Click);
            // 
            // saveProjectToolStripMenuItem
            // 
            this.saveProjectToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.saveProjectToolStripMenuItem.Enabled = false;
            this.saveProjectToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.saveProjectToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            this.saveProjectToolStripMenuItem.Size = new System.Drawing.Size(247, 34);
            this.saveProjectToolStripMenuItem.Text = "Save Project As...";
            this.saveProjectToolStripMenuItem.Click += new System.EventHandler(this.SaveProjectAs_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.settingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(247, 34);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.Settings_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.exportToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(247, 34);
            this.exportToolStripMenuItem.Text = "Export Mod";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.ExportMod_Click);
            // 
            // writeAllChangesToolStripMenuItem
            // 
            this.writeAllChangesToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.writeAllChangesToolStripMenuItem.Name = "writeAllChangesToolStripMenuItem";
            this.writeAllChangesToolStripMenuItem.Size = new System.Drawing.Size(168, 29);
            this.writeAllChangesToolStripMenuItem.Text = "Write All Changes";
            this.writeAllChangesToolStripMenuItem.Click += new System.EventHandler(this.WriteAllChanges_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventEditorToolStripMenuItem,
            this.nHSEToolStripMenuItem});
            this.toolsToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // eventEditorToolStripMenuItem
            // 
            this.eventEditorToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.eventEditorToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.eventEditorToolStripMenuItem.Name = "eventEditorToolStripMenuItem";
            this.eventEditorToolStripMenuItem.Size = new System.Drawing.Size(209, 34);
            this.eventEditorToolStripMenuItem.Text = "Event Editor";
            this.eventEditorToolStripMenuItem.Click += new System.EventHandler(this.EventEditor_Click);
            // 
            // nHSEToolStripMenuItem
            // 
            this.nHSEToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.nHSEToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.nHSEToolStripMenuItem.Name = "nHSEToolStripMenuItem";
            this.nHSEToolStripMenuItem.Size = new System.Drawing.Size(209, 34);
            this.nHSEToolStripMenuItem.Text = "NHSE";
            this.nHSEToolStripMenuItem.Click += new System.EventHandler(this.NHSE_Click);
            // 
            // contextMenuStrip_Project
            // 
            this.contextMenuStrip_Project.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.contextMenuStrip_Project.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_Project.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_New,
            this.ToolStripMenuItem_Decompile,
            this.ToolStripMenuItem_Compile,
            this.ToolStripMenuItem_Unpack,
            this.ToolStripMenuItem_RepackAs,
            this.ToolStripMenuItem_Replace,
            this.ToolStripMenuItem_Remove,
            this.ToolStripMenuItem_OpenAt2,
            this.ToolStripMenuItem_Copy,
            this.ToolStripMenuItem_Rename,
            this.ToolStripMenuItem_ExpandProj,
            this.ToolStripMenuItem_CollapseProj});
            this.contextMenuStrip_Project.Name = "contextMenuStrip_Game";
            this.contextMenuStrip_Project.Size = new System.Drawing.Size(184, 364);
            // 
            // ToolStripMenuItem_New
            // 
            this.ToolStripMenuItem_New.AutoSize = false;
            this.ToolStripMenuItem_New.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_New.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_NewFolder,
            this.ToolStripMenuItem_NewFlow,
            this.ToolStripMenuItem_NewMsg,
            this.ToolStripMenuItem_NewTxt});
            this.ToolStripMenuItem_New.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_New.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_New.Name = "ToolStripMenuItem_New";
            this.ToolStripMenuItem_New.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItem_New.Text = "New...";
            // 
            // ToolStripMenuItem_NewFolder
            // 
            this.ToolStripMenuItem_NewFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_NewFolder.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_NewFolder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_NewFolder.Name = "ToolStripMenuItem_NewFolder";
            this.ToolStripMenuItem_NewFolder.Size = new System.Drawing.Size(229, 34);
            this.ToolStripMenuItem_NewFolder.Text = "Folder";
            // 
            // ToolStripMenuItem_NewFlow
            // 
            this.ToolStripMenuItem_NewFlow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_NewFlow.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_NewFlow.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_NewFlow.Name = "ToolStripMenuItem_NewFlow";
            this.ToolStripMenuItem_NewFlow.Size = new System.Drawing.Size(229, 34);
            this.ToolStripMenuItem_NewFlow.Text = "FlowScript";
            // 
            // ToolStripMenuItem_NewMsg
            // 
            this.ToolStripMenuItem_NewMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_NewMsg.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_NewMsg.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_NewMsg.Name = "ToolStripMenuItem_NewMsg";
            this.ToolStripMenuItem_NewMsg.Size = new System.Drawing.Size(229, 34);
            this.ToolStripMenuItem_NewMsg.Text = "MessageScript";
            // 
            // ToolStripMenuItem_NewTxt
            // 
            this.ToolStripMenuItem_NewTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_NewTxt.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_NewTxt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_NewTxt.Name = "ToolStripMenuItem_NewTxt";
            this.ToolStripMenuItem_NewTxt.Size = new System.Drawing.Size(229, 34);
            this.ToolStripMenuItem_NewTxt.Text = "Text File";
            // 
            // ToolStripMenuItem_Decompile
            // 
            this.ToolStripMenuItem_Decompile.AutoSize = false;
            this.ToolStripMenuItem_Decompile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_Decompile.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_Decompile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_Decompile.Name = "ToolStripMenuItem_Decompile";
            this.ToolStripMenuItem_Decompile.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItem_Decompile.Text = "Decompile";
            // 
            // ToolStripMenuItem_Compile
            // 
            this.ToolStripMenuItem_Compile.AutoSize = false;
            this.ToolStripMenuItem_Compile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_Compile.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_Compile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_Compile.Name = "ToolStripMenuItem_Compile";
            this.ToolStripMenuItem_Compile.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItem_Compile.Text = "Compile";
            // 
            // ToolStripMenuItem_Unpack
            // 
            this.ToolStripMenuItem_Unpack.AutoSize = false;
            this.ToolStripMenuItem_Unpack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_Unpack.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_Unpack.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_Unpack.Name = "ToolStripMenuItem_Unpack";
            this.ToolStripMenuItem_Unpack.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItem_Unpack.Text = "Unpack";
            // 
            // ToolStripMenuItem_RepackAs
            // 
            this.ToolStripMenuItem_RepackAs.AutoSize = false;
            this.ToolStripMenuItem_RepackAs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_RepackAs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_RepackPAC,
            this.ToolStripMenuItem_RepackAFS,
            this.ToolStripMenuItem_RepackAWB});
            this.ToolStripMenuItem_RepackAs.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_RepackAs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_RepackAs.Name = "ToolStripMenuItem_RepackAs";
            this.ToolStripMenuItem_RepackAs.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItem_RepackAs.Text = "Repack As...";
            // 
            // ToolStripMenuItem_RepackPAC
            // 
            this.ToolStripMenuItem_RepackPAC.AutoSize = false;
            this.ToolStripMenuItem_RepackPAC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_RepackPAC.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_RepackPAC.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_RepackPAC.Name = "ToolStripMenuItem_RepackPAC";
            this.ToolStripMenuItem_RepackPAC.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItem_RepackPAC.Text = "PAC";
            // 
            // ToolStripMenuItem_RepackAFS
            // 
            this.ToolStripMenuItem_RepackAFS.AutoSize = false;
            this.ToolStripMenuItem_RepackAFS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_RepackAFS.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_RepackAFS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_RepackAFS.Name = "ToolStripMenuItem_RepackAFS";
            this.ToolStripMenuItem_RepackAFS.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItem_RepackAFS.Text = "AFS";
            // 
            // ToolStripMenuItem_RepackAWB
            // 
            this.ToolStripMenuItem_RepackAWB.AutoSize = false;
            this.ToolStripMenuItem_RepackAWB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_RepackAWB.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_RepackAWB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_RepackAWB.Name = "ToolStripMenuItem_RepackAWB";
            this.ToolStripMenuItem_RepackAWB.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItem_RepackAWB.Text = "AWB";
            // 
            // ToolStripMenuItem_Replace
            // 
            this.ToolStripMenuItem_Replace.AutoSize = false;
            this.ToolStripMenuItem_Replace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_Replace.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_Replace.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_Replace.Name = "ToolStripMenuItem_Replace";
            this.ToolStripMenuItem_Replace.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItem_Replace.Text = "Replace";
            // 
            // ToolStripMenuItem_Remove
            // 
            this.ToolStripMenuItem_Remove.AutoSize = false;
            this.ToolStripMenuItem_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_Remove.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_Remove.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_Remove.Name = "ToolStripMenuItem_Remove";
            this.ToolStripMenuItem_Remove.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItem_Remove.Text = "Remove";
            this.ToolStripMenuItem_Remove.Click += new System.EventHandler(this.RemoveFromProject_Click);
            // 
            // ToolStripMenuItem_OpenAt2
            // 
            this.ToolStripMenuItem_OpenAt2.AutoSize = false;
            this.ToolStripMenuItem_OpenAt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_OpenAt2.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_OpenAt2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_OpenAt2.Name = "ToolStripMenuItem_OpenAt2";
            this.ToolStripMenuItem_OpenAt2.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItem_OpenAt2.Text = "Show Folder";
            this.ToolStripMenuItem_OpenAt2.Click += new System.EventHandler(this.OpenLocationProject_Click);
            // 
            // ToolStripMenuItem_Copy
            // 
            this.ToolStripMenuItem_Copy.AutoSize = false;
            this.ToolStripMenuItem_Copy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_Copy.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_Copy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_Copy.Name = "ToolStripMenuItem_Copy";
            this.ToolStripMenuItem_Copy.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItem_Copy.Text = "Copy";
            this.ToolStripMenuItem_Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // ToolStripMenuItem_Rename
            // 
            this.ToolStripMenuItem_Rename.AutoSize = false;
            this.ToolStripMenuItem_Rename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_Rename.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_Rename.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_Rename.Name = "ToolStripMenuItem_Rename";
            this.ToolStripMenuItem_Rename.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItem_Rename.Text = "Rename";
            this.ToolStripMenuItem_Rename.Click += new System.EventHandler(this.Rename_Click);
            // 
            // ToolStripMenuItem_ExpandProj
            // 
            this.ToolStripMenuItem_ExpandProj.AutoSize = false;
            this.ToolStripMenuItem_ExpandProj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_ExpandProj.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_ExpandProj.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_ExpandProj.Name = "ToolStripMenuItem_ExpandProj";
            this.ToolStripMenuItem_ExpandProj.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItem_ExpandProj.Text = "Expand All";
            // 
            // ToolStripMenuItem_CollapseProj
            // 
            this.ToolStripMenuItem_CollapseProj.AutoSize = false;
            this.ToolStripMenuItem_CollapseProj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ToolStripMenuItem_CollapseProj.ForeColor = System.Drawing.Color.Silver;
            this.ToolStripMenuItem_CollapseProj.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripMenuItem_CollapseProj.Name = "ToolStripMenuItem_CollapseProj";
            this.ToolStripMenuItem_CollapseProj.Size = new System.Drawing.Size(160, 30);
            this.ToolStripMenuItem_CollapseProj.Text = "Collapse All";
            // 
            // ACNHLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.menuStrip_Main);
            this.Controls.Add(this.tableLayoutPanel_Container);
            this.DropShadowEffect = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.HeaderHeight = -40;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "ACNHLab";
            this.Opacity = 0D;
            this.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.ShowHeader = true;
            this.ShowLeftRect = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.StyleManager = this.styleManager;
            this.Text = "ACNHLab";
            this.ThemeAuthor = "ShrineFox";
            this.ThemeName = "MetroDarkBlue";
            this.tableLayoutPanel_Container.ResumeLayout(false);
            this.tableLayoutPanel_Main.ResumeLayout(false);
            this.metroSetTabControl_GameProject.ResumeLayout(false);
            this.tabPage_Project.ResumeLayout(false);
            this.panel_Workspace.ResumeLayout(false);
            this.tableLayoutPanel_Workspace.ResumeLayout(false);
            this.panel_WorkspaceTabs.ResumeLayout(false);
            this.metroSetTabControl_Workspace.ResumeLayout(false);
            this.tabPage_Villagers.ResumeLayout(false);
            this.tableLayoutPanel_Villagers.ResumeLayout(false);
            this.tableLayoutPanel_Villagers.PerformLayout();
            this.tableLayoutPanel_VillagerList.ResumeLayout(false);
            this.tableLayoutPanel_VillagerList.PerformLayout();
            this.menuStrip_Villagers.ResumeLayout(false);
            this.menuStrip_Villagers.PerformLayout();
            this.tableLayoutPanel_VillagerAddRemove.ResumeLayout(false);
            this.panel_VillagerParams.ResumeLayout(false);
            this.panel_VillagerParams.PerformLayout();
            this.tableLayoutPanel_VillagerParams.ResumeLayout(false);
            this.tableLayoutPanel_VillagerParams.PerformLayout();
            this.tableLayoutPanel_Birthday.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Day)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Month)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_VillagerID)).EndInit();
            this.tableLayoutPanel_VillagerSpeciesAdd.ResumeLayout(false);
            this.tableLayoutPanel_VillagerGender.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_PhotoID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_FloorType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_PosterID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_RainHatID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_RainWearID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_PhonePattern)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_ShirtID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_UmbrellaID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_RemakeID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_NoteLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_NPCColor)).EndInit();
            this.tabPage_Furniture.ResumeLayout(false);
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.contextMenuStrip_Project.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Container;
        private MetroSet_UI.Controls.MetroSetProgressBar metroSetProgressBar_Main;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Main;
        private MetroSet_UI.Controls.MetroSetTabControl metroSetTabControl_GameProject;
        private System.Windows.Forms.TabPage tabPage_Project;
        private System.Windows.Forms.TreeView treeView_Project;
        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private MetroSet_UI.Components.StyleManager styleManager;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Project;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Remove;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_OpenAt2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Rename;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Copy;
        private System.Windows.Forms.ToolStripMenuItem loadProjectToolStripMenuItem;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton_ShowHide;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Decompile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Compile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Unpack;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_RepackAs;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_RepackPAC;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_RepackAFS;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_RepackAWB;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_CollapseProj;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ExpandProj;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_New;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_NewFlow;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_NewMsg;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_NewTxt;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_NewFolder;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Replace;
        private System.Windows.Forms.Panel panel_Workspace;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Workspace;
        private System.Windows.Forms.RichTextBox richTextBox_Status;
        private System.Windows.Forms.Panel panel_WorkspaceTabs;
        private MetroSet_UI.Controls.MetroSetTabControl metroSetTabControl_Workspace;
        private System.Windows.Forms.TabPage tabPage_Villagers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Villagers;
        private System.Windows.Forms.TabPage tabPage_Furniture;
        public System.Windows.Forms.Panel panel_Scripting;
        private System.Windows.Forms.Panel panel_VillagerParams;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_VillagerParams;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel_Catchphrase;
        private MetroSet_UI.Controls.MetroSetComboBox metroSetComboBox_Amiibo;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel_AmiiboSeries;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Birthday;
        private System.Windows.Forms.NumericUpDown numeric_Day;
        private System.Windows.Forms.NumericUpDown numeric_Month;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel_Birthday;
        private MetroSet_UI.Controls.MetroSetComboBox metroSetComboBox_Hobby;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel_Hobby;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel_VillagerSpecies;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel_VillagerName;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel_VillagerID;
        private System.Windows.Forms.NumericUpDown numeric_VillagerID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_VillagerSpeciesAdd;
        private System.Windows.Forms.Button button_AddSpecies;
        private MetroSet_UI.Controls.MetroSetComboBox metroSetComboBox_VillagerSpecies;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel_VillagerGender;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel_Personality;
        private MetroSet_UI.Controls.MetroSetComboBox metroSetComboBox_Personality;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_VillagerGender;
        private MetroSet_UI.Controls.MetroSetRadioButton metroSetRadioButton_TalkType2;
        private MetroSet_UI.Controls.MetroSetRadioButton metroSetRadioButton_TalkType1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel_ClothesType;
        private MetroSet_UI.Controls.MetroSetComboBox metroSetComboBox_ClothesType;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetComboBox metroSetComboBox_Style;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel_Style2;
        private MetroSet_UI.Controls.MetroSetComboBox metroSetComboBox_Style2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel_Unknown1;
        private MetroSet_UI.Controls.MetroSetComboBox metroSetComboBox_Unknown1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel_SocialType;
        private MetroSet_UI.Controls.MetroSetComboBox metroSetComboBox_SocialType;
        private MetroSet_UI.Controls.MetroSetComboBox metroSetComboBox_SingPause;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel_SingPause;
        private MetroSet_UI.Controls.MetroSetComboBox metroSetComboBox_SingRhythm;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel_SingRhythm;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel_PhotoID;
        private System.Windows.Forms.NumericUpDown numeric_PhotoID;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel_FloorType;
        private System.Windows.Forms.NumericUpDown numeric_FloorType;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel_PosterID;
        private System.Windows.Forms.NumericUpDown numeric_PosterID;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel_RainHatID;
        private System.Windows.Forms.NumericUpDown numeric_RainHatID;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel_RainWearID;
        private System.Windows.Forms.NumericUpDown numeric_RainWearID;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel_PhonePattern;
        private System.Windows.Forms.NumericUpDown numeric_PhonePattern;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel_ShirtID;
        private System.Windows.Forms.NumericUpDown numeric_ShirtID;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel_UmbrellaID;
        private System.Windows.Forms.NumericUpDown numeric_UmbrellaID;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel_FaveColor;
        private MetroSet_UI.Controls.MetroSetComboBox metroSetComboBox_FaveColor;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel_FaveColor2;
        private MetroSet_UI.Controls.MetroSetComboBox metroSetComboBox_FaveColor2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel_RemakeID;
        private System.Windows.Forms.NumericUpDown numeric_RemakeID;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel_NoteLength;
        private System.Windows.Forms.NumericUpDown numeric_NoteLength;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel_Melody2;
        private MetroSet_UI.Controls.MetroSetComboBox metroSetComboBox_Melody;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel_Melody;
        private MetroSet_UI.Controls.MetroSetComboBox metroSetComboBox_Melody2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel_NPCColor;
        private System.Windows.Forms.NumericUpDown numeric_NPCColor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_VillagerList;
        private MetroSet_UI.Controls.MetroSetComboBox metroSetComboBox_Villagers;
        private System.Windows.Forms.Panel panel_VillagerImg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_VillagerAddRemove;
        private System.Windows.Forms.Button button_VillagerHouse;
        private System.Windows.Forms.Button btn_RemoveVillager;
        private System.Windows.Forms.Button btn_AddVillager;
        private System.Windows.Forms.MenuStrip menuStrip_Villagers;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem_SaveVillager;
        private System.Windows.Forms.TextBox textBox_Phrase;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.ToolStripMenuItem writeAllChangesToolStripMenuItem;
        private MetroSet_UI.Controls.MetroSetComboBox metroSetComboBox_AmiiboSeries;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nHSEToolStripMenuItem;
    }
}