using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ShoeSearch.Models
{
    public class FinnModel
    {
        [JsonPropertyName("docs")]
        public List<Item> items { get; set; }
    }
}
