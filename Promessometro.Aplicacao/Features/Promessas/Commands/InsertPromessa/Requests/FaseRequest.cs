namespace Promessometro.Aplicacao.Features.Promessas.Commands.InsertPromessa.Requests;

public class FaseRequest
{
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public int ConclusaoPorcentagem { get; set; }
}