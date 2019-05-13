using Newtonsoft.Json;

namespace Delivery.Dtos.Request
{
    public class SystemObject
    {
        [JsonProperty("user")]
        public User User {get; set;}

        [JsonProperty("device")]
        public Device Device {get; set;}

        [JsonProperty("apiEndpoint")]
        public string ApiEndpoint {get; set;}
        
        [JsonProperty("apiAccessToken")]
        public string ApiAccessToken {get; set;}
    }
}
