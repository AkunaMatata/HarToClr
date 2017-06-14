using System;
using Newtonsoft.Json;

namespace HarToClr
{
    public class RequestEntity
    {
        [JsonProperty("connection")]
        public string Connection { get; set; }

        [JsonProperty("request")]
        public Request Request { get; set; }

        [JsonProperty("response")]
        public Response Response { get; set; }

        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("serverIPAddress")]
        public string ServerIpAdress { get; set; }

        [JsonProperty("startedDateTime")]
        public DateTime StartDateTime { get; set; }

        [JsonProperty("timings")]
        public Timing Timing { get; set; }
    }
}
