using Newtonsoft.Json;

namespace HarToClr
{
    public class Creator
    {
        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
