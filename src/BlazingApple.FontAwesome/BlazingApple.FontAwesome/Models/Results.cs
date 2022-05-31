using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazingApple.FontAwesome.Models;

/// <summary>Results from</summary>
/// <typeparam name="T"></typeparam>
public class DataResults<T>
    where T : class
{
    /// <summary>The search result data.</summary>
    [JsonPropertyName("data")]
    public SearchResults<T>? Data { get; set; }

    /// <summary>The search result data.</summary>
    public IEnumerable<T>? Results => Data?.Results;
}
