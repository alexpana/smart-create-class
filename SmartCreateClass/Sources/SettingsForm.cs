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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.prefix_path = PrefixHierarchyTextBox.Text;
            Properties.Settings.Default.skip_filters_count = SkipFiltersSpinner.Value;
            Properties.Settings.Default.Save();
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
