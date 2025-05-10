using MediatR;
using Promessometro.Dominio.Abstractions;

namespace Promessometro.Aplicacao.Abstractions.Messaging;

public interface IQuery<IResponse> : IRequest<Result<IResponse>> { }