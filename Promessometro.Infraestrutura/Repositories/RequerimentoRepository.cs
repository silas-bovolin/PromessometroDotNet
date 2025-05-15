using Promessometro.Dominio.Requerimentos;
using Promessometro.Infraestrutura.Context;

namespace Promessometro.Infraestrutura.Repositories;

public class RequerimentoRepository(PromessometroContext db) :
    Repository<Requerimento>(db),
    IRequerimentoRepository
{
}