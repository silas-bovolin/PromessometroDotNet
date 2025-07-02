using System.Text.Json;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Promessometro.Aplicacao.Features.Promessas.Commands.InsertPromessa;
using Promessometro.Aplicacao.Features.Promessas.Commands.InsertPromessa.Requests;
using Promessometro.Aplicacao.Features.Promessas.Commands.UpdateConclusaoPromessas;
using Promessometro.Aplicacao.Features.Promessas.Commands.UpdateConclusaoPromessas.Requests;
using Promessometro.Aplicacao.Features.Promessas.Queries.GetPromessas;
using Promessometro.Apresentacao.Api.Extensions;

namespace Promessometro.Apresentacao.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class PromessaController(ISender sender) : ControllerBase
{
    private readonly ISender sender = sender;

    [Authorize]
    [HttpGet]
    public async Task<IActionResult> GetPromessas(CancellationToken cancellationToken)
    {
        var result = await sender.Send(new GetPromessasQuery(), cancellationToken);
        return Ok(JsonSerializer.Serialize(result.Value));
    }

    [Authorize]
    [HttpPost]
    public async Task<IActionResult> InsertPromessa(
        [FromBody] PromessaRequest request,
        CancellationToken cancellationToken)
    {
        var command = new InsertPromessaCommand(request);

        var result = await sender.Send(command, cancellationToken);

        return result.ToActionResult();
    }

    [Authorize]
    [HttpPatch]
    public async Task<IActionResult> UpdateConclusaoPromessa(
        [FromBody] List<ConclusaoPromessaRequest> request,
        CancellationToken cancellationToken)
    {
        var command = new UpdateConclusaoPromessasCommand(request);
        var result = await sender.Send(command, cancellationToken);
        return result.ToActionResult();
    }

}