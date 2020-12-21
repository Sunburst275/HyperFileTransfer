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

        public delegate void StartedExecutionDelegate(object sender, EventArgs eventArgs);
        public event StartedExecutionDelegate StartedExecution;

        public delegate void EndedExecutionDelegate(object sender, EventArgs eventArgs);
        public event EndedExecutionDelegate EndedExecution;

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
            Process process = new Process();
            string tempFile = Path.GetTempFileName();
            string output;
            //string utilityPath = "C:\\Windows\\System32\\WindowsPowerShell\\v1.0\\powershell.exe -ArgumentList Get-VM";
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
            finally
            {
                output = File.ReadAllText(tempFile);
                File.Delete(tempFile);
                Console.WriteLine("tempFileOutput: ---------------------------------");
                Console.WriteLine(output);
                Console.WriteLine("tempFileOutput Ende -----------------------------");
                process.Dispose();
            }

            const string StateCondition = "Off";
            string[] lines = output.Split('\n');
            List<string> vms = new List<string>();
            foreach (string line in lines)
            {
                if (!vms.Contains(StateCondition)) continue; // Skip lines which dont have the StateCondition
                // TODO: Get StateCondition in line
                // TODO: Get where StateCondition in line is
                // TODO: Retrieve String (= vmName) from 0 to StateCondition's start
                // TODO: Add vmName to vms
            }
            // TODO: If no accessable VM is existent, show MessageBox and flame "Check whether your VMs are online"

            // DBG: Show whether all VMNames are retrieved acceptably
            foreach (string vmname in vms)
            {
                Console.WriteLine(vmname);
            }


            return null;
        }


        #endregion




    }
}
