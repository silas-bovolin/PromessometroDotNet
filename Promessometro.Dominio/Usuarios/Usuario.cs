using Promessometro.Dominio.Abstractions;

namespace Promessometro.Dominio.Usuarios;

public class Usuario : Entity
{
    private Usuario(Guid id, string nome, string email, string senhaCriptografada)
        : base(id)
    {
        Nome = nome;
        Email = email;
        SenhaCriptografada = senhaCriptografada;
    }
    public Usuario() { }
    public string Nome { get; private set; }
    public string Email { get; private set; }
    public string SenhaCriptografada { get; private set; }
    public static Usuario Create(string nome, string email, string senhaCriptografada)
    {
        var id = Guid.NewGuid();
        return new Usuario(id, nome, email, senhaCriptografada);
    }
}