namespace Promessometro.Aplicacao.Features.Sigilometros.Queries.GetDadosSigilometro.Responses;

public class SigilometroResponse
{
    public List<VereadorResponse> Vereadores { get; set; }
    public int QuantidadeRequerimentosRejeitados { get; set; }
    public int QuantidadeRequerimentosAceitos { get; set; }
}
