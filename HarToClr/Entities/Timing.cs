using Newtonsoft.Json;

namespace HarToClr
{
    public class Timing
    {
        [JsonProperty("blocked")]
        public int Blocked { get; set; }

        [JsonProperty("connect")]
        public int Connect { get; set; }

        [JsonProperty("dns")]
        public int Dns { get; set; }

        [JsonProperty("receive")]
        public int Receive { get; set; }

        [JsonProperty("send")]
        public int Send { get; set; }

        [JsonProperty("ssl")]
        public int Ssl { get; set; }

        [JsonProperty("wait")]
        public int Wait { get; set; }
    }
}
