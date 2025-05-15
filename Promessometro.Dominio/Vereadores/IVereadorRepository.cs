using Promessometro.Dominio.Abstractions;

namespace Promessometro.Dominio.Vereadores;

public interface IVereadorRepository : IRepository<Vereador>
{
    Task<List<Vereador>> GetVereadoresEVotosAsync(CancellationToken cancellationToken);
}