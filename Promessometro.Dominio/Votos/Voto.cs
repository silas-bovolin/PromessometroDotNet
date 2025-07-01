using Promessometro.Dominio.Requerimentos;
using Promessometro.Dominio.Vereadores;

namespace Promessometro.Dominio.Votos;

public class Voto
{
    public Guid RequerimentoId { get; private init; }
    public Guid VereadorId { get; private init; }
    public bool Aprovacao { get; private init; }
    public Requerimento Requerimento { get; private init; }
    public Vereador Vereador { get; private init; }
    private Voto(Guid requerimentoId, Guid vereadorId, bool aprovacao)
    {
        RequerimentoId = requerimentoId;
        VereadorId = vereadorId;
        Aprovacao = aprovacao;
    }
    public Voto() { }
    public static Voto Create(Guid requerimentoId, Guid vereadorId, bool aprovacao)
    {
        return new Voto(requerimentoId, vereadorId, aprovacao);
    }
}