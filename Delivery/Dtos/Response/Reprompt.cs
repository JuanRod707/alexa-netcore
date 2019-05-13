using Newtonsoft.Json;

namespace Delivery.Dtos.Response
{
    public class Reprompt
    {
        [JsonProperty("outputSpeech", NullValueHandling = NullValueHandling.Ignore)]
        public IOutputSpeech OutputSpeech {get; set;}
    }
}
