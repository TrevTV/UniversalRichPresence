using DiscordRPC;
using UniversalRichPresence.Other;

namespace UniversalRichPresence.Core
{
    public class RichPresenceDetails
    {
        public string Executable { get; set; }

        public string Details { get; set; }

        public string State { get; set; }

        public Assets Assets { get; set; }

        public RichPresenceDetails(string executable, string details, string state, Assets assets = null)
        {
            Executable = executable;
            Details = details;
            State = state;
            Assets = assets;

            Globals.rpDetails.Add(Executable, this);
        }
    }
}
