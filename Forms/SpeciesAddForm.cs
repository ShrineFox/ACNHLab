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
    public partial class SpeciesAddForm : MetroSet_UI.Forms.MetroSetForm
    {
        public string SpeciesName
        {
            get;
            private set;
        }
        public string SpeciesAbbreviation
        {
            get;
            private set;
        }

        public SpeciesAddForm()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            // Make sure name is valid and can be created
            if (metroSetTextBox_NewName.Text != "" && Regex.IsMatch(metroSetTextBox_NewName.Text, "^[a-zA-Z0-9-_ .]*$") &&
                metroSetTextBox_NewAbbrev.Text != "" && Regex.IsMatch(metroSetTextBox_NewName.Text, "^[a-zA-Z0-9-_ .]*$"))
            {
                if (metroSetTextBox_NewAbbrev.Text.Length == 3)
                {
                    SpeciesName = metroSetTextBox_NewName.Text.ToLower();
                    SpeciesAbbreviation = metroSetTextBox_NewAbbrev.Text.ToLower();

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show(this, "Abbreviation must be at least 3 characters long!",
                    "Warning: Abbreviation Too Short",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(this, "Name and Abbreviation can't be empty,\n" +
                    "and must only include alphanumeric characters!",
                    "Warning: Invalid Name or Abbreviation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
