using Promessometro.Servico.Requerimentos;
using Promessometro.Infraestrutura;
using Promessometro.WebScraping;
using Promessometro.Aplicacao;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();

builder.Services.ConfigureApplicationServices();
builder.Services.ConfigureInfrastructureServices(builder.Configuration);
builder.Services.ConfigureWebScrapingServices(builder.Configuration);

var host = builder.Build();
host.Run();
