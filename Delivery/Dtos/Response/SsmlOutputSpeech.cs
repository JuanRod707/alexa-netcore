using Newtonsoft.Json;

namespace Delivery.Dtos.Response
{
    public class SsmlOutputSpeech : IOutputSpeech
    {
        [JsonRequired]
        [JsonProperty("type")]
        public string Type {get {return "SSML";}}

        [JsonRequired]
        [JsonProperty("ssml")]
        public string Ssml {get; set;}
    }
}
