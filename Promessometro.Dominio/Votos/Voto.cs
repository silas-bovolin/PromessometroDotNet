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
}