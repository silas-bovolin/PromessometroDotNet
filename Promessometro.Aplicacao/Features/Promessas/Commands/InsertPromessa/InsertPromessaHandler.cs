using Promessometro.Aplicacao.Abstractions.Messaging;
using Promessometro.Dominio.Abstractions;
using Promessometro.Dominio.Fases;
using Promessometro.Dominio.Promessas;

namespace Promessometro.Aplicacao.Features.Promessas.Commands.InsertPromessa;

public class InsertPromessaHandler(
    IFaseRepository faseRepository,
    IPromessaRepository promessaRepository,
    IUnitOfWork unitOfWork) : ICommandHandler<InsertPromessaCommand, Guid>
{
    public async Task<Result<Guid>> Handle(InsertPromessaCommand request, CancellationToken cancellationToken)
    {
        var promessa = Promessa.Create(
            request.Promessa.Titulo,
            request.Promessa.Descricao,
            request.Promessa.ConclusaoPorcentagem,
            request.Promessa.Detalhes
        );

        promessaRepository.Add(promessa);

        foreach (var faseRequest in request.Promessa.Fases)
        {
            var fase = Fase.Create(
                faseRequest.Titulo,
                faseRequest.Descricao,
                faseRequest.ConclusaoPorcentagem,
                promessa.Id
            );

            faseRepository.Add(fase);
        }

        await unitOfWork.SaveChangesAsync(cancellationToken);

        return promessa.Id;
    }
}