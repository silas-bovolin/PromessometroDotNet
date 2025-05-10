namespace Promessometro.Aplicacao.Features.Promessas.Commands.InsertPromessa.Requests;

public class PromessaRequest
{
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public int ConclusaoPorcentagem { get; set; }
    public string Detalhes { get; set; }
    public List<FaseRequest> Fases { get; set; }
}