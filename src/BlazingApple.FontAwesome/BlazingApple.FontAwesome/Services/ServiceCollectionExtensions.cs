using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BlazingApple.FontAwesome.Services;

/// <summary>Extensions supporting registering FontAwesome.</summary>
public static class ServiceCollectionExtensions
{
    /// <summary>Add services for searching FontAwesome, including error logs</summary>
    /// <param name="services">Collection where the service should be registered</param>
    /// <param name="configRoot">Configuration containing the "FontAwesome" section</param>
    /// <returns><paramref name="services" /> (fluent API)</returns>
    public static IServiceCollection AddFontAwesomeSearch(this IServiceCollection services, IConfiguration configRoot)
    {
        IConfigurationSection config = configRoot.GetSection("FontAwesome");
        services.Configure<FontAwesomeSettings>(config);
        services.AddScoped<FontSearchService>();

        return services;
    }
}
