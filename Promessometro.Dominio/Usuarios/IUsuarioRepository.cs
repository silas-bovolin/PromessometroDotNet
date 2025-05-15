using Promessometro.Dominio.Abstractions;

namespace Promessometro.Dominio.Usuarios;

public interface IUsuarioRepository : IRepository<Usuario>
{
    public Task<Usuario?> ObterPorEmailAsync(string email, CancellationToken cancellationToken);
}