using Promessometro.Dominio.Abstractions;

namespace Promessometro.Dominio.Usuarios;

public class UsuarioErrors
{
    public readonly static Error EmailNaoEncontrada = new(
        "Usuario.NaoEncontrado",
        "O usuário com o e-mail informado não foi encontrado");

    public readonly static Error SenhaIncorreta = new(
        "Usuario.SenhaIncorreta",
        "A senha informada não confere com a senha do usuário");
}