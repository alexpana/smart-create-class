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

using System;
using System.Windows.Forms;

namespace SmartCreateClass.Sources
{
    public partial class ClassSelectionForm : Form
    {
        private readonly Action<string, string, ClassType> callbackAction;
        private readonly string outputDirectory;

        public ClassSelectionForm(string outputDirectory, Action<string, string, ClassType> callback)
        {
            InitializeComponent();

            callbackAction = callback;
            this.outputDirectory = outputDirectory;

            classTypeComboBox.SelectedIndex = 0;
            classNameTextBox.Focus();
            outputDirectoryLabel.Text = outputDirectory;
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
            Dispose(true);
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            callbackAction(classNameTextBox.Text, outputDirectory, getSelectedClassType());
            Dispose(true);
        }

        private ClassType getSelectedClassType()
        {
            switch (classTypeComboBox.SelectedIndex)
            {
                case 0:
                    return ClassType.COCOS_2D_NODE;
                case 1:
                    return ClassType.EMPTY_CLASS;
                case 2:
                    return ClassType.EMPTY_FILES;
            }

            return ClassType.EMPTY_FILES;
        }

        private void classNameTextBox_TextChanged(object sender, EventArgs e)
        {
            createButton.Enabled = classNameTextBox.Text.Length > 0;
        }
    }
}