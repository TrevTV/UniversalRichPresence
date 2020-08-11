using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.IO;
using UniversalRichPresence.Core;

namespace UniversalRichPresence.Other
{
    public class JSONCreation
    {
        static string programDataPath = Globals.userDirectory + "ProgramData.json";

        public static void WriteJSONFromRPDetails()
        {
            JObject jsonRoot = new JObject();

            foreach (var data in Globals.rpDetails)
            {
                /*JObject assetsObject = new JObject(
                    new JProperty("LargeImageID", data.Value.Assets.LargeImageID),
                    new JProperty("LargeImageKey", data.Value.Assets.LargeImageKey),
                    new JProperty("LargeImageText", data.Value.Assets.LargeImageText),
                    new JProperty("SmallImageID", data.Value.Assets.SmallImageID),
                    new JProperty("SmallImageKey", data.Value.Assets.SmallImageKey),
                    new JProperty("SmallImageText", data.Value.Assets.SmallImageText));*/

                JObject detailsObject = new JObject(
                    new JProperty("executable", data.Value.Executable),
                    new JProperty("programname", data.Value.Details),
                    new JProperty("state", data.Value.State));

                JProperty jsonData = new JProperty(data.Key, detailsObject);
                jsonRoot.Add(jsonData);
            }

            File.WriteAllText(programDataPath, jsonRoot.ToString());
        }

        public static void ReadJson()
        {
            if (!File.Exists(programDataPath))
                return;

            JObject jObject = JObject.Parse(File.ReadAllText(programDataPath));
            
            foreach (var obj in jObject)
            {
                JToken data = obj.Value;

                if (Globals.rpDetails.TryGetValue(obj.Key, out RichPresenceDetails rpDetails))
                {
                    rpDetails.Details = (string)data["programname"];
                    rpDetails.State = (string)data["state"];
                    continue;
                }

                new RichPresenceDetails((string)data["executable"], (string)data["programname"], (string)data["state"]);
            }
        }
    }
}
