namespace Promessometro.Aplicacao.Features.Promessas.Queries.GetPromessas.Responses;

public class PromessaResponse
{
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public int ConclusaoPorcentagem { get; set; }
    public string Detalhes { get; set; }
    public List<FaseResponse> Fases { get; set; }
}