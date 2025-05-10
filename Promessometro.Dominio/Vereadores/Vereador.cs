using Promessometro.Dominio.Abstractions;
using Promessometro.Dominio.Votos;

namespace Promessometro.Dominio.Vereadores;

public class Vereador : Entity
{
    public string Nome { get; private init; }
    public string Partido { get; private init; }
    public string CaminhoiImagem { get; private init; }
    public List<Voto> Votos { get; private set; }

}
