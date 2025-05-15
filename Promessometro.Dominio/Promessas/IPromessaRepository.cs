using Promessometro.Dominio.Abstractions;

namespace Promessometro.Dominio.Promessas;

public interface IPromessaRepository : IRepository<Promessa>
{
    Task<List<Promessa>> GetPromessasComFasesAsync(CancellationToken cancellationToken);
}