using Microsoft.Extensions.DependencyInjection;
using Promessometro.Aplicacao.Abstractions.Contracts;
using Promessometro.Dominio.Abstractions;
using Promessometro.Dominio.Fases;
using Promessometro.Dominio.Promessas;
using Promessometro.Dominio.Requerimentos;
using Promessometro.Dominio.Usuarios;
using Promessometro.Dominio.Vereadores;
using Promessometro.Infraestrutura.Authentication;
using Promessometro.Infraestrutura.Context;
using Promessometro.Infraestrutura.Repositories;

namespace Promessometro.Infraestrutura;

public static class Registration
{
    public static void ConfigureInfrastructureServices(this IServiceCollection services)
    {
        services.AddDbContext<PromessometroContext>();

        services.AddScoped<IJwtProvider, JwtProvider>();

        services.AddScoped<IFaseRepository, FaseRepository>();
        services.AddScoped<IPromessaRepository, PromessaRepository>();
        services.AddScoped<IRequerimentoRepository, RequerimentoRepository>();
        services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        services.AddScoped<IVereadorRepository, VereadorRepository>();

        services.AddScoped<IUnitOfWork>(sp => sp.GetRequiredService<PromessometroContext>());
    }
}