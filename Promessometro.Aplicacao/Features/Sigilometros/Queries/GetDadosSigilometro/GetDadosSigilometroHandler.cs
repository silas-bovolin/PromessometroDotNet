using AutoMapper;
using Promessometro.Aplicacao.Abstractions.Messaging;
using Promessometro.Aplicacao.Features.Sigilometros.Queries.GetDadosSigilometro.Responses;
using Promessometro.Dominio.Abstractions;
using Promessometro.Dominio.Requerimentos;
using Promessometro.Dominio.Vereadores;

namespace Promessometro.Aplicacao.Features.Sigilometros.Queries.GetDadosSigilometro;

public class GetDadosSigilometroHandler(
    IMapper mapper,
    IVereadorRepository vereadorRepository,
    IRequerimentoRepository requerimentoRepository) : IQueryHandler<GetDadosSigilometroQuery, SigilometroResponse>
{
    private readonly IMapper mapper = mapper;
    private readonly IVereadorRepository vereadorRepository = vereadorRepository;
    public async Task<Result<SigilometroResponse>> Handle(GetDadosSigilometroQuery request, CancellationToken cancellationToken)
    {
        var vereadores = await vereadorRepository.GetVereadoresEVotosAsync(cancellationToken);
        var requerimentos = await requerimentoRepository.GetAllAsync(cancellationToken);

        SigilometroResponse sigilometro = new();
        sigilometro.Vereadores = mapper.Map<List<VereadorResponse>>(sigilometro.Vereadores);
        sigilometro.QuantidadeRequerimentosAceitos = requerimentos.Where(r => r.Aprovado).Count();
        sigilometro.QuantidadeRequerimentosRejeitados = requerimentos.Count - sigilometro.QuantidadeRequerimentosAceitos;

        return sigilometro;
    }
}