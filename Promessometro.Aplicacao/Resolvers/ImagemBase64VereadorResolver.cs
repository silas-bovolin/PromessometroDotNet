using AutoMapper;
using Promessometro.Aplicacao.Features.Sigilometros.Queries.GetDadosSigilometro.Responses;
using Promessometro.Dominio.Vereadores;

namespace Promessometro.Aplicacao.Resolvers;

internal class ImagemBase64VereadorResolver : IValueResolver<Vereador, VereadorResponse, string>
{
    public string Resolve(Vereador source, VereadorResponse destination, string destMember, ResolutionContext context)
    {
        byte[] imagem = File.ReadAllBytes(source.CaminhoiImagem);
        return Convert.ToBase64String(imagem);
        
    }
}