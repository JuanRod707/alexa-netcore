using Newtonsoft.Json;

namespace Delivery.Dtos.Response
{
    public class SimpleCard : ICard
    {
        [JsonRequired]
        [JsonProperty("type")]
        public string Type {get { return "Simple"; }}

        [JsonProperty("title")]
        public string Title {get; set;}

        [JsonProperty("content")]
        public string Content {get; set;}
    }
}
