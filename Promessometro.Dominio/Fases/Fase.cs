using Promessometro.Dominio.Abstractions;
using Promessometro.Dominio.Promessas;

namespace Promessometro.Dominio.Fases;

public class Fase : Entity
{
    private Fase(Guid id, string titulo, string descricao, int conclusaoPorcentagem, Guid promessaId)
        : base(id)
    {
        Titulo = titulo;
        Descricao = descricao;
        ConclusaoPorcentagem = conclusaoPorcentagem;
        PromessaId = promessaId;
    }
    public Fase() { }
    public string Titulo { get; private init; }
    public string Descricao { get; private init; }
    public int ConclusaoPorcentagem { get; private init; }
    public Guid PromessaId { get; private init; }
    public Promessa Promessa { get; private init; }
    public static Fase Create(string titulo, string descricao, int conclusaoPorcentagem, Guid promessaId)
    {
        var id = Guid.NewGuid();
        return new Fase(id, titulo, descricao, conclusaoPorcentagem, promessaId);
    }

    public Result UpdateConclusaoPorcentagem(int conclusaoPorcentagem)
    {
        if (conclusaoPorcentagem < ConclusaoPorcentagem)
        {
            return Result.Failure<Fase>(FaseErrors.ConclusaoMenorQueAtual);
        }

        ConclusaoPorcentagem = conclusaoPorcentagem;

        return Result.Success(this);
    }
}