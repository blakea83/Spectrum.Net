﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spectrum.Net.Core
{
    public class Notification
    {
        [JsonProperty("id")]
        public String Id { get; set; }

        [JsonProperty("thumbnail")]
        public String Thumbnail { get; set; }

        [JsonProperty("time")]
        public Int64 Time { get; internal set; } = (DateTime.UtcNow.Ticks - 621355968000000000) / 10000000;
    }
}