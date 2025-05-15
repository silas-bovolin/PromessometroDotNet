using Promessometro.Dominio.Abstractions;

namespace Promessometro.Dominio.Usuarios;

public class Usuario : Entity
{
    public string Nome { get; private set; }
    public string Email { get; private set; }
    public string SenhaCriptografada { get; private set; }
}