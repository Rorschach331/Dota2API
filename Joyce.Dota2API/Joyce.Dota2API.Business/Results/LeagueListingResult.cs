using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Dota2API.ApiClasses;

namespace Dota2API.Results
{
    public class LeagueListingResult
    {
        private List<League> _leagues;

        [JsonProperty("leagues")]
        public List<League> Leagues
        {
            get { return _leagues; }
            set { _leagues = value; }
        }

    }
}
