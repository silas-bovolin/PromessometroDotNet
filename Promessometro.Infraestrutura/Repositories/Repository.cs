using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Promessometro.Dominio.Abstractions;
using Promessometro.Infraestrutura.Context;

namespace Promessometro.Infraestrutura.Repositories;

public abstract class Repository<TEntity>(PromessometroContext db) : IRepository<TEntity>
    where TEntity : class
{
    protected readonly DbSet<TEntity> DbSet = db.Set<TEntity>();
    public void Add(TEntity entity)
        => DbSet.Add(entity);

    public async Task<List<TEntity>> GetAllAsync(CancellationToken cancellationToken)
        => await DbSet.ToListAsync(cancellationToken);

    public async Task<TEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        => await DbSet.FindAsync([id], cancellationToken);
}