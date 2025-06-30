using Promessometro.Dominio.Abstractions;
using Promessometro.Dominio.Votos;

namespace Promessometro.Dominio.Vereadores;

public class Vereador : Entity
{
    public string Nome { get; private init; }
    public string Partido { get; private init; }
    public string CaminhoImagem { get; private init; }
    public List<Voto> Votos { get; private set; }

    private Vereador(Guid id, string nome, string partido, string caminhoImagem)
        : base(id)
    {
        Nome = nome;
        Partido = partido;
        CaminhoImagem = caminhoImagem;
        Votos = [];
    }

    public Vereador() { }
    
    public static Vereador Create(string nome, string partido, string caminhoImagem)
    {
        var id = Guid.NewGuid();
        return new Vereador(id, nome, partido, caminhoImagem);
    } 
}
