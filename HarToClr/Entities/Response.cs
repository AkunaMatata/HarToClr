using Newtonsoft.Json;

namespace HarToClr
{
    public class Response : HttpBaseEntity
    {
        [JsonProperty("content")]
        public Content Content { get; set; }

        [JsonProperty("redirectURL")]
        public string RedirectUrl { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("statusText")]
        public string StatusText { get; set; }
    }
}
