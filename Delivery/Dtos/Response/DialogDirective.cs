﻿using Newtonsoft.Json;

namespace Delivery.Dtos.Response
{
    public class DialogDirective : IDirective
    {
        [JsonProperty("type")]
        public string Type {get; set;}
    }
}
