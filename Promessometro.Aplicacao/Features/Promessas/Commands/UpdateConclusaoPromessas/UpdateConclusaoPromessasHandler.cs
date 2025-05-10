using MediatR;
using Promessometro.Aplicacao.Abstractions.Messaging;
using Promessometro.Dominio.Abstractions;
using Promessometro.Dominio.Fases;
using Promessometro.Dominio.Promessas;

namespace Promessometro.Aplicacao.Features.Promessas.Commands.UpdateConclusaoPromessas;

public class UpdateConclusaoPromessasHandler(
    IFaseRepository faseRepository,
    IPromessaRepository promessaRepository,
    IUnitOfWork unitOfWork) : ICommandHandler<UpdateConclusaoPromessasCommand, Unit>
{
    public async Task<Result<Unit>> Handle(UpdateConclusaoPromessasCommand request, CancellationToken cancellationToken)
    {
        foreach (var promessa in request.Promessas)
        {
            var promessaDesatualizada = await promessaRepository.GetById(promessa.Id, cancellationToken);

            if (promessaDesatualizada is null)
            {
                return Result.Failure<Unit>(PromessaErrors.NaoEncontrada);
            }

            var resultadoPromessaAtualizada = promessaDesatualizada.UpdateConclusaoPorcentagem(promessa.ConclusaoPorcentagem);

            if (resultadoPromessaAtualizada.IsFailure)
            {
                return Result.Failure<Unit>(resultadoPromessaAtualizada.Error);
            }

            foreach (var fase in promessa.Fases)
            {
                var faseDesatualizada = await faseRepository.GetById(fase.Id, cancellationToken);

                if (faseDesatualizada is null)
                {
                    return Result.Failure<Unit>(FaseErrors.NaoEncontrada);
                }

                var resultadoFaseAtualizada = faseDesatualizada.UpdateConclusaoPorcentagem(fase.ConclusaoPorcentagem);

                if (resultadoFaseAtualizada.IsFailure)
                {
                    return Result.Failure<Unit>(resultadoFaseAtualizada.Error);
                }
            }
        }

        await unitOfWork.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}