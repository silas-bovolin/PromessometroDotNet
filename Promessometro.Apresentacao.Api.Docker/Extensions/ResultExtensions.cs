using Microsoft.AspNetCore.Mvc;
using Promessometro.Dominio.Abstractions;

namespace Promessometro.Apresentacao.Api.Extensions;

public static class ResultExtensions
{
    public static IActionResult ToActionResult<T>(
        this Result<T> result)
    {
        if (result.IsFailure)
        {
            return new BadRequestObjectResult(result.Error);
        }

        return new OkObjectResult(result.Value);
    }
}