using AutoMapper;
using Promessometro.Aplicacao.Features.Promessas.Commands.InsertPromessa.Requests;
using Promessometro.Aplicacao.Features.Promessas.Queries.GetPromessas.Responses;
using Promessometro.Dominio.Fases;

namespace Promessometro.Aplicacao.MappingProfiles;

public class FaseProfile : Profile
{
    public FaseProfile()
    {
        CreateMap<Fase, FaseResponse>();
        CreateMap<FaseRequest, Fase>();
    }
}