using Promessometro.Aplicacao.Abstractions.Contracts;
using Promessometro.Aplicacao.Abstractions.Messaging;
using Promessometro.Aplicacao.Utils;
using Promessometro.Dominio.Abstractions;
using Promessometro.Dominio.Usuarios;

namespace Promessometro.Aplicacao.Features.Usuarios.Commands.Login;

public class LoginHandler(
    IJwtProvider jwtProvider,
    IUsuarioRepository usuarioRepository) : ICommandHandler<LoginCommand, LoginReponse>
{
    public async Task<Result<LoginReponse>> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        var usuario = await usuarioRepository.ObterPorEmailAsync(request.Email, cancellationToken);
        
        if (usuario is null)
        {
            return Result.Failure<LoginReponse>(UsuarioErrors.EmailNaoEncontrada);
        }

        if (!usuario.SenhaCriptografada.Equals(Criptografia.Criptografar(request.Senha)))
        {
            return Result.Failure<LoginReponse>(UsuarioErrors.SenhaIncorreta);
        }

        string token = jwtProvider.Generate(usuario);

        return new LoginReponse(token); 
    }
}