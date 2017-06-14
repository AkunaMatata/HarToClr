using System.Collections.Generic;
using Newtonsoft.Json;

namespace HarToClr
{
    public class PostData
    {
        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("params")]
        public List<KeyValuePair<string,string>> Params { get; set; }
    }
}
