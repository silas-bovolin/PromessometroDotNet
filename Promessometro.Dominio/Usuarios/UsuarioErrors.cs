using Promessometro.Dominio.Abstractions;

namespace Promessometro.Dominio.Usuarios;

public class UsuarioErrors
{
    public readonly static Error EmailNaoEncontrado = new(
        "Usuario.NaoEncontrado",
        "O usuário com o e-mail informado não foi encontrado");

    public readonly static Error SenhaIncorreta = new(
        "Usuario.SenhaIncorreta",
        "A senha informada não confere com a senha do usuário");

    public readonly static Error EmailJaRegistrado = new(
        "Usuario.EmailJaRegistrado",
        "O e-mail informado já foi registrado");

    public readonly static Error TermosNaoAceitos = new(
        "Usuario.TermosNaoAceitos",
        "É necessário ler e aceitar o termos para se cadastrar");
}