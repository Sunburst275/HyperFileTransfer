namespace HyperFileTransfer
{
    partial class MainForm
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
            this.DestinationSystemGroupBox = new System.Windows.Forms.GroupBox();
            this.DestinationSystemManualTextBox = new System.Windows.Forms.TextBox();
            this.DestinationSystemManualRadioButton = new System.Windows.Forms.RadioButton();
            this.DestinationSystemAutoComboBox = new System.Windows.Forms.ComboBox();
            this.DestinationSystemAutomaticRadioButton = new System.Windows.Forms.RadioButton();
            this.SourcePathGroupBox = new System.Windows.Forms.GroupBox();
            this.GotoButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.FileListView = new System.Windows.Forms.ListView();
            this.DestinationPathGroupBox = new System.Windows.Forms.GroupBox();
            this.DestinationPathClipboardButton = new System.Windows.Forms.Button();
            this.DestinationPathTextBox = new System.Windows.Forms.TextBox();
            this.OptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.ForceExecutionCheckBox = new System.Windows.Forms.CheckBox();
            this.IsJobCheckBox = new System.Windows.Forms.CheckBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.DestinationPathClearButton = new System.Windows.Forms.Button();
            this.DestinationSystemGroupBox.SuspendLayout();
            this.SourcePathGroupBox.SuspendLayout();
            this.DestinationPathGroupBox.SuspendLayout();
            this.OptionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DestinationSystemGroupBox
            // 
            this.DestinationSystemGroupBox.AutoSize = true;
            this.DestinationSystemGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DestinationSystemGroupBox.Controls.Add(this.DestinationSystemManualTextBox);
            this.DestinationSystemGroupBox.Controls.Add(this.DestinationSystemManualRadioButton);
            this.DestinationSystemGroupBox.Controls.Add(this.DestinationSystemAutoComboBox);
            this.DestinationSystemGroupBox.Controls.Add(this.DestinationSystemAutomaticRadioButton);
            this.DestinationSystemGroupBox.Location = new System.Drawing.Point(12, 378);
            this.DestinationSystemGroupBox.Name = "DestinationSystemGroupBox";
            this.DestinationSystemGroupBox.Size = new System.Drawing.Size(398, 84);
            this.DestinationSystemGroupBox.TabIndex = 0;
            this.DestinationSystemGroupBox.TabStop = false;
            this.DestinationSystemGroupBox.Text = "Destination system";
            // 
            // DestinationSystemManualTextBox
            // 
            this.DestinationSystemManualTextBox.Location = new System.Drawing.Point(212, 45);
            this.DestinationSystemManualTextBox.Name = "DestinationSystemManualTextBox";
            this.DestinationSystemManualTextBox.Size = new System.Drawing.Size(180, 20);
            this.DestinationSystemManualTextBox.TabIndex = 3;
            // 
            // DestinationSystemManualRadioButton
            // 
            this.DestinationSystemManualRadioButton.AutoSize = true;
            this.DestinationSystemManualRadioButton.Location = new System.Drawing.Point(212, 19);
            this.DestinationSystemManualRadioButton.Name = "DestinationSystemManualRadioButton";
            this.DestinationSystemManualRadioButton.Size = new System.Drawing.Size(60, 17);
            this.DestinationSystemManualRadioButton.TabIndex = 2;
            this.DestinationSystemManualRadioButton.TabStop = true;
            this.DestinationSystemManualRadioButton.Text = "Manual";
            this.DestinationSystemManualRadioButton.UseVisualStyleBackColor = true;
            this.DestinationSystemManualRadioButton.CheckedChanged += new System.EventHandler(this.DestinationSystemManualRadioButton_CheckedChanged);
            // 
            // DestinationSystemAutoComboBox
            // 
            this.DestinationSystemAutoComboBox.FormattingEnabled = true;
            this.DestinationSystemAutoComboBox.Location = new System.Drawing.Point(7, 44);
            this.DestinationSystemAutoComboBox.Name = "DestinationSystemAutoComboBox";
            this.DestinationSystemAutoComboBox.Size = new System.Drawing.Size(199, 21);
            this.DestinationSystemAutoComboBox.TabIndex = 1;
            // 
            // DestinationSystemAutomaticRadioButton
            // 
            this.DestinationSystemAutomaticRadioButton.AutoSize = true;
            this.DestinationSystemAutomaticRadioButton.Location = new System.Drawing.Point(7, 20);
            this.DestinationSystemAutomaticRadioButton.Name = "DestinationSystemAutomaticRadioButton";
            this.DestinationSystemAutomaticRadioButton.Size = new System.Drawing.Size(47, 17);
            this.DestinationSystemAutomaticRadioButton.TabIndex = 0;
            this.DestinationSystemAutomaticRadioButton.TabStop = true;
            this.DestinationSystemAutomaticRadioButton.Text = "Auto";
            this.DestinationSystemAutomaticRadioButton.UseVisualStyleBackColor = true;
            this.DestinationSystemAutomaticRadioButton.CheckedChanged += new System.EventHandler(this.DestinationSystemAutomaticRadioButton_CheckedChanged);
            // 
            // SourcePathGroupBox
            // 
            this.SourcePathGroupBox.AutoSize = true;
            this.SourcePathGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SourcePathGroupBox.Controls.Add(this.GotoButton);
            this.SourcePathGroupBox.Controls.Add(this.EditButton);
            this.SourcePathGroupBox.Controls.Add(this.RemoveButton);
            this.SourcePathGroupBox.Controls.Add(this.AddButton);
            this.SourcePathGroupBox.Controls.Add(this.FileListView);
            this.SourcePathGroupBox.Location = new System.Drawing.Point(12, 12);
            this.SourcePathGroupBox.Name = "SourcePathGroupBox";
            this.SourcePathGroupBox.Size = new System.Drawing.Size(408, 267);
            this.SourcePathGroupBox.TabIndex = 1;
            this.SourcePathGroupBox.TabStop = false;
            this.SourcePathGroupBox.Text = "Files";
            // 
            // GotoButton
            // 
            this.GotoButton.Location = new System.Drawing.Point(356, 116);
            this.GotoButton.Name = "GotoButton";
            this.GotoButton.Size = new System.Drawing.Size(46, 26);
            this.GotoButton.TabIndex = 4;
            this.GotoButton.Text = "Go to";
            this.GotoButton.UseVisualStyleBackColor = true;
            this.GotoButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(356, 84);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(46, 26);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(357, 52);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(45, 26);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "-";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(357, 20);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(45, 26);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // FileListView
            // 
            this.FileListView.AccessibleName = "FileListView";
            this.FileListView.GridLines = true;
            this.FileListView.HideSelection = false;
            this.FileListView.Location = new System.Drawing.Point(6, 19);
            this.FileListView.Name = "FileListView";
            this.FileListView.Size = new System.Drawing.Size(344, 229);
            this.FileListView.TabIndex = 0;
            this.FileListView.UseCompatibleStateImageBehavior = false;
            this.FileListView.View = System.Windows.Forms.View.List;
            this.FileListView.SelectedIndexChanged += new System.EventHandler(this.FileListView_SelectedIndexChanged);
            // 
            // DestinationPathGroupBox
            // 
            this.DestinationPathGroupBox.AutoSize = true;
            this.DestinationPathGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DestinationPathGroupBox.Controls.Add(this.DestinationPathClearButton);
            this.DestinationPathGroupBox.Controls.Add(this.DestinationPathClipboardButton);
            this.DestinationPathGroupBox.Controls.Add(this.DestinationPathTextBox);
            this.DestinationPathGroupBox.Location = new System.Drawing.Point(12, 285);
            this.DestinationPathGroupBox.Name = "DestinationPathGroupBox";
            this.DestinationPathGroupBox.Size = new System.Drawing.Size(408, 87);
            this.DestinationPathGroupBox.TabIndex = 2;
            this.DestinationPathGroupBox.TabStop = false;
            this.DestinationPathGroupBox.Text = "Destination path";
            // 
            // DestinationPathClipboardButton
            // 
            this.DestinationPathClipboardButton.Location = new System.Drawing.Point(7, 45);
            this.DestinationPathClipboardButton.Name = "DestinationPathClipboardButton";
            this.DestinationPathClipboardButton.Size = new System.Drawing.Size(137, 23);
            this.DestinationPathClipboardButton.TabIndex = 2;
            this.DestinationPathClipboardButton.Text = "Insert from Clipboard";
            this.DestinationPathClipboardButton.UseVisualStyleBackColor = true;
            this.DestinationPathClipboardButton.Click += new System.EventHandler(this.DestinationPathClipboardButton_Click);
            // 
            // DestinationPathTextBox
            // 
            this.DestinationPathTextBox.Location = new System.Drawing.Point(6, 19);
            this.DestinationPathTextBox.Name = "DestinationPathTextBox";
            this.DestinationPathTextBox.Size = new System.Drawing.Size(396, 20);
            this.DestinationPathTextBox.TabIndex = 2;
            // 
            // OptionsGroupBox
            // 
            this.OptionsGroupBox.AutoSize = true;
            this.OptionsGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OptionsGroupBox.Controls.Add(this.ForceExecutionCheckBox);
            this.OptionsGroupBox.Controls.Add(this.IsJobCheckBox);
            this.OptionsGroupBox.Location = new System.Drawing.Point(12, 468);
            this.OptionsGroupBox.Name = "OptionsGroupBox";
            this.OptionsGroupBox.Size = new System.Drawing.Size(258, 56);
            this.OptionsGroupBox.TabIndex = 3;
            this.OptionsGroupBox.TabStop = false;
            this.OptionsGroupBox.Text = "Options";
            // 
            // ForceExecutionCheckBox
            // 
            this.ForceExecutionCheckBox.AutoSize = true;
            this.ForceExecutionCheckBox.Location = new System.Drawing.Point(150, 20);
            this.ForceExecutionCheckBox.Name = "ForceExecutionCheckBox";
            this.ForceExecutionCheckBox.Size = new System.Drawing.Size(102, 17);
            this.ForceExecutionCheckBox.TabIndex = 1;
            this.ForceExecutionCheckBox.Text = "Force execution";
            this.ForceExecutionCheckBox.UseVisualStyleBackColor = true;
            this.ForceExecutionCheckBox.CheckedChanged += new System.EventHandler(this.ForceExecutionCheckBox_CheckedChanged);
            // 
            // IsJobCheckBox
            // 
            this.IsJobCheckBox.AutoSize = true;
            this.IsJobCheckBox.Location = new System.Drawing.Point(7, 20);
            this.IsJobCheckBox.Name = "IsJobCheckBox";
            this.IsJobCheckBox.Size = new System.Drawing.Size(137, 17);
            this.IsJobCheckBox.TabIndex = 0;
            this.IsJobCheckBox.Text = "Run as background job";
            this.IsJobCheckBox.UseVisualStyleBackColor = true;
            this.IsJobCheckBox.CheckedChanged += new System.EventHandler(this.IsJobCheckBox_CheckedChanged);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(12, 569);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(100, 30);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(322, 569);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(100, 30);
            this.SendButton.TabIndex = 5;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Location = new System.Drawing.Point(118, 569);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(100, 30);
            this.HelpButton.TabIndex = 6;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // DestinationPathClearButton
            // 
            this.DestinationPathClearButton.Location = new System.Drawing.Point(150, 45);
            this.DestinationPathClearButton.Name = "DestinationPathClearButton";
            this.DestinationPathClearButton.Size = new System.Drawing.Size(56, 23);
            this.DestinationPathClearButton.TabIndex = 3;
            this.DestinationPathClearButton.Text = "Clear";
            this.DestinationPathClearButton.UseVisualStyleBackColor = true;
            this.DestinationPathClearButton.Click += new System.EventHandler(this.DestinationPathClearButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 611);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.OptionsGroupBox);
            this.Controls.Add(this.DestinationPathGroupBox);
            this.Controls.Add(this.SourcePathGroupBox);
            this.Controls.Add(this.DestinationSystemGroupBox);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Hyper File Transfer";
            this.DestinationSystemGroupBox.ResumeLayout(false);
            this.DestinationSystemGroupBox.PerformLayout();
            this.SourcePathGroupBox.ResumeLayout(false);
            this.DestinationPathGroupBox.ResumeLayout(false);
            this.DestinationPathGroupBox.PerformLayout();
            this.OptionsGroupBox.ResumeLayout(false);
            this.OptionsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox DestinationSystemGroupBox;
        private System.Windows.Forms.TextBox DestinationSystemManualTextBox;
        private System.Windows.Forms.RadioButton DestinationSystemManualRadioButton;
        private System.Windows.Forms.ComboBox DestinationSystemAutoComboBox;
        private System.Windows.Forms.RadioButton DestinationSystemAutomaticRadioButton;
        private System.Windows.Forms.GroupBox SourcePathGroupBox;
        private System.Windows.Forms.GroupBox DestinationPathGroupBox;
        private System.Windows.Forms.Button DestinationPathClipboardButton;
        private System.Windows.Forms.TextBox DestinationPathTextBox;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListView FileListView;
        private System.Windows.Forms.GroupBox OptionsGroupBox;
        private System.Windows.Forms.CheckBox IsJobCheckBox;
        private System.Windows.Forms.CheckBox ForceExecutionCheckBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Button GotoButton;
        private System.Windows.Forms.Button DestinationPathClearButton;
    }
}

