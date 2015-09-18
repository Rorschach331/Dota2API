using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Dota2API.ApiClasses;

namespace Dota2API.Results
{
    public class SteamPlayerSummaryResult
    {
        private List<SteamPlayerSummary> _players;

        [JsonProperty("players")]
        public List<SteamPlayerSummary> Players
        {
            get { return _players; }
            set { _players = value; }
        }

    }
}
