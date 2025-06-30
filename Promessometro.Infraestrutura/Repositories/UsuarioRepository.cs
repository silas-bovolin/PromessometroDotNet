using Microsoft.EntityFrameworkCore;
using Promessometro.Dominio.Usuarios;
using Promessometro.Infraestrutura.Context;

namespace Promessometro.Infraestrutura.Repositories;

public class UsuarioRepository(PromessometroContext db) :
    Repository<Usuario>(db),
    IUsuarioRepository
{
    public async Task<Usuario?> ObterPorEmailAsync(string email, CancellationToken cancellationToken)
        => await DbSet.FirstOrDefaultAsync(u => u.Email.ToLower().Equals(email.ToLower()), cancellationToken);
}