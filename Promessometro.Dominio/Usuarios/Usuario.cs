using Promessometro.Dominio.Abstractions;

namespace Promessometro.Dominio.Usuarios;

public class Usuario : Entity
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
}