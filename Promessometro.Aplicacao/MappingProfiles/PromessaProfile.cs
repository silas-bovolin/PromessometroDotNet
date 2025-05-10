using AutoMapper;
using Promessometro.Aplicacao.Features.Promessas.Commands.InsertPromessa.Requests;
using Promessometro.Aplicacao.Features.Promessas.Queries.GetPromessas.Responses;
using Promessometro.Dominio.Promessas;

namespace Promessometro.Aplicacao.MappingProfiles;

public class PromessaProfile : Profile
{
    public PromessaProfile()
    {
        CreateMap<Promessa, PromessaResponse>();
        CreateMap<PromessaRequest, Promessa>();
    }
}