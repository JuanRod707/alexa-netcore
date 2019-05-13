using Newtonsoft.Json;

namespace Delivery.Dtos.Request
{
    public class Experience
    {
        [JsonProperty("arcMinuteWidth")]
        public int Width {get; set;}
        
        [JsonProperty("arcMinuteHeight")]
        public int Height {get; set;}
        
        [JsonProperty("canRotate")]
        public bool CanRotate {get; set;}
        
        [JsonProperty("canResize")]
        public bool CanResize {get; set;}
    }
}