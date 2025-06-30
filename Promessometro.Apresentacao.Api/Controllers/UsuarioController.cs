using MediatR;
using Microsoft.AspNetCore.Mvc;
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
}
