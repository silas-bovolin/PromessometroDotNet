namespace Promessometro.Aplicacao.Features.Usuarios.Commands.Login;

public class LoginReponse
{
    public LoginReponse(string token)
    {
        Token = token;
    }
    public string Token { get; }
}