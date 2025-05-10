using AutoMapper;
using Promessometro.Aplicacao.Features.Sigilometros.Queries.GetDadosSigilometro.Responses;
using Promessometro.Aplicacao.Resolvers;
using Promessometro.Dominio.Vereadores;

namespace Promessometro.Aplicacao.MappingProfiles;

public class VereadorProfile : Profile
{
    public VereadorProfile()
    {
        CreateMap<Vereador, VereadorResponse>()
            .ForMember(v => v.ImagemBase64, opt => opt.MapFrom<ImagemBase64VereadorResolver>())
            .ForMember(v => v.QuantidadeRequerimentosRejeitados, opt => opt.MapFrom(v => v.Votos.Where(x => !x.Aprovacao).Count()));
    }
}
