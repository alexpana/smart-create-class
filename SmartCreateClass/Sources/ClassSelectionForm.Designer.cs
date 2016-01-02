namespace SmartCreateClass.Sources
{
    partial class ClassSelectionForm
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
            this.classNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.classTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.outputDirectoryLabel = new System.Windows.Forms.Label();
            this.SettingsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // classNameTextBox
            // 
            this.classNameTextBox.Location = new System.Drawing.Point(15, 122);
            this.classNameTextBox.Name = "classNameTextBox";
            this.classNameTextBox.Size = new System.Drawing.Size(360, 20);
            this.classNameTextBox.TabIndex = 1;
            this.classNameTextBox.TextChanged += new System.EventHandler(this.classNameTextBox_TextChanged);
            this.classNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.classNameTextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(13, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // createButton
            // 
            this.createButton.Enabled = false;
            this.createButton.Location = new System.Drawing.Point(210, 202);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(80, 27);
            this.createButton.TabIndex = 7;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(296, 202);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(80, 27);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // classTypeComboBox
            // 
            this.classTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classTypeComboBox.FormattingEnabled = true;
            this.classTypeComboBox.Items.AddRange(new object[] {
            "Empty Class",
            "Empty Header/Source pair",
            "Empty Header",
            "Cocos2D Node"});
            this.classTypeComboBox.Location = new System.Drawing.Point(15, 75);
            this.classTypeComboBox.Name = "classTypeComboBox";
            this.classTypeComboBox.Size = new System.Drawing.Size(361, 21);
            this.classTypeComboBox.TabIndex = 5;
            this.classTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.classTypeComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Create Class";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Class Type";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(0, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 52);
            this.panel1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(13, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Output Folder";
            // 
            // outputDirectoryLabel
            // 
            this.outputDirectoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.outputDirectoryLabel.AutoEllipsis = true;
            this.outputDirectoryLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.outputDirectoryLabel.Location = new System.Drawing.Point(13, 180);
            this.outputDirectoryLabel.Name = "outputDirectoryLabel";
            this.outputDirectoryLabel.Size = new System.Drawing.Size(363, 13);
            this.outputDirectoryLabel.TabIndex = 14;
            this.outputDirectoryLabel.Text = "???";
            // 
            // SettingsLinkLabel
            // 
            this.SettingsLinkLabel.AutoSize = true;
            this.SettingsLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.SettingsLinkLabel.Location = new System.Drawing.Point(13, 209);
            this.SettingsLinkLabel.Name = "SettingsLinkLabel";
            this.SettingsLinkLabel.Size = new System.Drawing.Size(45, 13);
            this.SettingsLinkLabel.TabIndex = 15;
            this.SettingsLinkLabel.TabStop = true;
            this.SettingsLinkLabel.Text = "Settings";
            this.SettingsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SettingsLinkLabel_LinkClicked);
            // 
            // ClassSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(384, 241);
            this.ControlBox = false;
            this.Controls.Add(this.SettingsLinkLabel);
            this.Controls.Add(this.outputDirectoryLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.classNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.classTypeComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ClassSelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Class";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox classNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox classTypeComboBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label outputDirectoryLabel;
        private System.Windows.Forms.LinkLabel SettingsLinkLabel;
    }
}