using Promessometro.Dominio.Abstractions;
using Promessometro.Dominio.Fases;

namespace Promessometro.Dominio.Promessas;

public class Promessa : Entity
{
    private Promessa(Guid id, string titulo, string descricao, int conclusao, string detalhes)
        : base(id)
    {
        Titulo = titulo;
        Descricao = descricao;
        ConclusaoPorcentagem = conclusao;
        Detalhes = detalhes;
    }
    public Promessa() { }
    public string Titulo { get; private init; }
    public string Descricao { get; private init; }
    public int ConclusaoPorcentagem { get; private set; }
    public string Detalhes { get; private init; }
    public List<Fase> Fases { get; private init; }

    public static Promessa Create(string titulo, string descricao, int conclusao, string detalhes)
    {
        var id = Guid.NewGuid();
        return new Promessa(id, titulo, descricao, conclusao, detalhes);
    }

    public Result UpdateConclusaoPorcentagem(int conclusaoPorcentagem)
    {
        if (conclusaoPorcentagem < ConclusaoPorcentagem)
        {
            return Result.Failure<Promessa>(PromessaErrors.ConclusaoMenorQueAtual);
        }

        ConclusaoPorcentagem = conclusaoPorcentagem;

        return Result.Success(this);
    }
}
