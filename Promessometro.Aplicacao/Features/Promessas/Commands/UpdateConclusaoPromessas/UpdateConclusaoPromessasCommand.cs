using MediatR;
using Promessometro.Aplicacao.Abstractions.Messaging;
using Promessometro.Aplicacao.Features.Promessas.Commands.UpdateConclusaoPromessas.Requests;

namespace Promessometro.Aplicacao.Features.Promessas.Commands.UpdateConclusaoPromessas;

public sealed record UpdateConclusaoPromessasCommand(List<ConclusaoPromessaRequest> Promessas)
    : ICommand<Unit>;
