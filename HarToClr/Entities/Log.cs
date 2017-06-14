using System.Collections.Generic;
using Newtonsoft.Json;

namespace HarToClr
{
    public class Log
    {
        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("creator")]
        public Creator Creator { get; set; }

        [JsonProperty("entries")]
        public List<RequestEntity> Entries { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
