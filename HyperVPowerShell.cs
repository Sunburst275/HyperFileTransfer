using System;
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

        #region internal
        private string _DestinationPath;
        private string _DestinationSystem;
        private bool _RunInBackground = true;
        private bool _ForceExecution = true;
        #endregion
        #region properties
        
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
        public HyperVPowerShell()
        {
            this.DestinationSystem = String.Empty;
            this.DestinationPath = String.Empty;
            this.RunInBackground = true;
            this.ForceExecution = true;
        }
        #endregion
        #region PowerShell execution

        public void Test()
        {
            bool errorOccured = false;
            Console.WriteLine("Starting PowerShell test...");

            // --------------------------------------------------------------------------
            
            
            
            
            
            // --------------------------------------------------------------------------

            if (errorOccured)
            {
                Console.WriteLine("PowerShell test ended with (an) error(s).");
            }
            else
            {
                Console.WriteLine("PowerShell test ended with (an) error(s).");
            }
        }

        public void SendFile()
        {

        }

        public string[] GetAccessableVMs()
        {






            return null;
        }


        #endregion




    }
}
