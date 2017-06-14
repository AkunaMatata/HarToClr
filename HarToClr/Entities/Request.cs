using System.Collections.Generic;
using Newtonsoft.Json;

namespace HarToClr
{
    public class Request : HttpBaseEntity
    {
        [JsonProperty("queryString")]
        public List<KeyValuePair<string,string>> QueryString { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("postData")]
        public PostData PostData { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
