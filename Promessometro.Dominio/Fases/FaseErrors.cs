using Promessometro.Dominio.Abstractions;

namespace Promessometro.Dominio.Fases;

public class FaseErrors
{
    public readonly static Error NaoEncontrada = new(
        "Fase.NaoEncontrada",
        "A fase com o identificador informado não foi encontrada");

    public readonly static Error ConclusaoMenorQueAtual = new(
        "Fase.ConclusaoPorcentagem",
        "A conclusão da fase informada não pode ser menor do que a conclusão atual");
}