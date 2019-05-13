using Newtonsoft.Json;

namespace Delivery.Dtos.Request
{
    public class User
    {
        [JsonProperty ("userId")]
        public string UserId {get; set;}

//    [JsonProperty("permissions")]
  //      public Permissions Permissions {get; set;}

        [JsonProperty("accessToken")]
        public string AccessToken {get; set;}
    }
}
