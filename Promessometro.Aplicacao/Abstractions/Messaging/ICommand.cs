using MediatR;
using Promessometro.Dominio.Abstractions;

namespace Promessometro.Aplicacao.Abstractions.Messaging;

public interface ICommand : IRequest<Result> { }
public interface ICommand<TResponse> : IRequest<Result<TResponse>> { }