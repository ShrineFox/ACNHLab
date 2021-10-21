using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace ACNHLab
{
    public partial class SettingsForm : MetroSet_UI.Forms.MetroSetForm
    {
        #region SettingsObjectDefinition
        /* Setting up Settings object */
        public static Settings settings { get; set; } = new Settings();
        public class Settings
        {
            public string ProjectName { get; set; } = "";
            public string ProjectPath { get; set; } = "";
            public string Version { get; set; } = "";
            public string ExtractedPath { get; set; } = "";
            public string OutputPath { get; set; } = "";
        }
        #endregion

        public SettingsForm()
        {
            InitializeComponent();
            // Load settings
            // Use defaults and allow project name/game entry if no settingsPath exists
            if (File.Exists(settings.ProjectPath))
            {
                LoadSettings();
                UpdateForm();
            }
            else
            {
                metroSetTextBox_ProjectName.Enabled = true;
                metroSetComboBox_Version.Enabled = true;
                metroSetComboBox_Version.SelectedIndex = 0;
            }
        }

        #region FormEvents
        /* Form Interaction Events */
        private void Save_Click(object sender, EventArgs e)
        {
            // Commit form changes to settings object
            UpdateSettings();

            // Make sure project path is valid and can be created
            if (settings.ProjectName != "" && Regex.IsMatch(settings.ProjectName, "^[a-zA-Z0-9-_ .]*$"))
            {
                // Save project YML file
                settings.ProjectPath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), $"Projects\\{settings.ProjectName}\\{settings.ProjectName}.yml");
                Directory.CreateDirectory(Path.GetDirectoryName(settings.ProjectPath));
                SaveSettings();
                this.DialogResult = DialogResult.OK;
                this.Close();
                // Copy initial files to project
                Unpacker.GetFiles();
                // Populate villager editor
            }
            else
            {
                MessageBox.Show(this, "Project Name can't be empty,\n" +
                    "and must only include alphanumeric characters!",
                    "Warning: Invalid Project Name",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                settings.ProjectName = "";
            }
        }

        private void OutputPath_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            dialog.Title = "Choose Output Folder...";
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                settings.OutputPath = dialog.FileName;
                metroSetTextBox_Output.Text = settings.OutputPath;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ExtractedPath_Click(object sender, MouseEventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            dialog.Title = "Choose Extracted ISO/PKG Folder...";
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                settings.ExtractedPath = dialog.FileName;
                metroSetTextBox_Extracted.Text = settings.ExtractedPath;
            }
        }
        #endregion

        #region Utilities
        /* Settings Form Utilities */
        private void UpdateSettings()
        {
            settings.ProjectName = metroSetTextBox_ProjectName.Text;
            settings.Version = metroSetComboBox_Version.SelectedItem.ToString();
            settings.ExtractedPath = metroSetTextBox_Extracted.Text;
            settings.OutputPath = metroSetTextBox_Output.Text;
        }

        private void UpdateForm()
        {
            metroSetTextBox_ProjectName.Text = settings.ProjectName;
            metroSetComboBox_Version.SelectedIndex = metroSetComboBox_Version.Items.IndexOf(settings.Version);
            metroSetTextBox_Extracted.Text = settings.ExtractedPath;
            metroSetTextBox_Output.Text = settings.OutputPath;
        }

        public static void SaveSettings()
        {
            var serializer = new SerializerBuilder().WithNamingConvention(PascalCaseNamingConvention.Instance).Build();
            var yaml = serializer.Serialize(settings);
            using (Tools.WaitForFile(settings.ProjectPath, FileMode.Open, FileAccess.ReadWrite, FileShare.None)) { };
            File.WriteAllText(settings.ProjectPath, yaml);

            MessageBox.Show($"Saved project as \"{settings.ProjectName}\"!", "Project Saved",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadSettings()
        {
            var deserializer = new DeserializerBuilder().WithNamingConvention(PascalCaseNamingConvention.Instance).Build();
            settings = deserializer.Deserialize<Settings>(File.ReadAllText(settings.ProjectPath));
        }

        public static bool IsValid()
        {
            if (!Directory.Exists(settings.ExtractedPath))
            {
                Program.status.Update("[ERROR] Failed to load project: invalid Extracted Path");
                return false;
            }
            if (settings.ProjectName == "" || !Regex.IsMatch(settings.ProjectName, "^[a-zA-Z0-9-_ .]*$"))
            {
                Program.status.Update("[ERROR] Failed to load project: invalid Project Name");
                return false;
            }
            if (!Directory.Exists(settings.OutputPath))
            {
                Program.status.Update("[ERROR] Failed to load project: invalid Output Path");
                return false;
            }

            Program.status.Update($"[INFO] Successfully loaded project: \"{settings.ProjectName}\"");
            return true;
        }
        #endregion
    }
}
