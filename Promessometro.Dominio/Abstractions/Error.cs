namespace Promessometro.Dominio.Abstractions;

public record Error(string Code, string Name)
{
    public readonly static Error None = new(string.Empty, string.Empty);
    public readonly static Error NullValue = new("Erro.ValorNulo", "Valor nulo recebido");
}
