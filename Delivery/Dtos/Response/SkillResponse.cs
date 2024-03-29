﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Delivery.Dtos.Response
{
    public class SkillResponse
    {
        [JsonProperty("version")]
        public string Version {get; set;}

        [JsonProperty("sessionAttributes", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, object> SessionAttributes {get; set;}

        [JsonProperty("response")]
        public ResponseBody Response {get; set;}
        
        [JsonProperty("userAgent")]
        public string UserAgent {get; set;}
    }
}
