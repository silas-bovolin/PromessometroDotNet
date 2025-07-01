using MediatR;
using Promessometro.Aplicacao.Abstractions.Contracts;
using Promessometro.Aplicacao.Abstractions.Messaging;
using Promessometro.Dominio.Abstractions;

namespace Promessometro.Aplicacao.Features.Requerimentos.Commands.ProcessaRequerimentosSiteCamara;

public class ProcessaRequerimentosSiteCamaraHandler(
    IExtratorDeVotacao extratoDaVotacao)
    : ICommandHandler<ProcessaRequerimentosSiteCamaraCommand, Unit>
{
    public async Task<Result<Unit>> Handle(ProcessaRequerimentosSiteCamaraCommand request, CancellationToken cancellationToken)
    {
        //leitura dos arquivos
        var requerimentos = await extratoDaVotacao.BuscarRequerimentosComVotacoesAsync();
        //para cada arquivo, identificação dos requerimentos e votações dos parlamentares

        //armazenamento no banco de dados
        throw new NotImplementedException();
    }
}