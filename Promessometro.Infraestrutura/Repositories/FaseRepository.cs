using Promessometro.Dominio.Fases;
using Promessometro.Infraestrutura.Context;

namespace Promessometro.Infraestrutura.Repositories;

public class FaseRepository(PromessometroContext db) : 
    Repository<Fase>(db),
    IFaseRepository
{
}