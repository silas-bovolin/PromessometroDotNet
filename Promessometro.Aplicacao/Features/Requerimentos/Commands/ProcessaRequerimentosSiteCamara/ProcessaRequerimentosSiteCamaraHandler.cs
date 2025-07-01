using MediatR;
using Promessometro.Aplicacao.Abstractions.Contracts;
using Promessometro.Aplicacao.Abstractions.Messaging;
using Promessometro.Dominio.Abstractions;

namespace Promessometro.Aplicacao.Features.Requerimentos.Commands.ProcessaRequerimentosSiteCamara;

public class ProcessaRequerimentosSiteCamaraHandler
    : ICommandHandler<ProcessaRequerimentosSiteCamaraCommand, Unit>
{
    public Task<Result<Unit>> Handle(ProcessaRequerimentosSiteCamaraCommand request, CancellationToken cancellationToken)
    {
        //leitura dos arquivos
        //para cada arquivo, identificação dos requerimentos e votações dos parlamentares

        //armazenamento no banco de dados
        throw new NotImplementedException();
    }
}