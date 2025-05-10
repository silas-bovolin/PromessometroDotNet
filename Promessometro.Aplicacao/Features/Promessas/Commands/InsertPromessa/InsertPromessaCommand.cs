using Promessometro.Aplicacao.Abstractions.Messaging;
using Promessometro.Aplicacao.Features.Promessas.Commands.InsertPromessa.Requests;

namespace Promessometro.Aplicacao.Features.Promessas.Commands.InsertPromessa;

public sealed record InsertPromessaCommand(PromessaRequest Promessa) : ICommand<Guid>;