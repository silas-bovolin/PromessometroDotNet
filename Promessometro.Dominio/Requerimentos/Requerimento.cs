using Promessometro.Dominio.Abstractions;
using Promessometro.Dominio.Votos;

namespace Promessometro.Dominio.Requerimentos;

public class Requerimento : Entity
{
    public string Codigo { get; private init; }
    public string Descricao { get; private init; }
    public bool Aprovado { get; private init; }
    public List<Voto> Votos { get; private set; }
}
