using Newtonsoft.Json;

namespace Delivery.Dtos.Response
{
    public class CardImage
    {
        [JsonProperty("smallImageUrl")]
        public string SmallImageUrl {get; set;}

        [JsonProperty("largeImageUrl")]
        public string LargeImageUrl {get; set;}
    }
}
