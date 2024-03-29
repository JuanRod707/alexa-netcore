﻿using Newtonsoft.Json;

namespace Delivery.Dtos.Response
{
    public class PlainTextOutputSpeech:  IOutputSpeech
    {
        [JsonProperty("type")]
        [JsonRequired]
        public string Type {get {return "PlainText";}}

        [JsonRequired]
        [JsonProperty("text")]
        public string Text {get; set;}
    }
}
