using Newtonsoft.Json;

namespace Delivery.Dtos.Request
{
    public class Video
    {
        [JsonProperty("codecs")]
        public string[] Codecs {get; set;}
    }
}