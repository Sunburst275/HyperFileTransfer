using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace HyperFileTransfer
{
    class HyperVPowerShell
    {
        #region Variables

        int startedProcesses = 0;
        List<StreamReader> ProcessOutputStreams;

        #region Internal
        private string _DestinationPath;
        private string _DestinationSystem;
        private bool _RunInBackground = true;
        private bool _ForceExecution = true;
        #endregion
        #region Properties
        public string DestinationPath { get { return _DestinationPath; } set { _DestinationPath = value; } }
        public string DestinationSystem { get { return _DestinationSystem; } set { _DestinationSystem = value; } }
        public bool RunInBackground { get { return _RunInBackground; } set { _RunInBackground = value; } }
        public bool ForceExecution { get { return _ForceExecution; } set { _ForceExecution = value; } }
        #endregion

        #endregion
        #region Constants
        #endregion
        #region Delegates, Events

        //public delegate void StartedExecutionDelegate(object sender, EventArgs eventArgs);
        public event EventHandler StartedExecution;

        //public delegate void EndedExecutionDelegate(object sender, EventArgs eventArgs);
        public event EventHandler EndedExecution;

        //public delegate void NoVmsAccessableDelegate(object sender, EventArgs eventArgs);
        public event EventHandler NoVmsAccessable;

        public event EventHandler UserDeclinedCmdAdminRights;

        protected virtual void OnStartedExecution(object sender, EventArgs eventArgs)
        {
            EventHandler handler = EndedExecution;
            handler?.Invoke(this, eventArgs);
        }
        protected virtual void OnEndedExecution(object sender, EventArgs eventArgs)
        {
            EventHandler handler = StartedExecution;
            handler?.Invoke(this, eventArgs);
        }
        protected virtual void OnNoVmsAccessable(object sender, EventArgs eventArgs)
        {
            EventHandler handler = NoVmsAccessable;
            handler?.Invoke(this, eventArgs);
        }
        protected virtual void OnUserDeclinedCmdAdminRights(object sender, EventArgs eventArgs)
        {
            EventHandler handler = UserDeclinedCmdAdminRights;
            handler?.Invoke(this, eventArgs);
        }
        #endregion
        #region Constructors, Initialization, etc.
        public HyperVPowerShell() // TODO: Make customizable Powershell ctor?
        {
            this.DestinationSystem = String.Empty;
            this.DestinationPath = String.Empty;
            this.RunInBackground = true;
            this.ForceExecution = true;

            ProcessOutputStreams = new List<StreamReader>();
        }
        #endregion
        #region PowerShell execution

        public void Test()
        {
            bool errorOccured = false;
            Console.WriteLine("Starting PowerShell test...");

            // --------------------------------------------------------------------------

            Process process = new Process();
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.FileName = "C:\\Windows\\System32\\WindowsPowerShell\\v1.0\\powershell.exe";
            process.StartInfo.Arguments = "systeminfo";
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            ProcessOutputStreams.Add(process.StandardOutput);

            // --------------------------------------------------------------------------

            if (errorOccured)
            {
                Console.WriteLine("PowerShell test ended with (an) error(s).");
            }
            else
            {
                Console.WriteLine("PowerShell test ended without (an) error(s).");
                Console.WriteLine(ProcessOutputStreams[0].ReadToEnd());
            }
        }

        public void SendFile()
        {

        }

        public string[] GetAccessableVMs()
        {
            // Get VMs and description
            Process process = new Process();
            string tempFile = Path.GetTempFileName();
            string output;
            //string utilityPath = "C:\\Windows\\System32\\WindowsPowerShell\\v1.0\\powershell.exe Get-VM";
            string utilityPath = "powershell Get-VM";
            try
            {
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = " /C \"" + utilityPath + " > \"" + tempFile + "\"\"";
                Console.WriteLine(process.StartInfo.Arguments.ToString());
                process.StartInfo.Verb = "runas";
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.Start();
                process.WaitForExit();
            }
            catch(System.ComponentModel.Win32Exception)
            {
                OnUserDeclinedCmdAdminRights(this, EventArgs.Empty);
                return null;
            }
            finally
            {
                output = File.ReadAllText(tempFile);
                File.Delete(tempFile);
                process.Dispose();
            }

            // Filter VM names
            //const string StateCondition = "Running";
            const string StateCondition = "Off";
            string[] lines = output.Split('\n');
            List<string> vms = new List<string>();
            foreach (string line in lines)
            {
                if (!line.Contains(StateCondition)) continue; // Skip lines which dont have the StateCondition
                int startIndex = -1;
                var cLine = line.ToCharArray();
                var cStateCondition = StateCondition.ToCharArray();
                // Get where StateCondition in line is
                for(int i = 0; i < cLine.Length; i++)
                {
                    if (i + StateCondition.Length > line.Length) break; // If out of bounds, break
                    for(int c = 0; c < StateCondition.Length; c++)      // Search for start index of StateCondition
                    {
                        if (cLine[i + c] == cStateCondition[c])
                        {
                            startIndex = i;
                        }
                        else
                        {
                            startIndex = -1;
                        }
                    }
                    if (startIndex != -1) break;
                }

                // Retrieve String (= vmName) from 0 to StateCondition's start and add vmName to vms
                vms.Add(line.Substring(0, startIndex).Trim());
            }
            // DBG: Show whether all VMNames are retrieved acceptably
            foreach (string vmname in vms)
            {
                Console.WriteLine(vmname);
            }
            if (vms.Count <= 0) // No VMs accessable (because none is running)
            {
                OnNoVmsAccessable(this, EventArgs.Empty);
                return null;
            }

            return vms.ToArray();
        }


        #endregion
    }
}
