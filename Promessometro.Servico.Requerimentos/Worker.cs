using MediatR;
using Promessometro.Aplicacao.Features.Requerimentos.Commands.ProcessaRequerimentosSiteCamara;

namespace Promessometro.Servico.Requerimentos
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IServiceProvider serviceProvider;

        public Worker(ILogger<Worker> logger, IServiceProvider serviceProvider)
        {
            _logger = logger;
            this.serviceProvider = serviceProvider;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                if (_logger.IsEnabled(LogLevel.Information))
                {
                    _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                }

                using (var scope = serviceProvider.CreateScope())
                {
                    var sender = scope.ServiceProvider.GetRequiredService<ISender>();
                    await sender.Send(new ProcessaRequerimentosSiteCamaraCommand(), stoppingToken);
                }

                await Task.Delay(TimeSpan.FromDays(1), stoppingToken);
            }
        }
    }
}
