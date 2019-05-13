using Newtonsoft.Json;

namespace Delivery.Dtos.Request
{
    public class Context
    {
        [JsonProperty("System")]
        public SystemObject System {get; set;}
        
        [JsonProperty("Viewport")]
        public Viewport Viewport {get; set;}

//   [JsonProperty("AudioPlayer")]
//   public AudioPlayer AudioPlayer {get; set;}
    }
}
