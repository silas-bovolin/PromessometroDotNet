using Promessometro.Dominio.Requerimentos;

namespace Promessometro.Aplicacao.Abstractions.Contracts;

public interface IExtratoDaVotacao
{
    public List<Requerimento> BuscarRequerimentosComVotacoes();
}