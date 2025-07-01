using MediatR;
using Promessometro.Aplicacao.Abstractions.Messaging;

namespace Promessometro.Aplicacao.Features.Usuarios.Commands.Cadastro;

public sealed record CadastroCommand(string Nome, string Email, string Senha, string Telefone, bool AceitouOsTermos)
    : ICommand<Unit>;