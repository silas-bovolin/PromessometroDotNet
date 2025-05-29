using AutoMapper;
using Microsoft.Extensions.Configuration;
using Promessometro.Aplicacao.Features.Sigilometros.Queries.GetDadosSigilometro.Responses;
using Promessometro.Dominio.Vereadores;

namespace Promessometro.Aplicacao.Resolvers;

public class ImagemBase64VereadorResolver(IConfiguration configuration) : IValueResolver<Vereador, VereadorResponse, string>
{
    public string Resolve(Vereador source, VereadorResponse destination, string destMember, ResolutionContext context)
    {
        var caminhoImagemPadrao = configuration.GetRequiredSection("CaminhoImagens").Value;
        string caminhoImagens = Path.Combine(caminhoImagemPadrao!, source.CaminhoImagem);
        byte[] imagem = File.ReadAllBytes(caminhoImagens);
        return Convert.ToBase64String(imagem);
    }
}