using Microsoft.EntityFrameworkCore;
using Promessometro.Dominio.Vereadores;
using Promessometro.Infraestrutura.Context;

namespace Promessometro.Infraestrutura.Repositories;

public class VereadorRepository(PromessometroContext db) : 
    Repository<Vereador>(db), 
    IVereadorRepository
{
    public async Task<List<Vereador>> GetVereadoresEVotosAsync(CancellationToken cancellationToken)
        => await DbSet.Include(v => v.Votos).ToListAsync(cancellationToken);
}