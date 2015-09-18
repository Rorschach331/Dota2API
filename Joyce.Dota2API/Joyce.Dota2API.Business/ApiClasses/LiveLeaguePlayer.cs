using Dota2API.Converters;
using Dota2API.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dota2API.ApiClasses
{
    public class LiveLeaguePlayer : Player
    {
        private Faction _faction;

        [JsonProperty("team")]
        [JsonConverter(typeof(NumberToEnumConverter<Faction>))]
        public Faction Faction
        {
            get { return _faction; }
            set { _faction = value; }
        }

    }
}
