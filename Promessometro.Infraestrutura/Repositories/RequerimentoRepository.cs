using Microsoft.EntityFrameworkCore;
using Promessometro.Dominio.Requerimentos;
using Promessometro.Infraestrutura.Context;

namespace Promessometro.Infraestrutura.Repositories;

public class RequerimentoRepository(PromessometroContext db) :
    Repository<Requerimento>(db),
    IRequerimentoRepository
{
    public async Task<Requerimento?> GetByCodigoAsync(string codigo, CancellationToken cancellationToken)
    {
        return await DbSet
            .AsNoTracking()
            .FirstOrDefaultAsync(r => r.Codigo == codigo, cancellationToken);
    }
}