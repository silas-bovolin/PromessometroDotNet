namespace Promessometro.Dominio.Abstractions;

public interface IRepository<TEntity> where TEntity : class
{
    Task<List<TEntity>> GetAll(CancellationToken cancellationToken);
    Task<TEntity?> GetById(Guid id, CancellationToken cancellationToken);
    void Add(TEntity entity);
}