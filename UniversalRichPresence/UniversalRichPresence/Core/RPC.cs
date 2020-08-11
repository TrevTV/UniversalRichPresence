using DiscordRPC;
using DiscordRPC.Logging;
using System.Diagnostics;
using UniversalRichPresence.Other;

namespace UniversalRichPresence.Core
{
    public class RPC
    {
        static DiscordRpcClient client;

		public static void Initialize()
		{
			client = new DiscordRpcClient("741744611025879070");

			//Set the logger
			client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

			//Subscribe to events
			client.OnReady += (sender, e) =>
			{
				Debug.WriteLine("Received Ready from user {0}", e.User.Username);
				Globals.rpWorker.ForceTrigger();
			};

			client.OnPresenceUpdate += (sender, e) =>
			{
				Debug.WriteLine("Received Update! {0}", e.Presence);
			};

			//Connect to the RPC
			client.Initialize();

			UpdatePresence("details", "state", new Assets { LargeImageKey = "default-urp" });
		}

		public static void UpdatePresence(string details, string state, Assets assets = null, Timestamps timestamps = null)
        {
			client.SetPresence(new RichPresence()
			{
				Details = details,
				State = state,
				Assets = assets,
				Timestamps = timestamps
			});
		}

		public static void Dispose()
        {
			if (client.IsInitialized)
				client.Dispose();
		}
	}
}
