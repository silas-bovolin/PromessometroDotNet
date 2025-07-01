using MediatR;
using Promessometro.Aplicacao.Abstractions.Contracts;
using Promessometro.Aplicacao.Abstractions.Messaging;
using Promessometro.Dominio.Abstractions;
using Promessometro.Dominio.Requerimentos;
using Promessometro.Dominio.Votos;

namespace Promessometro.Aplicacao.Features.Requerimentos.Commands.ProcessaRequerimentosSiteCamara;

public class ProcessaRequerimentosSiteCamaraHandler(
    IExtratorDeVotacao extratoDaVotacao,
    IRequerimentoRepository requerimentoRepository,
    IVotoRepository votoRepository,
    IUnitOfWork unitOfWork)
    : ICommandHandler<ProcessaRequerimentosSiteCamaraCommand, Unit>
{
    public async Task<Result<Unit>> Handle(ProcessaRequerimentosSiteCamaraCommand request, CancellationToken cancellationToken)
    {
        var requerimentos = await extratoDaVotacao.BuscarRequerimentosComVotacoesAsync();

        foreach (var requerimento in requerimentos)
        {
            var requerimentoJaRegistrado = await requerimentoRepository.GetByCodigoAsync(requerimento.Codigo, cancellationToken);
            if (requerimentoJaRegistrado is not null)
            {
                continue;
            }
            requerimentoRepository.Add(requerimento);
            foreach (var voto in requerimento.Votos)
            {
                votoRepository.Add(voto);
            }
            await unitOfWork.SaveChangesAsync(cancellationToken);
        }
        return Unit.Value;
    }
}