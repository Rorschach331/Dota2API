using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dota2API.Results
{
    public class ApiResult<T>
    {
        [JsonProperty("result")]
        public T Result { get; set; }

        [JsonProperty("response")]
        public T Response { get; set; }
    }
}
