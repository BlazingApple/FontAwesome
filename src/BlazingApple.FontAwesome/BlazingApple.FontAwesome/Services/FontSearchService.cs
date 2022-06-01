using BlazingApple.FontAwesome.Models;
using Microsoft.Extensions.Configuration;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace BlazingApple.FontAwesome.Services;

/// <summary>Service for searching FontAwesome icons using their GraphQL API.</summary>
public class FontSearchService
{
    private const string _alphabet = "abcdefghijklmnopqrstuvwxyz";
    private const string _baseAddress = "https://api.fontawesome.com/";
    private readonly HttpClient _httpClient;
    private readonly string _version = "5.15.4";

    /// <summary>DI Constructor.</summary>
    public FontSearchService(IConfiguration config, HttpClient httpClient)
    {
        IConfigurationSection section = config.GetSection("FontAwesome");
        string? bearerToken = section["BearerToken"];
        _version = section["Version"];

        _httpClient = httpClient;
        if (!string.IsNullOrEmpty(bearerToken))
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);
    }

    /// <summary>Get the default/starting icons without any query.</summary>
    /// <returns></returns>
    public async Task<IEnumerable<FontAwesomeIcon>?> Get()
    {
        Random r = new();
        int index = r.Next(_alphabet.Length);
        return await Search(_alphabet[index].ToString());
    }

    /// <summary>Search for an icon.</summary>
    /// <param name="query">The search query supplied by the user.</param>
    /// <returns>The list of matching icons.</returns>
    public async Task<IEnumerable<FontAwesomeIcon>?> Search(string? query = "")
    {
        if (string.IsNullOrEmpty(query))
            return Enumerable.Empty<FontAwesomeIcon>();

        string queryString = BuildSearchQuery(query, _version);
        DataResults<FontAwesomeIcon>? response = await _httpClient.GetFromJsonAsync<DataResults<FontAwesomeIcon>>($"{_baseAddress}{queryString}");

        IEnumerable<FontAwesomeIcon>? results = response?.Results;

        if (results is null)
            return results;
        else
            return results.Where(i => i.ToString() != "");
    }

    private static string BuildSearchQuery(string query, string version)
    {
        string queryString = $"?query={{search(version: \"{version}\", query: \"{query}\", first: 100) {{ id, label, membership {{ free }} }}}}";
        return queryString;
    }
}
