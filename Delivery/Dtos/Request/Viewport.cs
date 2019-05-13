using Newtonsoft.Json;

namespace Delivery.Dtos.Request
{
    public class Viewport
    {
        [JsonProperty("experiences")]
        public Experience[] Experiences {get; set;}
        
        [JsonProperty("shape")]
        public string Shape {get; set;}
        
        [JsonProperty("pixelWidth")]
        public string PixelWidth {get; set;}
        
        [JsonProperty("pixelHeight")]
        public string PixelHeight {get; set;}
        
        [JsonProperty("dpi")]
        public string Dpi {get; set;}
        
        [JsonProperty("currentPixelWidth")]
        public string CurrentPixelWidth {get; set;}
        
        [JsonProperty("currentPixelHeight")]
        public string CurrentPixelHeight {get; set;}
        
        [JsonProperty("touch")]
        public string[] Touch {get; set;}
        
        [JsonProperty("video")]
        public Video Video {get; set;}
    }
}