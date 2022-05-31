using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazingApple.FontAwesome.Services;

/// <summary>Settings for Twitter.</summary>
/// <seealso cref="FontSearchService" />
public class FontAwesomeSettings
{
    /// <summary>Bearer token for requests to the API.</summary>
    public string? BearerToken { get; set; }

    /// <summary>
    ///     The memberships to search against. Allowed values are:
    ///     <list type="bullet">
    ///         <item><c>free</c></item>
    ///         <item><c>paid</c></item>
    ///     </list>
    /// </summary>
    public List<string>? Memberships { get; set; } = new List<string>() { "free" };

    /// <summary>The version to search against.</summary>
    /// <remarks>If empty, not filtered against versions.</remarks>
    public string? Version { get; set; }
}
