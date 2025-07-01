using Promessometro.Dominio.Abstractions;

namespace Promessometro.Dominio.Requerimentos;

public interface IRequerimentoRepository : IRepository<Requerimento>
{
    Task<Requerimento?> GetByCodigoAsync(string codigo, CancellationToken cancellationToken);
}