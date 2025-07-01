namespace Promessometro.Aplicacao.Features.Usuarios.Commands.Cadastro;

public class CadastroRequest
{
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Senha { get; set; } = string.Empty;
    public string Telefone { get; set; } = string.Empty;
    public bool AceitouOsTermos { get; set; }
}