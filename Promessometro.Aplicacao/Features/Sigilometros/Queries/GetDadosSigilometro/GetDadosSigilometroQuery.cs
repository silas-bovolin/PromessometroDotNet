using Promessometro.Aplicacao.Abstractions.Messaging;
using Promessometro.Aplicacao.Features.Sigilometros.Queries.GetDadosSigilometro.Responses;

namespace Promessometro.Aplicacao.Features.Sigilometros.Queries.GetDadosSigilometro;

public sealed record GetDadosSigilometroQuery : IQuery<SigilometroResponse>;