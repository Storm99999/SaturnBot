using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SaturnBot.FUE4
{
    public static class FNews
    {
        // modified so it works for bots
        public static string Get()
        {
            return JsonConvert.DeserializeObject<fnapi>(new WebClient().DownloadString("https://fortnite-api.com/v2/news/br")).data.image;
        }
        public class Data
        {
            public string image { get; set; }
        }

        public class fnapi
        {
            public Data data { get; set; }
        }
    }
}
