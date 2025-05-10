using Promessometro.Aplicacao.Abstractions.Messaging;
using Promessometro.Aplicacao.Features.Promessas.Queries.GetPromessas.Responses;

namespace Promessometro.Aplicacao.Features.Promessas.Queries.GetPromessas;

public sealed record GetPromessasQuery : IQuery<List<PromessaResponse>>;