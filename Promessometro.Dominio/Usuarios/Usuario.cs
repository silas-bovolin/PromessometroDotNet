using Promessometro.Dominio.Abstractions;

namespace Promessometro.Dominio.Usuarios;

public class Usuario : Entity
{
    private Usuario(Guid id, string nome, string email, string senhaCriptografada, string telefone, bool aceitouOsTermos)
        : base(id)
    {
        Nome = nome;
        Email = email;
        SenhaCriptografada = senhaCriptografada;
        Telefone = telefone;
        AceitouOsTermos = aceitouOsTermos;
    }
    public Usuario() { }
    public string Nome { get; private set; }
    public string Email { get; private set; }
    public string SenhaCriptografada { get; private set; }
    public string Telefone { get; private set; }
    public bool AceitouOsTermos { get; private set; }
    public static Usuario Create(string nome, string email, string senhaCriptografada, string telefone, bool aceitouOsTermos)
    {
        var id = Guid.NewGuid();
        return new Usuario(id, nome, email, senhaCriptografada, telefone, aceitouOsTermos);
    }
}