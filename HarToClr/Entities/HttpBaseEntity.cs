using System.Collections.Generic;
using Newtonsoft.Json;

namespace HarToClr
{
    public class HttpBaseEntity
    {
        [JsonProperty("bodySize")]
        public int BodySize { get; set; }

        [JsonProperty("cookies")]
        public List<KeyValuePair<string, string>> Cookies { get; set; }

        [JsonProperty("headers")]
        public List<KeyValuePair<string, string>> Headers { get; set; }

        [JsonProperty("headersSize")]
        public int HeaderSize { get; set; }

        [JsonProperty("httpVersion")]
        public string HttpVersion { get; set; }
    }
}
