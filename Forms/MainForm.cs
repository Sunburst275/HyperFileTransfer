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
        string[] accessibleVMs;

        #endregion
        #region Constants
        #endregion
        #region Constructors, Initialization
        public MainForm()
        {
            InitializeComponent();

            // Initialize HyperVPowerShell
            hvps = new HyperVPowerShell();
            hvps.NoVmsAccessible += Hvps_NoVmsAccessible;
            hvps.UserDeclinedCmdAdminRights += Hvps_UserDeclinedCmdAdminRights;
            files = new List<string>();

            // Initialize FileListViewButtons for FileListView
            FileListView_SelectedIndexChanged(this, EventArgs.Empty);

            // Initialize CheckBoxes
            IsJobCheckBox.Checked = hvps.RunInBackground;
            ForceExecutionCheckBox.Checked = hvps.ForceExecution;

            // Initialize RadioButton
            DestinationSystemAutomaticRadioButton.Checked = true;

            // Initialize ComboBox and add existent VM's
            accessibleVMs = hvps.GetAccessibleVMs();
            RefreshDestinationSystemAutoComboBox();
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

            hvps.Test();

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
            bool noDestinationSystemChosen = false;
            if (DestinationSystemAutomaticRadioButton.Checked)
            {
                if (DestinationSystemAutoComboBox.SelectedItem == null ||
                    string.IsNullOrEmpty(DestinationSystemAutoComboBox.SelectedItem.ToString()))
                {
                    noDestinationSystemChosen = true;
                }
                else
                {
                    hvps.DestinationSystem = DestinationSystemAutoComboBox.SelectedItem.ToString();
                }
            }
            else if (DestinationSystemManualRadioButton.Checked)
            {
                if (string.IsNullOrEmpty(DestinationSystemManualTextBox.Text))
                {
                    noDestinationSystemChosen = true;
                }
                else
                {
                    hvps.DestinationSystem = DestinationSystemManualTextBox.Text;
                }
            }

            // Get current settings
            hvps.RunInBackground = IsJobCheckBox.Checked;
            hvps.ForceExecution = ForceExecutionCheckBox.Checked;

            // ------------------------------------------------------------------------------------
            // Check for problems and show messages accordingly
            if (files == null || files.Count <= 0)
            {
                MessageBox.Show("No file(s) selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (hvps.DestinationSystem == null || hvps.DestinationSystem == String.Empty)
            {
                MessageBox.Show("The destination system is not available.", "System not available", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (noDestinationSystemChosen)
            {
                MessageBox.Show("You did not select any destination System.", "System not selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // Check whether DestinationSystem exists
            bool systemAccessible = false;
            foreach (string system in accessibleVMs)
            {
                if (system.Equals(hvps.DestinationSystem))
                {
                    systemAccessible = true;
                    break;
                }
            }
            if (!systemAccessible)
            {
                MessageBox.Show("The selected destination system is not available.", "System not selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // ------------------------------------------------------------------------------------
            // DGB: Theoretical settings and possibilities
            //Console.WriteLine("--[ Settings: ]-------------------------------------------");
            //Console.WriteLine($"DestinationPath\t=\t{hvps.DestinationPath}");
            //Console.WriteLine($"DestinationSystem\t=\t{hvps.DestinationSystem}");
            //Console.WriteLine($"RunInBackground\t=\t{hvps.RunInBackground}");
            //Console.WriteLine($"ForceExecution\t=\t{hvps.ForceExecution}");

            int i = 0;
            bool success = true;
            foreach (string s in files)
            {
                if (!File.Exists(s)) continue;  // Skip non-existent files
                try
                {
                    hvps.SendFile(s);
                }
                catch (Exception) // TODO: Catch custom exception // Create exception!
                {
                    success = false;
                }
            }

            // Reset file list
            files.Clear();

            // Send files
            if (success)
            {
                var res = MessageBox.Show("File(s) sent successfully. Do you want to clear the file list?",
                    "Success",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    FileListView.Items.Clear();
                }
            }
            else
            {
                // TODO: Messagebox "error occured"
            }
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
        private void DestinationSystemAutoRefreshButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("This action can take some time.\nPlease accept the cmd prompt to execute as administator and be patient.\nDo you want to continue?",
                "Refresh VM list",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                accessibleVMs = hvps.GetAccessibleVMs();
                RefreshDestinationSystemAutoComboBox();
            }
        }
        private void RefreshDestinationSystemAutoComboBox()
        {
            DestinationSystemAutoComboBox.Items.Clear();
            if (accessibleVMs == null) return;
            foreach (string vm in accessibleVMs)
            {
                DestinationSystemAutoComboBox.Items.Add(vm);
            }
            DestinationSystemAutoComboBox.SelectedIndex = 0;
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
            if (Clipboard.ContainsText())
            {
                DestinationPathTextBox.Text = Clipboard.GetText();
            }
        }
        private void DestinationPathClearButton_Click(object sender, EventArgs e)
        {
            if (DestinationPathTextBox.Text != null || DestinationPathTextBox.Text != String.Empty)
            {
                DestinationPathTextBox.Text = string.Empty;
                // TODO: Tab focus on this txt field
            }
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
        private void Hvps_NoVmsAccessible(object sender, EventArgs e)
        {
            var res = MessageBox.Show("There are no Virtual Machines available. Make sure the VM you are trying to access is running.",
                "No Virtual Machine available",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Error);
            if (res == DialogResult.Retry)
            {
                accessibleVMs = hvps.GetAccessibleVMs();
            }
        }
        private void Hvps_UserDeclinedCmdAdminRights(object sender, EventArgs e)
        {
            MessageBox.Show("You declined the execution of \"cmd.exe\" as administrator.\nIf you dont allow the program to execute it with elevated rights, the program cant work properly.\nPlease allow elevated rights for every action of this program.",
                "Elevated rights required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
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
