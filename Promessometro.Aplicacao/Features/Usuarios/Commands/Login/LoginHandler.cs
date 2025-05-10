using Promessometro.Aplicacao.Abstractions.Messaging;
using Promessometro.Dominio.Abstractions;

namespace Promessometro.Aplicacao.Features.Usuarios.Commands.Login;

public class LoginHandler : ICommandHandler<LoginCommand, string>
{
    public Task<Result<string>> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}