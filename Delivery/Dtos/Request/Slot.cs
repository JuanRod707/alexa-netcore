﻿using Newtonsoft.Json;

namespace Delivery.Dtos.Request
{
    public class Slot
    {
        [JsonProperty("name")]
        public string Name {get; set;}

        [JsonProperty("value")]
        public string Value {get; set;}
    }
}
