using Newtonsoft.Json;

namespace HarToClr
{
    public class Har
    {
        [JsonProperty("log")]
        public Log Log { get; set; }
    }
}
