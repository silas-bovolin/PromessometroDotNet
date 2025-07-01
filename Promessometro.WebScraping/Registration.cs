using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Promessometro.Aplicacao.Abstractions.Contracts;
using Promessometro.Aplicacao.Settings;
using Promessometro.WebScraping.CamaraSjc;

namespace Promessometro.WebScraping;

public static class Registration
{
    public static void ConfigureWebScrapingServices(
        this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IExtratorDeVotacao, ExtratorDeVotacao>();

        services.AddHttpClient();

        services.Configure<WebScrappingSettings>(
            configuration.GetSection("WebScrappingSettings"));
        services.AddSingleton(sp =>
            sp.GetRequiredService<IOptions<WebScrappingSettings>>().Value);
    }
}