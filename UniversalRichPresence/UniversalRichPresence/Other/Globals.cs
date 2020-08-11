using System;
using System.Collections.Generic;
using UniversalRichPresence.Core;
using UniversalRichPresence.Forms;

namespace UniversalRichPresence.Other
{
    public class Globals
    {
        public static string userDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\UniversalRichPresence\\";
        public static Dictionary<string, RichPresenceDetails> rpDetails = new Dictionary<string, RichPresenceDetails>();
        public static RPBackgroundWorker rpWorker;
        public static MainForm mainForm;

        public static void DisposeAll()
        {
            Globals.mainForm.MainNotifyIcon.Dispose();
            Globals.rpWorker.DisposeWorker();
            RPC.Dispose();
        }
    }
}
