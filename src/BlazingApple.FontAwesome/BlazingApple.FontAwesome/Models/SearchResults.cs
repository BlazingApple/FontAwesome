using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazingApple.FontAwesome.Models
{
    /// <summary>The "search" object back from Font Awesome</summary>
    public class SearchResults<T>
        where T : class
    {
        /// <summary>The results.</summary>
        [JsonPropertyName("search")]
        public IEnumerable<T>? Results { get; set; }
    }
}
