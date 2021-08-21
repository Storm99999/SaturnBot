using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SaturnBot.FUE4
{
    public static class StatsExport
    {
        public static string Get(string accountID)
        {
            // long code after all I'll make this public later. you can fork or make a pull request with more cooler code.
            string fStats = new WebClient().DownloadString($"https://fortnite-api.com/v2/stats/br/v2/" + accountID);
            string accID = ((dynamic)JObject.Parse(fStats)).data.account.id;
            string accountName = ((dynamic)JObject.Parse(fStats)).data.account.name;
            int BattlePassLevel = ((dynamic)JObject.Parse(fStats)).data.battlepass.level;
            int Score = ((dynamic)JObject.Parse(fStats)).data.stats.all.overall.score;

            string result =
                $"◸ Exported By FUE4.dll ◹\n\n Account ID: {accID}\n\n\n\n\n\n Account Name: {accountName}\n BattlePass Level: {BattlePassLevel}\n Score: {Score}\n\n\n\n◺                                                          ◿";

            return result;
        }
    }
}
