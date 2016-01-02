//DO WHAT THE FUCK YOU WANT TO PUBLIC LICENSE
//            Version 2, December 2004 
//
// Copyright(C) 2004 Sam Hocevar<sam@hocevar.net>
//
//
//Everyone is permitted to copy and distribute verbatim or modified
//
//copies of this license document, and changing it is allowed as long
// as the name is changed.
//
//           DO WHAT THE FUCK YOU WANT TO PUBLIC LICENSE
//  TERMS AND CONDITIONS FOR COPYING, DISTRIBUTION AND MODIFICATION
//
//  0. You just DO WHAT THE FUCK YOU WANT TO.

using SmartCreateClass.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace SmartCreateClass.Sources
{
    public partial class ClassSelectionForm : Form
    {
        private readonly Action<string, string, TemplateType> Callback;
        private readonly string HierarchyPath;
        private readonly string SolutionDirectory;
        private ToolTip OutputDirectoryLabelTooltip;

        public ClassSelectionForm(string SolutionDirectory, string HierarchyPath, Action<string, string, TemplateType> Callback)
        {
            InitializeComponent();

            this.SolutionDirectory = SolutionDirectory;
            this.HierarchyPath = HierarchyPath;
            this.Callback = Callback;

            classTypeComboBox.SelectedIndex = 0;
            classNameTextBox.Focus();

            OutputDirectoryLabelTooltip = new ToolTip();
            OutputDirectoryLabelTooltip.ToolTipIcon = ToolTipIcon.None;
            OutputDirectoryLabelTooltip.IsBalloon = true;
            OutputDirectoryLabelTooltip.AutoPopDelay = 32000;

            UpdateOutputDirectory();
        }

        private void UpdateOutputDirectory()
        {
            var outputDir = GetOutputDir();
            outputDirectoryLabel.Text = outputDir;
            OutputDirectoryLabelTooltip.SetToolTip(outputDirectoryLabel, outputDir);
        }

        private void classNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                createButton.PerformClick();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            Callback(classNameTextBox.Text, GetOutputDir(), getSelectedClassType());
            Close();
        }

        private TemplateType getSelectedClassType()
        {
            switch (classTypeComboBox.SelectedIndex)
            {
                case 0:
                    return TemplateType.EmptyClass;
                case 1:
                    return TemplateType.EmptyHeaderSourcePair;
                case 2:
                    return TemplateType.EmptyHeader;
                case 3:
                    return TemplateType.Cocos2DNode;
            }

            return TemplateType.EmptyHeaderSourcePair;
        }

        private void classNameTextBox_TextChanged(object sender, EventArgs e)
        {
            createButton.Enabled = classNameTextBox.Text.Length > 0;
        }

        private void SettingsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var settingsForm = new SettingsForm();
            settingsForm.FormClosing += OnSettingsFormClosing;
            settingsForm.ShowDialog();
        }

        private void OnSettingsFormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateOutputDirectory();
        }

        private string GetOutputDir()
        {
            return GetOutputDir(SolutionDirectory, HierarchyPath);
        }

        private string GetOutputDir(string SolutionDirectory, string HierarchyPath)
        {
            var FinalHierarchyPath = SkipLeadingFolders(HierarchyPath, (int)Settings.Default.skip_filters_count);
            var OutputDir = Path.Combine(SolutionDirectory, Settings.Default.prefix_path, FinalHierarchyPath);
            return Path.GetFullPath(OutputDir);
        }

        private string SkipLeadingFolders(string Directory, int FolderCount)
        {
            if (FolderCount == 0)
            {
                return Directory;
            }

            var Paths = Directory.Split("\\".ToCharArray(), FolderCount + 1);
            if (Paths.Length > FolderCount)
            {
                return Paths[FolderCount];
            }
            return "";
        }
    }
}