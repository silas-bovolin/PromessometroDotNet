using AutoMapper;
using Promessometro.Aplicacao.Abstractions.Messaging;
using Promessometro.Aplicacao.Features.Promessas.Queries.GetPromessas.Responses;
using Promessometro.Dominio.Abstractions;
using Promessometro.Dominio.Promessas;

namespace Promessometro.Aplicacao.Features.Promessas.Queries.GetPromessas;

public class GetPromessasHandler(
    IMapper mapper,
    IPromessaRepository promessaRepository)
    : IQueryHandler<GetPromessasQuery, List<PromessaResponse>>
{
    public async Task<Result<List<PromessaResponse>>> Handle(GetPromessasQuery request, CancellationToken cancellationToken)
    {
        var promessas = await promessaRepository.GetPromessasComFases(cancellationToken);
        return mapper.Map<List<PromessaResponse>>(promessas);
    }
}