using Promessometro.Dominio.Votos;
using Promessometro.Infraestrutura.Context;

namespace Promessometro.Infraestrutura.Repositories;

public class VotoRepository(PromessometroContext db) :
    Repository<Voto>(db),
    IVotoRepository
{
}