using Microsoft.EntityFrameworkCore;
using Promessometro.Dominio.Abstractions;
using Promessometro.Dominio.Fases;
using Promessometro.Dominio.Promessas;
using Promessometro.Dominio.Requerimentos;
using Promessometro.Dominio.Usuarios;
using Promessometro.Dominio.Vereadores;
using Promessometro.Dominio.Votos;

namespace Promessometro.Infraestrutura.Context;

public class PromessometroContext(
    DbContextOptions<PromessometroContext> options) : DbContext(options), IUnitOfWork
{
    public DbSet<Fase> Fases { get; set; }
    public DbSet<Promessa> Promessas { get; set; }
    public DbSet<Requerimento> Requerimentos { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Vereador> Vereadores { get; set; }
    public DbSet<Voto> Votos { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PromessometroContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}