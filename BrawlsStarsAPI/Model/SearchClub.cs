﻿using Newtonsoft.Json;

namespace BrawlStars.Model
{
    public partial class SearchClub
    {
        [JsonProperty("id")]
        public Id Id { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("memberCount")]
        public long MemberCount { get; set; }

        [JsonProperty("trophies")]
        public long Trophies { get; set; }

        [JsonProperty("requiredTrophies")]
        public long RequiredTrophies { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
    public partial class SearchClub
    {
        public static SearchClub[] FromJson(string json) => JsonConvert.DeserializeObject<SearchClub[]>(json);
    }

    public static class Serialize
    {
        public static string ToJson(this Club[] self) => JsonConvert.SerializeObject(self);
    }
}

