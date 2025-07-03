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

    public readonly static Error SenhaNaoAtendeRequisitos = new(
        "Usuario.SenhaNaoAtendeRequisitos",
        "A senha informada não atende aos requisitos mínimos de segurança. Ela deve ter pelo menos 5 caracteres");

    public readonly static Error EmailJaRegistrado = new(
        "Usuario.EmailJaRegistrado",
        "O e-mail informado já foi registrado");

    public readonly static Error TermosNaoAceitos = new(
        "Usuario.TermosNaoAceitos",
        "É necessário ler e aceitar o termos para se cadastrar");

    public readonly static Error TelefoneInvalido = new(
        "Usuario.TelefoneInvalido",
        "O telefone informado não é válido");

    public readonly static Error EmailInvalido = new(
        "Usuario.EmailInvalido",
        "O e-mail informado não é válido");
}