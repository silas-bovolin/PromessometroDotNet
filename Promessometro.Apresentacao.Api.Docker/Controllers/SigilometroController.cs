using System.Text.Json;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Promessometro.Aplicacao.Features.Sigilometros.Queries.GetDadosSigilometro;

namespace Promessometro.Apresentacao.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class SigilometroController(ISender sender) : ControllerBase
{
    private readonly ISender sender = sender;

    [Authorize]
    [HttpGet]
    public async Task<IActionResult> GetSigilometro(CancellationToken cancellationToken)
    {
        var result = await sender.Send(new GetDadosSigilometroQuery(), cancellationToken);
        return Ok(JsonSerializer.Serialize(result.Value));
    }
}