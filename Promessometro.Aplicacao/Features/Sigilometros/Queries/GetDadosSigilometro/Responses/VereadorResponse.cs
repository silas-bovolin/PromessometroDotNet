namespace Promessometro.Aplicacao.Features.Sigilometros.Queries.GetDadosSigilometro.Responses;

public class VereadorResponse
{
    public string Nome { get; set; }
    public string Partido { get; set; }
    public string ImagemBase64 { get; set; } 
    public int QuantidadeRequerimentosRejeitados { get; set; }
}