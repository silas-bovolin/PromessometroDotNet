using Promessometro.Aplicacao.Abstractions.Messaging;

namespace Promessometro.Aplicacao.Features.Usuarios.Commands.Login;

public sealed record LoginCommand(string Email, string Senha) : ICommand<LoginReponse>;