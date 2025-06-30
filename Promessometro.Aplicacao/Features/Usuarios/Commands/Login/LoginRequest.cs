namespace Promessometro.Aplicacao.Features.Usuarios.Commands.Login;

public class LoginRequest
{
    public string Email { get; set; } = string.Empty;
    public string Senha { get; set; } = string.Empty;
}