using Promessometro.Dominio.Abstractions;

namespace Promessometro.Dominio.Promessas;

public class PromessaErrors
{
    public readonly static Error NaoEncontrada = new(
        "Promessa.NaoEncontrada",
        "A promessa com o identificador informado não foi encontrada");

    public readonly static Error ConclusaoMenorQueAtual = new(
        "Promessa.ConclusaoPorcentagem",
        "A conclusão da promessa informada não pode ser menor do que a conclusão atual");
}