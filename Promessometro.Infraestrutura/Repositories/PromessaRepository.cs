using Microsoft.EntityFrameworkCore;
using Promessometro.Dominio.Promessas;
using Promessometro.Infraestrutura.Context;

namespace Promessometro.Infraestrutura.Repositories;

public class PromessaRepository(PromessometroContext db) :
    Repository<Promessa>(db),
    IPromessaRepository
{
    public async Task<List<Promessa>> GetPromessasComFasesAsync(CancellationToken cancellationToken)
        => await DbSet.Include(p => p.Fases).ToListAsync(cancellationToken);
}