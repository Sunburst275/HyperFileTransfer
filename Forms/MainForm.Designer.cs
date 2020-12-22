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
            this.DestinationPathClearButton = new System.Windows.Forms.Button();
            this.DestinationPathClipboardButton = new System.Windows.Forms.Button();
            this.DestinationPathTextBox = new System.Windows.Forms.TextBox();
            this.OptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.ForceExecutionCheckBox = new System.Windows.Forms.CheckBox();
            this.IsJobCheckBox = new System.Windows.Forms.CheckBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.DestinationSystemAutoRefreshButton = new System.Windows.Forms.Button();
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
            this.DestinationSystemGroupBox.Controls.Add(this.DestinationSystemAutoRefreshButton);
            this.DestinationSystemGroupBox.Controls.Add(this.DestinationSystemManualTextBox);
            this.DestinationSystemGroupBox.Controls.Add(this.DestinationSystemManualRadioButton);
            this.DestinationSystemGroupBox.Controls.Add(this.DestinationSystemAutoComboBox);
            this.DestinationSystemGroupBox.Controls.Add(this.DestinationSystemAutomaticRadioButton);
            this.DestinationSystemGroupBox.Location = new System.Drawing.Point(16, 465);
            this.DestinationSystemGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DestinationSystemGroupBox.Name = "DestinationSystemGroupBox";
            this.DestinationSystemGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DestinationSystemGroupBox.Size = new System.Drawing.Size(530, 101);
            this.DestinationSystemGroupBox.TabIndex = 0;
            this.DestinationSystemGroupBox.TabStop = false;
            this.DestinationSystemGroupBox.Text = "Destination system";
            // 
            // DestinationSystemManualTextBox
            // 
            this.DestinationSystemManualTextBox.Location = new System.Drawing.Point(283, 55);
            this.DestinationSystemManualTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DestinationSystemManualTextBox.Name = "DestinationSystemManualTextBox";
            this.DestinationSystemManualTextBox.Size = new System.Drawing.Size(239, 22);
            this.DestinationSystemManualTextBox.TabIndex = 3;
            // 
            // DestinationSystemManualRadioButton
            // 
            this.DestinationSystemManualRadioButton.AutoSize = true;
            this.DestinationSystemManualRadioButton.Location = new System.Drawing.Point(283, 23);
            this.DestinationSystemManualRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DestinationSystemManualRadioButton.Name = "DestinationSystemManualRadioButton";
            this.DestinationSystemManualRadioButton.Size = new System.Drawing.Size(75, 21);
            this.DestinationSystemManualRadioButton.TabIndex = 2;
            this.DestinationSystemManualRadioButton.TabStop = true;
            this.DestinationSystemManualRadioButton.Text = "Manual";
            this.DestinationSystemManualRadioButton.UseVisualStyleBackColor = true;
            this.DestinationSystemManualRadioButton.CheckedChanged += new System.EventHandler(this.DestinationSystemManualRadioButton_CheckedChanged);
            // 
            // DestinationSystemAutoComboBox
            // 
            this.DestinationSystemAutoComboBox.FormattingEnabled = true;
            this.DestinationSystemAutoComboBox.Location = new System.Drawing.Point(9, 54);
            this.DestinationSystemAutoComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DestinationSystemAutoComboBox.Name = "DestinationSystemAutoComboBox";
            this.DestinationSystemAutoComboBox.Size = new System.Drawing.Size(264, 24);
            this.DestinationSystemAutoComboBox.TabIndex = 1;
            // 
            // DestinationSystemAutomaticRadioButton
            // 
            this.DestinationSystemAutomaticRadioButton.AutoSize = true;
            this.DestinationSystemAutomaticRadioButton.Location = new System.Drawing.Point(9, 25);
            this.DestinationSystemAutomaticRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DestinationSystemAutomaticRadioButton.Name = "DestinationSystemAutomaticRadioButton";
            this.DestinationSystemAutomaticRadioButton.Size = new System.Drawing.Size(58, 21);
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
            this.SourcePathGroupBox.Location = new System.Drawing.Point(16, 15);
            this.SourcePathGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SourcePathGroupBox.Name = "SourcePathGroupBox";
            this.SourcePathGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SourcePathGroupBox.Size = new System.Drawing.Size(544, 327);
            this.SourcePathGroupBox.TabIndex = 1;
            this.SourcePathGroupBox.TabStop = false;
            this.SourcePathGroupBox.Text = "Files";
            // 
            // GotoButton
            // 
            this.GotoButton.Location = new System.Drawing.Point(475, 143);
            this.GotoButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GotoButton.Name = "GotoButton";
            this.GotoButton.Size = new System.Drawing.Size(61, 32);
            this.GotoButton.TabIndex = 4;
            this.GotoButton.Text = "Go to";
            this.GotoButton.UseVisualStyleBackColor = true;
            this.GotoButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(475, 103);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(61, 32);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(476, 64);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(60, 32);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "-";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(476, 25);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(60, 32);
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
            this.FileListView.Location = new System.Drawing.Point(8, 23);
            this.FileListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FileListView.Name = "FileListView";
            this.FileListView.Size = new System.Drawing.Size(457, 281);
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
            this.DestinationPathGroupBox.Location = new System.Drawing.Point(16, 351);
            this.DestinationPathGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DestinationPathGroupBox.Name = "DestinationPathGroupBox";
            this.DestinationPathGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DestinationPathGroupBox.Size = new System.Drawing.Size(543, 106);
            this.DestinationPathGroupBox.TabIndex = 2;
            this.DestinationPathGroupBox.TabStop = false;
            this.DestinationPathGroupBox.Text = "Destination path";
            // 
            // DestinationPathClearButton
            // 
            this.DestinationPathClearButton.Location = new System.Drawing.Point(200, 55);
            this.DestinationPathClearButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DestinationPathClearButton.Name = "DestinationPathClearButton";
            this.DestinationPathClearButton.Size = new System.Drawing.Size(75, 28);
            this.DestinationPathClearButton.TabIndex = 3;
            this.DestinationPathClearButton.Text = "Clear";
            this.DestinationPathClearButton.UseVisualStyleBackColor = true;
            this.DestinationPathClearButton.Click += new System.EventHandler(this.DestinationPathClearButton_Click);
            // 
            // DestinationPathClipboardButton
            // 
            this.DestinationPathClipboardButton.Location = new System.Drawing.Point(9, 55);
            this.DestinationPathClipboardButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DestinationPathClipboardButton.Name = "DestinationPathClipboardButton";
            this.DestinationPathClipboardButton.Size = new System.Drawing.Size(183, 28);
            this.DestinationPathClipboardButton.TabIndex = 2;
            this.DestinationPathClipboardButton.Text = "Insert from Clipboard";
            this.DestinationPathClipboardButton.UseVisualStyleBackColor = true;
            this.DestinationPathClipboardButton.Click += new System.EventHandler(this.DestinationPathClipboardButton_Click);
            // 
            // DestinationPathTextBox
            // 
            this.DestinationPathTextBox.Location = new System.Drawing.Point(8, 23);
            this.DestinationPathTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DestinationPathTextBox.Name = "DestinationPathTextBox";
            this.DestinationPathTextBox.Size = new System.Drawing.Size(527, 22);
            this.DestinationPathTextBox.TabIndex = 2;
            // 
            // OptionsGroupBox
            // 
            this.OptionsGroupBox.AutoSize = true;
            this.OptionsGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OptionsGroupBox.Controls.Add(this.ForceExecutionCheckBox);
            this.OptionsGroupBox.Controls.Add(this.IsJobCheckBox);
            this.OptionsGroupBox.Location = new System.Drawing.Point(16, 576);
            this.OptionsGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OptionsGroupBox.Name = "OptionsGroupBox";
            this.OptionsGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OptionsGroupBox.Size = new System.Drawing.Size(338, 69);
            this.OptionsGroupBox.TabIndex = 3;
            this.OptionsGroupBox.TabStop = false;
            this.OptionsGroupBox.Text = "Options";
            // 
            // ForceExecutionCheckBox
            // 
            this.ForceExecutionCheckBox.AutoSize = true;
            this.ForceExecutionCheckBox.Location = new System.Drawing.Point(200, 25);
            this.ForceExecutionCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ForceExecutionCheckBox.Name = "ForceExecutionCheckBox";
            this.ForceExecutionCheckBox.Size = new System.Drawing.Size(130, 21);
            this.ForceExecutionCheckBox.TabIndex = 1;
            this.ForceExecutionCheckBox.Text = "Force execution";
            this.ForceExecutionCheckBox.UseVisualStyleBackColor = true;
            this.ForceExecutionCheckBox.CheckedChanged += new System.EventHandler(this.ForceExecutionCheckBox_CheckedChanged);
            // 
            // IsJobCheckBox
            // 
            this.IsJobCheckBox.AutoSize = true;
            this.IsJobCheckBox.Location = new System.Drawing.Point(9, 25);
            this.IsJobCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IsJobCheckBox.Name = "IsJobCheckBox";
            this.IsJobCheckBox.Size = new System.Drawing.Size(177, 21);
            this.IsJobCheckBox.TabIndex = 0;
            this.IsJobCheckBox.Text = "Run as background job";
            this.IsJobCheckBox.UseVisualStyleBackColor = true;
            this.IsJobCheckBox.CheckedChanged += new System.EventHandler(this.IsJobCheckBox_CheckedChanged);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(16, 700);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(133, 37);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(429, 700);
            this.SendButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(133, 37);
            this.SendButton.TabIndex = 5;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Location = new System.Drawing.Point(157, 700);
            this.HelpButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(133, 37);
            this.HelpButton.TabIndex = 6;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // DestinationSystemAutoRefreshButton
            // 
            this.DestinationSystemAutoRefreshButton.Location = new System.Drawing.Point(198, 21);
            this.DestinationSystemAutoRefreshButton.Name = "DestinationSystemAutoRefreshButton";
            this.DestinationSystemAutoRefreshButton.Size = new System.Drawing.Size(75, 28);
            this.DestinationSystemAutoRefreshButton.TabIndex = 4;
            this.DestinationSystemAutoRefreshButton.Text = "Refresh";
            this.DestinationSystemAutoRefreshButton.UseVisualStyleBackColor = true;
            this.DestinationSystemAutoRefreshButton.Click += new System.EventHandler(this.DestinationSystemAutoRefreshButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 752);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.OptionsGroupBox);
            this.Controls.Add(this.DestinationPathGroupBox);
            this.Controls.Add(this.SourcePathGroupBox);
            this.Controls.Add(this.DestinationSystemGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button DestinationSystemAutoRefreshButton;
    }
}

