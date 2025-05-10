using Promessometro.Dominio.Abstractions;

namespace Promessometro.Dominio.Promessas;

public interface IPromessaRepository : IRepository<Promessa>
{
    Task<List<Promessa>> GetPromessasComFases(CancellationToken cancellationToken);
}