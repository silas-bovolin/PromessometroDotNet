using MediatR;
using Promessometro.Aplicacao.Abstractions.Messaging;

namespace Promessometro.Aplicacao.Features.Requerimentos.Commands.ProcessaRequerimentosSiteCamara;

public sealed record ProcessaRequerimentosSiteCamaraCommand : ICommand<Unit>;