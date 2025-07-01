using MediatR;
using Promessometro.Aplicacao.Abstractions.Messaging;
using Promessometro.Aplicacao.Utils;
using Promessometro.Dominio.Abstractions;
using Promessometro.Dominio.Usuarios;

namespace Promessometro.Aplicacao.Features.Usuarios.Commands.Cadastro;

public class CadastroHandler(
    IUsuarioRepository usuarioRepository,
    IUnitOfWork unitOfWork) : ICommandHandler<CadastroCommand, Unit>
{
    public async Task<Result<Unit>> Handle(CadastroCommand request, CancellationToken cancellationToken)
    {
        var usuario = await usuarioRepository.ObterPorEmailAsync(request.Email, cancellationToken);

        if (usuario is not null)
        {
            return Result.Failure<Unit>(UsuarioErrors.EmailJaRegistrado);
        }

        if (!request.AceitouOsTermos)
        {
            return Result.Failure<Unit>(UsuarioErrors.TermosNaoAceitos);
        }

        usuarioRepository.Add(
        Usuario.Create(request.Nome,
            request.Email,
            Criptografia.Criptografar(request.Senha),
            request.Telefone,
            request.AceitouOsTermos));

        await unitOfWork.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}