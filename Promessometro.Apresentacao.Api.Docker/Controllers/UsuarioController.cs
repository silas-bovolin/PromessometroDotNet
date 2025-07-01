using MediatR;
using Microsoft.AspNetCore.Mvc;
using Promessometro.Aplicacao.Features.Usuarios.Commands.Cadastro;
using Promessometro.Aplicacao.Features.Usuarios.Commands.Login;
using Promessometro.Apresentacao.Api.Extensions;

namespace Promessometro.Apresentacao.Api.Controllers;
[ApiController]
[Route("[controller]")]
public class UsuarioController(ISender sender) : ControllerBase
{
    private readonly ISender sender = sender;

    [HttpPost("Login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest, CancellationToken cancellationToken)
    {
        var result = await sender.Send(new LoginCommand(loginRequest.Email, loginRequest.Senha), cancellationToken);
        return result.ToActionResult();
    }

    [HttpPost("Cadastro")]
    public async Task<IActionResult> Cadastro([FromBody] CadastroRequest cadastroRequest, CancellationToken cancellationToken)
    {
        var result = await sender.Send(new CadastroCommand(cadastroRequest.Nome, cadastroRequest.Email, cadastroRequest.Senha, cadastroRequest.Telefone, cadastroRequest.AceitouOsTermos), cancellationToken);
        return result.ToActionResult();
    }
}
