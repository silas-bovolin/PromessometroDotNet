namespace Promessometro.Aplicacao.Features.Promessas.Commands.UpdateConclusaoPromessas.Requests;

public class ConclusaoPromessaRequest
{
    public Guid Id { get; set; }
    public int ConclusaoPorcentagem { get; set; }
    public List<ConclusaoFaseRequest> Fases { get; set; }
}