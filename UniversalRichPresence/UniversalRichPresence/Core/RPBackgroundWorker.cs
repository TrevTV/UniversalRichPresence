using DiscordRPC;
using System;
using System.Timers;
using UniversalRichPresence.Other;

namespace UniversalRichPresence.Core
{
    public class RPBackgroundWorker
    {
        Timer timer;
        string lastExecutable;

        public RPBackgroundWorker()
        {
            timer = new Timer(10000);
            timer.Elapsed += (s, e) => { RPWork(); };

            timer.Start();
        }

        public void StopWorker()
        {
            timer.Stop();
        }

        public void StartWorker()
        {
            timer.Start();
        }

        public void DisposeWorker()
        {
            timer.Dispose();
        }

        public void ForceTrigger()
        {
            RPWork(true);
        }

        private void RPWork(bool bypassExecutableCheck = false)
        {
            string exeName = ActiveWindow.GetActiveWindowExecutable();

            if (lastExecutable == exeName && !bypassExecutableCheck)
                return;

            if (Globals.rpDetails.TryGetValue(exeName, out RichPresenceDetails richPresenceDetails))
            {
                Timestamps currentTime = new Timestamps() { Start = DateTime.UtcNow };
                RPC.UpdatePresence(richPresenceDetails.Details, richPresenceDetails.State, richPresenceDetails.Assets, currentTime);
            }
            else
            {
                Assets urpImage = new Assets() { LargeImageKey = "default-urp" };
                Timestamps currentTime = new Timestamps() { Start = DateTime.UtcNow };
                RPC.UpdatePresence("Unknown Program", "", urpImage, currentTime);
            }

            lastExecutable = exeName;
        }
    }
}
