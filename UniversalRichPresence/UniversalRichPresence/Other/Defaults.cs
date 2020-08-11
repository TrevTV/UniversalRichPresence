using DiscordRPC;
using UniversalRichPresence.Core;

namespace UniversalRichPresence.Other
{
    public class Defaults
    {
        public static void Setup()
        {
            new RichPresenceDetails("chrome.exe", "Google Chrome", "Browsing the Internet", new Assets() { LargeImageKey = "googlechrome" });
            new RichPresenceDetails("firefox.exe", "Firefox", "Browsing the Internet", new Assets() { LargeImageKey = "firefox" });
            new RichPresenceDetails("Discord.exe", "Discord", "Talking to people", new Assets() { LargeImageKey = "discord" });
            new RichPresenceDetails("blender.exe", "Blender", "Modeling objects", new Assets() { LargeImageKey = "blender" });
            new RichPresenceDetails("Maya.exe", "Maya", "Modeling objects", new Assets() { LargeImageKey = "maya" });
            new RichPresenceDetails("explorer.exe", "File Explorer", "Browsing files", new Assets() { LargeImageKey = "explorer" });
            new RichPresenceDetails("steam.exe", "Steam", "Browsing Steam", new Assets() { LargeImageKey = "steam" });
            new RichPresenceDetails("Unity.exe", "Unity", "Making games", new Assets() { LargeImageKey = "unity" });
            new RichPresenceDetails("Photoshop.exe", "Photoshop", "Editing images", new Assets() { LargeImageKey = "photoshop" });
            new RichPresenceDetails("Adobe Premiere Pro.exe", "Premiere Pro", "Editing videos", new Assets() { LargeImageKey = "premierepro" });
            new RichPresenceDetails("FireAlpaca.exe", "FireAlpaca", "Drawing", new Assets() { LargeImageKey = "firealpaca" });
            new RichPresenceDetails("devenv.exe", "Visual Studio", "Programming", new Assets() { LargeImageKey = "visualstudio" });
            new RichPresenceDetails("Code.exe", "Visual Studio Code", "Programming", new Assets() { LargeImageKey = "visualstudiocode" });
            new RichPresenceDetails("notepad++.exe", "Notepad++", "Editing a text document", new Assets() { LargeImageKey = "notepadpp" });
            new RichPresenceDetails("UniversalRichPresence.exe", "Universal Rich Presence", "Editing RP Details", new Assets() { LargeImageKey = "default-urp" });

            JSONCreation.ReadJson();
        }
    }
}
