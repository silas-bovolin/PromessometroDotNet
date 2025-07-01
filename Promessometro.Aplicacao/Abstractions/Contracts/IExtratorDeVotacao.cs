using Promessometro.Dominio.Requerimentos;

namespace Promessometro.Aplicacao.Abstractions.Contracts;

public interface IExtratorDeVotacao
{
    public Task<List<Requerimento>> BuscarRequerimentosComVotacoesAsync();
}