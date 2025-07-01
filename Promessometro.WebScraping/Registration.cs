using Microsoft.Extensions.DependencyInjection;
using Promessometro.Aplicacao.Abstractions.Contracts;
using Promessometro.WebScraping.CamaraSjc;

namespace Promessometro.WebScraping;

public static class Registration
{
    public static void ConfigureWebScrapingServices(
        this IServiceCollection services)
    {
        services.AddScoped<IExtratoDaVotacao, ExtratoDaVotacao>();
    }
}