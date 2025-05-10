namespace Promessometro.Aplicacao.Features.Promessas.Commands.UpdateConclusaoPromessas.Requests;

public class ConclusaoFaseRequest
{
    public Guid Id { get; set; }
    public int ConclusaoPorcentagem { get; set; }
}