using Promessometro.Dominio.Usuarios;

namespace Promessometro.Aplicacao.Abstractions.Contracts;

public interface IJwtProvider
{
    string Generate(Usuario usuario);
}