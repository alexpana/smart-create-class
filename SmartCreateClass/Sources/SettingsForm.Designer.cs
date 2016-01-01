namespace SmartCreateClass.Sources
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SkipFiltersHelpLabel = new System.Windows.Forms.Label();
            this.PrefixHierarchyPathHelp = new System.Windows.Forms.Label();
            this.SkipFiltersSpinner = new System.Windows.Forms.NumericUpDown();
            this.PrefixHierarchyTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SkipFiltersSpinner)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Global Settings";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(-11, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 52);
            this.panel1.TabIndex = 14;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(258, 241);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(80, 27);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(344, 241);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(80, 27);
            this.CancelButton.TabIndex = 16;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(13, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Skip filters in hierarchy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(13, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Prefix hierarchy path";
            // 
            // SkipFiltersHelpLabel
            // 
            this.SkipFiltersHelpLabel.AutoSize = true;
            this.SkipFiltersHelpLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.SkipFiltersHelpLabel.Location = new System.Drawing.Point(13, 97);
            this.SkipFiltersHelpLabel.Name = "SkipFiltersHelpLabel";
            this.SkipFiltersHelpLabel.Size = new System.Drawing.Size(380, 39);
            this.SkipFiltersHelpLabel.TabIndex = 22;
            this.SkipFiltersHelpLabel.Text = resources.GetString("SkipFiltersHelpLabel.Text");
            // 
            // PrefixHierarchyPathHelp
            // 
            this.PrefixHierarchyPathHelp.AutoSize = true;
            this.PrefixHierarchyPathHelp.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.PrefixHierarchyPathHelp.Location = new System.Drawing.Point(13, 191);
            this.PrefixHierarchyPathHelp.Name = "PrefixHierarchyPathHelp";
            this.PrefixHierarchyPathHelp.Size = new System.Drawing.Size(380, 26);
            this.PrefixHierarchyPathHelp.TabIndex = 23;
            this.PrefixHierarchyPathHelp.Text = "This path will be inserted between the solution directory and the path computed\r\n" +
    "from the filter hierarchy.";
            // 
            // SkipFiltersSpinner
            // 
            this.SkipFiltersSpinner.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::SmartCreateClass.Properties.Settings.Default, "skip_filters_count", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SkipFiltersSpinner.Location = new System.Drawing.Point(131, 65);
            this.SkipFiltersSpinner.Name = "SkipFiltersSpinner";
            this.SkipFiltersSpinner.Size = new System.Drawing.Size(61, 20);
            this.SkipFiltersSpinner.TabIndex = 21;
            this.SkipFiltersSpinner.Value = global::SmartCreateClass.Properties.Settings.Default.skip_filters_count;
            // 
            // PrefixHierarchyTextBox
            // 
            this.PrefixHierarchyTextBox.Location = new System.Drawing.Point(134, 158);
            this.PrefixHierarchyTextBox.Name = "PrefixHierarchyTextBox";
            this.PrefixHierarchyTextBox.Size = new System.Drawing.Size(290, 20);
            this.PrefixHierarchyTextBox.TabIndex = 20;
            this.PrefixHierarchyTextBox.Text = global::SmartCreateClass.Properties.Settings.Default.prefix_path;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(433, 280);
            this.ControlBox = false;
            this.Controls.Add(this.PrefixHierarchyPathHelp);
            this.Controls.Add(this.SkipFiltersHelpLabel);
            this.Controls.Add(this.SkipFiltersSpinner);
            this.Controls.Add(this.PrefixHierarchyTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Create Class Settings";
            ((System.ComponentModel.ISupportInitialize)(this.SkipFiltersSpinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PrefixHierarchyTextBox;
        private System.Windows.Forms.NumericUpDown SkipFiltersSpinner;
        private System.Windows.Forms.Label SkipFiltersHelpLabel;
        private System.Windows.Forms.Label PrefixHierarchyPathHelp;
    }
}