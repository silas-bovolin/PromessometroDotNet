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
    public async Task<IActionResult> Login(string email, string senha, CancellationToken cancellationToken)
    {
        var result = await sender.Send(new LoginCommand(email, senha), cancellationToken);
        return result.ToActionResult();
    }
}
