using System;
using System.Windows.Forms;
using UniversalRichPresence.Core;
using UniversalRichPresence.Forms;
using UniversalRichPresence.Other;

namespace UniversalRichPresence
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initalize the required items
            RPC.Initialize();
            Settings.Setup();
            Defaults.Setup();
            Globals.rpWorker = new RPBackgroundWorker();
            Globals.mainForm = new MainForm();

            // Initalize the Application
            Application.EnableVisualStyles();
            Application.Run(Globals.mainForm);
        }
    }
}
