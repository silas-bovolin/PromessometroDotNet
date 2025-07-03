using MediatR;
using Promessometro.Aplicacao.Abstractions.Messaging;
using Promessometro.Aplicacao.Utils;
using Promessometro.Dominio.Abstractions;
using Promessometro.Dominio.Usuarios;
using System.Text.RegularExpressions;

namespace Promessometro.Aplicacao.Features.Usuarios.Commands.Cadastro;

public partial class CadastroHandler(
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

        var telefoneRegex = ValidadorTelefone();

        if (!telefoneRegex.Match(request.Telefone).Success)
        {
            return Result.Failure<Unit>(UsuarioErrors.TelefoneInvalido);
        }

        var emailRegex = ValidadorEmail();

        if (!emailRegex.Match(request.Email).Success)
        {
            return Result.Failure<Unit>(UsuarioErrors.EmailInvalido);
        }

        if (request.Senha.Length < 5)
        {
            return Result.Failure<Unit>(UsuarioErrors.SenhaNaoAtendeRequisitos);
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

    //Telefone deve estar no padrão "5500000000000"
    [GeneratedRegex(@"^55\d{11}$")]
    private static partial Regex ValidadorTelefone();

    //Email deve ester no padrão "xxxx@dominio"
    [GeneratedRegex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")]
    private static partial Regex ValidadorEmail();
}