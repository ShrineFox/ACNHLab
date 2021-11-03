
namespace ACNHLab
{
    partial class SpeciesAddForm : MetroSet_UI.Forms.MetroSetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpeciesAddForm));
            this.metroSetLabel_ProjectName = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetTextBox_NewName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.tableLayoutPanel_Settings = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_ProjectName = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.metroSetButton_Cancel = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetButton_Save = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetLabel_Abbreviation = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetTextBox_NewAbbrev = new MetroSet_UI.Controls.MetroSetTextBox();
            this.tableLayoutPanel_Settings.SuspendLayout();
            this.tableLayoutPanel_ProjectName.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroSetLabel_ProjectName
            // 
            this.metroSetLabel_ProjectName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroSetLabel_ProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel_ProjectName.IsDerivedStyle = true;
            this.metroSetLabel_ProjectName.Location = new System.Drawing.Point(54, 5);
            this.metroSetLabel_ProjectName.Name = "metroSetLabel_ProjectName";
            this.metroSetLabel_ProjectName.Size = new System.Drawing.Size(62, 23);
            this.metroSetLabel_ProjectName.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel_ProjectName.StyleManager = null;
            this.metroSetLabel_ProjectName.TabIndex = 25;
            this.metroSetLabel_ProjectName.Text = "Name: ";
            this.metroSetLabel_ProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroSetLabel_ProjectName.ThemeAuthor = "Narwin";
            this.metroSetLabel_ProjectName.ThemeName = "MetroDark";
            // 
            // metroSetTextBox_NewName
            // 
            this.metroSetTextBox_NewName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetTextBox_NewName.AutoCompleteCustomSource = null;
            this.metroSetTextBox_NewName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.metroSetTextBox_NewName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.metroSetTextBox_NewName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetTextBox_NewName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.metroSetTextBox_NewName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetTextBox_NewName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetTextBox_NewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetTextBox_NewName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTextBox_NewName.Image = null;
            this.metroSetTextBox_NewName.IsDerivedStyle = true;
            this.metroSetTextBox_NewName.Lines = null;
            this.metroSetTextBox_NewName.Location = new System.Drawing.Point(122, 3);
            this.metroSetTextBox_NewName.MaxLength = 30;
            this.metroSetTextBox_NewName.Multiline = false;
            this.metroSetTextBox_NewName.Name = "metroSetTextBox_NewName";
            this.metroSetTextBox_NewName.ReadOnly = false;
            this.metroSetTextBox_NewName.Size = new System.Drawing.Size(295, 27);
            this.metroSetTextBox_NewName.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetTextBox_NewName.StyleManager = null;
            this.metroSetTextBox_NewName.TabIndex = 26;
            this.metroSetTextBox_NewName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.metroSetTextBox_NewName.ThemeAuthor = "Narwin";
            this.metroSetTextBox_NewName.ThemeName = "MetroDark";
            this.metroSetTextBox_NewName.UseSystemPasswordChar = false;
            this.metroSetTextBox_NewName.WatermarkText = "";
            // 
            // tableLayoutPanel_Settings
            // 
            this.tableLayoutPanel_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tableLayoutPanel_Settings.ColumnCount = 1;
            this.tableLayoutPanel_Settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_Settings.Controls.Add(this.tableLayoutPanel_ProjectName, 0, 0);
            this.tableLayoutPanel_Settings.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel_Settings.Location = new System.Drawing.Point(13, 14);
            this.tableLayoutPanel_Settings.Name = "tableLayoutPanel_Settings";
            this.tableLayoutPanel_Settings.RowCount = 4;
            this.tableLayoutPanel_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.07921F));
            this.tableLayoutPanel_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.920792F));
            this.tableLayoutPanel_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel_Settings.Size = new System.Drawing.Size(426, 124);
            this.tableLayoutPanel_Settings.TabIndex = 28;
            // 
            // tableLayoutPanel_ProjectName
            // 
            this.tableLayoutPanel_ProjectName.ColumnCount = 2;
            this.tableLayoutPanel_ProjectName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.33333F));
            this.tableLayoutPanel_ProjectName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.66666F));
            this.tableLayoutPanel_ProjectName.Controls.Add(this.metroSetLabel_Abbreviation, 0, 1);
            this.tableLayoutPanel_ProjectName.Controls.Add(this.metroSetTextBox_NewName, 1, 0);
            this.tableLayoutPanel_ProjectName.Controls.Add(this.metroSetLabel_ProjectName, 0, 0);
            this.tableLayoutPanel_ProjectName.Controls.Add(this.metroSetTextBox_NewAbbrev, 1, 1);
            this.tableLayoutPanel_ProjectName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_ProjectName.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_ProjectName.Name = "tableLayoutPanel_ProjectName";
            this.tableLayoutPanel_ProjectName.RowCount = 2;
            this.tableLayoutPanel_ProjectName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_ProjectName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_ProjectName.Size = new System.Drawing.Size(420, 67);
            this.tableLayoutPanel_ProjectName.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.metroSetButton_Cancel, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.metroSetButton_Save, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 91);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(420, 30);
            this.tableLayoutPanel3.TabIndex = 34;
            // 
            // metroSetButton_Cancel
            // 
            this.metroSetButton_Cancel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_Cancel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_Cancel.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetButton_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetButton_Cancel.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton_Cancel.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton_Cancel.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton_Cancel.IsDerivedStyle = true;
            this.metroSetButton_Cancel.Location = new System.Drawing.Point(255, 3);
            this.metroSetButton_Cancel.Name = "metroSetButton_Cancel";
            this.metroSetButton_Cancel.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_Cancel.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_Cancel.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton_Cancel.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton_Cancel.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton_Cancel.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton_Cancel.Size = new System.Drawing.Size(78, 24);
            this.metroSetButton_Cancel.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetButton_Cancel.StyleManager = null;
            this.metroSetButton_Cancel.TabIndex = 0;
            this.metroSetButton_Cancel.Text = "Cancel";
            this.metroSetButton_Cancel.ThemeAuthor = "Narwin";
            this.metroSetButton_Cancel.ThemeName = "MetroDark";
            this.metroSetButton_Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // metroSetButton_Save
            // 
            this.metroSetButton_Save.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_Save.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_Save.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton_Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetButton_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetButton_Save.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton_Save.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton_Save.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton_Save.IsDerivedStyle = true;
            this.metroSetButton_Save.Location = new System.Drawing.Point(339, 3);
            this.metroSetButton_Save.Name = "metroSetButton_Save";
            this.metroSetButton_Save.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_Save.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton_Save.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton_Save.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton_Save.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton_Save.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton_Save.Size = new System.Drawing.Size(78, 24);
            this.metroSetButton_Save.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetButton_Save.StyleManager = null;
            this.metroSetButton_Save.TabIndex = 1;
            this.metroSetButton_Save.Text = "Save";
            this.metroSetButton_Save.ThemeAuthor = "Narwin";
            this.metroSetButton_Save.ThemeName = "MetroDark";
            this.metroSetButton_Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // metroSetLabel_Abbreviation
            // 
            this.metroSetLabel_Abbreviation.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroSetLabel_Abbreviation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel_Abbreviation.IsDerivedStyle = true;
            this.metroSetLabel_Abbreviation.Location = new System.Drawing.Point(10, 38);
            this.metroSetLabel_Abbreviation.Name = "metroSetLabel_Abbreviation";
            this.metroSetLabel_Abbreviation.Size = new System.Drawing.Size(106, 23);
            this.metroSetLabel_Abbreviation.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel_Abbreviation.StyleManager = null;
            this.metroSetLabel_Abbreviation.TabIndex = 27;
            this.metroSetLabel_Abbreviation.Text = "Abbreviation: ";
            this.metroSetLabel_Abbreviation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroSetLabel_Abbreviation.ThemeAuthor = "Narwin";
            this.metroSetLabel_Abbreviation.ThemeName = "MetroDark";
            // 
            // metroSetTextBox_NewAbbrev
            // 
            this.metroSetTextBox_NewAbbrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetTextBox_NewAbbrev.AutoCompleteCustomSource = null;
            this.metroSetTextBox_NewAbbrev.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.metroSetTextBox_NewAbbrev.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.metroSetTextBox_NewAbbrev.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetTextBox_NewAbbrev.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.metroSetTextBox_NewAbbrev.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetTextBox_NewAbbrev.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetTextBox_NewAbbrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetTextBox_NewAbbrev.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetTextBox_NewAbbrev.Image = null;
            this.metroSetTextBox_NewAbbrev.IsDerivedStyle = true;
            this.metroSetTextBox_NewAbbrev.Lines = null;
            this.metroSetTextBox_NewAbbrev.Location = new System.Drawing.Point(122, 36);
            this.metroSetTextBox_NewAbbrev.MaxLength = 3;
            this.metroSetTextBox_NewAbbrev.Multiline = false;
            this.metroSetTextBox_NewAbbrev.Name = "metroSetTextBox_NewAbbrev";
            this.metroSetTextBox_NewAbbrev.ReadOnly = false;
            this.metroSetTextBox_NewAbbrev.Size = new System.Drawing.Size(295, 27);
            this.metroSetTextBox_NewAbbrev.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetTextBox_NewAbbrev.StyleManager = null;
            this.metroSetTextBox_NewAbbrev.TabIndex = 28;
            this.metroSetTextBox_NewAbbrev.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.metroSetTextBox_NewAbbrev.ThemeAuthor = "Narwin";
            this.metroSetTextBox_NewAbbrev.ThemeName = "MetroDark";
            this.metroSetTextBox_NewAbbrev.UseSystemPasswordChar = false;
            this.metroSetTextBox_NewAbbrev.WatermarkText = "";
            // 
            // SpeciesAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BorderThickness = 0F;
            this.ClientSize = new System.Drawing.Size(452, 160);
            this.Controls.Add(this.tableLayoutPanel_Settings);
            this.DropShadowEffect = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.HeaderHeight = -40;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SpeciesAddForm";
            this.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.ShowHeader = true;
            this.ShowLeftRect = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.Text = "ACNHLab - Add Species";
            this.ThemeName = "MetroDark";
            this.tableLayoutPanel_Settings.ResumeLayout(false);
            this.tableLayoutPanel_ProjectName.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel_ProjectName;
        private MetroSet_UI.Controls.MetroSetTextBox metroSetTextBox_NewName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Settings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_ProjectName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton_Cancel;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton_Save;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel_Abbreviation;
        private MetroSet_UI.Controls.MetroSetTextBox metroSetTextBox_NewAbbrev;
    }
}