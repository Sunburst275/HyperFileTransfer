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
            process.OutputDataReceived += Process_OutputDataReceived;
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

        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            Console.WriteLine("----- Process_OutputDataReceived -----------------------------------");
            Console.WriteLine(e.Data.ToString());
            Process process = (Process)sender;
            Console.WriteLine(process.ToString());
            Console.WriteLine("--------------------------------------------------------------------");
        }

        public void SendFile()
        {

        }

        public string[] GetAccessableVMs()
        {
            Process process = new Process();
            string tempFile = Path.GetTempFileName();
            //string utilityPath = "C:\\Windows\\System32\\WindowsPowerShell\\v1.0\\powershell.exe -ArgumentList Get-VM";
            string utilityPath = "powershell Get-VM";
            try
            {
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.UseShellExecute = true;
                process.EnableRaisingEvents = true;
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = " /C \"" + utilityPath + " > \"" + tempFile + "\"\"";
                Console.WriteLine(process.StartInfo.Arguments.ToString());
                process.StartInfo.Verb = "runas";
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.OutputDataReceived += Process_OutputDataReceived;
                process.Start();
                process.WaitForExit();
            }
            finally
            {
                string output = File.ReadAllText(tempFile);
                //System.Diagnostics.Process.Start("explorer.exe", "/select, " + tempFile);
                File.Delete(tempFile);
                Console.WriteLine("tempFileOutput: ---------------------------------");
                Console.WriteLine(output);
                Console.WriteLine("tempFileOutput Ende -----------------------------");
                process.Dispose();
            }


            return null;
        }


        #endregion




    }
}
