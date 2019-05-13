using Newtonsoft.Json;

namespace Delivery.Dtos.Request
{
    public class Application
    {
        [JsonProperty("applicationID")]
        public string ApplicationId {get; set;}
    }
}
