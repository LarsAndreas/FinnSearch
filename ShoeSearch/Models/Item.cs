using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ShoeSearch.Models
{
    public class Item
    {
        [JsonPropertyName("ad_id")]
        public int adID { get; set; }
        [JsonPropertyName("heading")]
        public string title { get; set; }

        public Price price { get; set; }
        [JsonPropertyName("ad_link")]
        public string adURL { get; set; }
    }
}