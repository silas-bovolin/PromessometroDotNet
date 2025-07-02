using AutoMapper;
using Promessometro.Aplicacao.Features.Sigilometros.Queries.GetDadosSigilometro.Responses;
using Promessometro.Dominio.Vereadores;

namespace Promessometro.Aplicacao.MappingProfiles;

public class VereadorProfile : Profile
{
    public VereadorProfile()
    {
        CreateMap<Vereador, VereadorResponse>()
            .ForMember(v => v.ImagemUrl, opt => opt.MapFrom(v => v.CaminhoImagem))
            .ForMember(v => v.QuantidadeRequerimentosRejeitados, opt => opt.MapFrom(v => v.Votos.Where(x => !x.Aprovacao).Count()));
    }
}
