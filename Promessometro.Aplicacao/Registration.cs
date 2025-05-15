using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Promessometro.Aplicacao;

public static class Registration
{
    public static void ConfigureApplicationServices(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly());
        });
    }
}