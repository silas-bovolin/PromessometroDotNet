using Promessometro.Aplicacao.Abstractions.Contracts;
using Promessometro.Aplicacao.Abstractions.Messaging;
using Promessometro.Aplicacao.Utils;
using Promessometro.Dominio.Abstractions;
using Promessometro.Dominio.Usuarios;

namespace Promessometro.Aplicacao.Features.Usuarios.Commands.Login;

public class LoginHandler(
    IJwtProvider jwtProvider,
    IUsuarioRepository usuarioRepository) : ICommandHandler<LoginCommand, string>
{
    public async Task<Result<string>> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        var usuario = await usuarioRepository.ObterPorEmailAsync(request.Email, cancellationToken);

        if (usuario is null)
        {
            return Result.Failure<string>(UsuarioErrors.EmailNaoEncontrada);
        }

        if (!usuario.SenhaCriptografada.Equals(Criptografia.Criptografar(request.Senha)))
        {
            return Result.Failure<string>(UsuarioErrors.SenhaIncorreta);
        }

        string token = jwtProvider.Generate(usuario);

        return token;
    }
}