using MediatR;
using Promessometro.Dominio.Abstractions;

namespace Promessometro.Aplicacao.Abstractions.Messaging;

public interface ICommandHandler<TCommand, TResponse> : IRequestHandler<TCommand, Result<TResponse>>
    where TCommand : ICommand<TResponse> { }