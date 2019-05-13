using Newtonsoft.Json;

namespace Delivery.Dtos.Request
{
    public class SkillRequest
    {
        [JsonProperty("version")]
        public string Version {get; set;}

        [JsonProperty("session")]
        public Session Session {get; set;}

        [JsonProperty("context")]
        public Context Context {get; set;}

        [JsonProperty("request")]
        public Request Request {get; set;}

    }
}
