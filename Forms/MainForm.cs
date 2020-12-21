using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HyperFileTransfer
{
    public partial class MainForm : Form
    {
        #region Variables

        HyperVPowerShell hvps;
        List<string> files;

        #endregion
        #region Constants
        #endregion
        #region Constructors, Initialization
        public MainForm()
        {
            InitializeComponent();

            // Initialize HyperVPowerShell
            hvps = new HyperVPowerShell();
            files = new List<string>();

            // Initialize FileListViewButtons for FileListView
            FileListView_SelectedIndexChanged(this, EventArgs.Empty);

            // Initialize CheckBoxes
            IsJobCheckBox.Checked = hvps.RunInBackground;
            ForceExecutionCheckBox.Checked = hvps.ForceExecution;

            // Initialize RadioButton
            DestinationSystemAutomaticRadioButton.Checked = true;


            // TODO: Initialize ComboBox and add existent VM's

        }
        #endregion
        #region GUI handling

        #region ListView button handling
        private void FileListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveButton.Enabled = !(FileListView.SelectedItems.Count <= 0);
            EditButton.Enabled = GotoButton.Enabled = (FileListView.SelectedItems.Count == 1);
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            using (System.Windows.Forms.OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Set up options
                openFileDialog.InitialDirectory = System.Environment.SpecialFolder.MyDocuments.ToString();
                openFileDialog.DefaultExt = "*";
                openFileDialog.Title = "Please select a file or more";
                openFileDialog.CheckFileExists = true;
                openFileDialog.CheckPathExists = true;
                openFileDialog.Multiselect = true;

                var res = openFileDialog.ShowDialog();
                if (res == DialogResult.Cancel || res == DialogResult.Abort || res == DialogResult.None)
                    return;

                try
                {
                    LockGUI();
                    foreach (string filePath in openFileDialog.FileNames)
                    {
                        this.FileListView.Items.Add(filePath);
                    }
                }
                finally
                {
                    LockGUI(false);
                }
            };
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (FileListView.SelectedItems.Count <= 0) return;

            foreach (ListViewItem item in FileListView.SelectedItems)
            {
                item.Remove();
            }
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            // TODO: Implement...
        }
        private void OpenButton_Click(object sender, EventArgs e)
        {
            if (FileListView.SelectedItems.Count != 1) return;

            string fileAndPath = System.IO.Path.GetFullPath(FileListView.SelectedItems[0].Text);
            string path = System.IO.Path.GetDirectoryName(fileAndPath);

            if (File.Exists(fileAndPath))
            {
                System.Diagnostics.Process.Start("explorer.exe", "/select, " + fileAndPath);
            }

        }
        #endregion
        #region Main button handling
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void HelpButton_Click(object sender, EventArgs e)
        {
            // TODO: Build and show Help-/About-Dialog

            //hvps.Test();
            hvps.GetAccessableVMs();

        }
        private void SendButton_Click(object sender, EventArgs e)
        {
            // Get file path's
            foreach (ListViewItem item in FileListView.Items)
            {
                files.Add(item.Text);
            }

            // Get destination path on destination system
            hvps.DestinationPath = DestinationPathTextBox.Text;

            // Destination system
            if (DestinationSystemAutomaticRadioButton.Checked)
            {
                if (DestinationSystemAutoComboBox.SelectedItem == null)
                {
                    // TODO: Messagebox
                    return;
                }

                hvps.DestinationSystem = DestinationSystemAutoComboBox.SelectedItem.ToString();
            }
            else if (DestinationSystemManualRadioButton.Checked)
            {
                hvps.DestinationSystem = DestinationSystemManualTextBox.Text;
            }

            // Get current settings
            hvps.RunInBackground = IsJobCheckBox.Checked;
            hvps.ForceExecution = ForceExecutionCheckBox.Checked;

            // -----------------------------------------------------------

            // Check for problems and show message
            if(files == null || files.Count <= 0)
            {
                // TODO: Show messagebox
                return;
            }
            if(hvps.DestinationSystem == null || hvps.DestinationSystem == String.Empty /* || "DestinationSystem.Exists" */)
            {
                // TODO: Show messagebox
                return;
            }

            // TODO: Check whether VM exists
            // TODO: Check whether VM is running

            // -----------------------------------------------------------

            Console.WriteLine("--[ Settings: ]-------------------------------------------");
            Console.WriteLine($"DestinationPath\t=\t{hvps.DestinationPath}");
            Console.WriteLine($"DestinationSystem\t=\t{hvps.DestinationSystem}");
            Console.WriteLine($"RunInBackground\t=\t{hvps.RunInBackground}");
            Console.WriteLine($"ForceExecution\t=\t{hvps.ForceExecution}");

            Console.WriteLine("\nSending...");
            int i = 0;
            foreach (string s in files)
            {
                if (!File.Exists(s)) continue; // Skip non-existent files

                StringBuilder sb = new StringBuilder();
                sb.Append($"[{i++}]");
                sb.Append("\t");
                sb.Append("Copy-VMFile");
                sb.Append(" ");
                sb.Append($"\"{hvps.DestinationSystem}\"");
                sb.Append(" ");
                sb.Append($"-SourcePath \"{s}\"");
                sb.Append(" ");
                sb.Append($"-DestinationPath \"{hvps.DestinationPath}\"");
                if (hvps.ForceExecution)
                {
                    sb.Append(" ");
                    sb.Append($"-Force");
                }
                if (hvps.RunInBackground)
                {
                    sb.Append(" ");
                    sb.Append($"-AsJob");
                }
                sb.Append(" ");
                sb.Append("-CreateFullPath -FileSource Host");

                Console.WriteLine(sb.ToString());
            }
            Console.WriteLine("----------------------------------------------------------");


            // Reset file list
            files.Clear();
        }
        #endregion
        #region Destination machine RadioButton handling
        private void DestinationSystemAutomaticRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DestinationSystemRadioButtons_CheckedChanged();
        }
        private void DestinationSystemManualRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DestinationSystemRadioButtons_CheckedChanged();
        }
        private void DestinationSystemRadioButtons_CheckedChanged()
        {
            DestinationSystemAutoComboBox.Enabled = DestinationSystemAutomaticRadioButton.Checked;
            DestinationSystemManualTextBox.Enabled = DestinationSystemManualRadioButton.Checked;
        }
        #endregion
        #region Option CheckBox handling
        private void IsJobCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            hvps.RunInBackground = IsJobCheckBox.Checked;
        }
        private void ForceExecutionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            hvps.ForceExecution = ForceExecutionCheckBox.Checked;
        }
        #endregion
        #region Destination path handling
        private void DestinationPathClipboardButton_Click(object sender, EventArgs e)
        {
            if(Clipboard.ContainsText())
            {
                DestinationPathTextBox.Text = Clipboard.GetText();
            }
        }
        private void DestinationPathClearButton_Click(object sender, EventArgs e)
        {
            if (DestinationPathTextBox.Text != null || DestinationPathTextBox.Text != String.Empty)
                DestinationPathTextBox.Text = string.Empty;
        }
        #endregion

        #endregion
        #region Helper
        private void LockGUI(bool @lock = true)
        {
            if (@lock)
            {
                foreach (Control control in this.Controls)
                {
                    control.Enabled = false;
                }
            }
            else
            {
                foreach (Control control in this.Controls)
                {
                    control.Enabled = true;
                }
            }
        }
        #endregion
        #region Enums, Structs, etc.
        private enum DestinationMachineSelect
        {
            Manual,
            Auto
        }
        #endregion
    }
}
