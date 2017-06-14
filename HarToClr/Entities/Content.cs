using Newtonsoft.Json;

namespace HarToClr
{
    public class Content
    {
        [JsonProperty("compression")]
        public int Compression { get; set; }

        [JsonProperty("encoding")]
        public string Encoding { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
