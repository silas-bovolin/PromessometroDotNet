using Promessometro.Dominio.Abstractions;
using Promessometro.Dominio.Votos;

namespace Promessometro.Dominio.Requerimentos;

public class Requerimento : Entity
{
    public string Codigo { get; private init; }
    public bool Aprovado { get; private init; }
    public List<Voto> Votos { get; private set; }
    private Requerimento(Guid id, string codigo, bool aprovado)
        : base(id)
    {
        Codigo = codigo;
        Aprovado = aprovado;
        Votos = [];
    }
    public Requerimento() { }
    public static Requerimento Create(string codigo, bool aprovado)
    {
        var id = Guid.NewGuid();
        return new Requerimento(id, codigo, aprovado);
    }
}
