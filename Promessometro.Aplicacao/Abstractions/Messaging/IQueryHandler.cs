using MediatR;
using Promessometro.Dominio.Abstractions;

namespace Promessometro.Aplicacao.Abstractions.Messaging;

public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>>
    where TQuery : IQuery<TResponse>
{
}