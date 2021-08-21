using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SaturnBot.FUE4
{
    public static class UCosmeticViewer
    {
        public static string ExportCIDInfo(string CID)
        {
            var client = new WebClient();
            string json = client.DownloadString($"https://benbot.app/api/v1/cosmetics/br/" + CID);
            string icon = ((dynamic)JObject.Parse(json)).icons.icon;
            string series = ((dynamic)JObject.Parse(json)).series;
            string path = ((dynamic)JObject.Parse(json)).path;
            string description = ((dynamic)JObject.Parse(json)).description;
            string variants = ((dynamic)JObject.Parse(json)).variants;
           string result =
                (
                $"◸ Exported By UE4.dll ◹\n\n CID Info: \n\n\n\n\n\n Icon: {icon}\n Series: {series}\n Path: {path}\n Description: {description}\n Variants: {variants}\n\n\n\n◺                                                          ◿"
                );

            return result;
        }
    }
}
