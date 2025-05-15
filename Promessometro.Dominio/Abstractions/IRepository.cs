namespace Promessometro.Dominio.Abstractions;

public interface IRepository<TEntity> where TEntity : class
{
    Task<List<TEntity>> GetAllAsync(CancellationToken cancellationToken);
    Task<TEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    void Add(TEntity entity);
}