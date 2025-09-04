namespace Promessometro.Aplicacao.Features.Sigilometros.Queries.GetDadosSigilometro.Responses;

public class VereadorResponse
{
    public string Nome { get; set; }
    public string Partido { get; set; }
    public string ImagemUrl { get; set; } 
    public int QuantidadeRequerimentosRejeitados { get; set; }
    public int QuantidadeRequerimentosAceitos { get; set; }
}