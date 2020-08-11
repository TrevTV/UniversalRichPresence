using IniParser;
using IniParser.Model;
using System.IO;

namespace UniversalRichPresence.Other
{
    public class Settings
    {
        static string settingsPath = Globals.userDirectory + "settings.ini";
        static FileIniDataParser parser = new FileIniDataParser();
        static IniData data;

        public static void Setup()
        {
            if (!Directory.Exists(Globals.userDirectory))
                Directory.CreateDirectory(Globals.userDirectory);

            if (!File.Exists(settingsPath))
                File.WriteAllText(settingsPath, "\n");

            data = parser.ReadFile(settingsPath);

            if (data["General"]["FirstTime"] == null)
            {
                data["General"]["FirstTime"] = "true";
                parser.WriteFile(settingsPath, data);
            }  
        }

        public static void ModifyValue(string section, string setting, string value)
        {
            data[section][setting] = value;
            parser.WriteFile(settingsPath, data);
        }

        public static string GetValue(string section, string setting)
        {
            return data[section][setting];
        }
    }
}
