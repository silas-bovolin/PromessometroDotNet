using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Promessometro.Dominio.Fases;

namespace Promessometro.Infraestrutura.Configurations;

public class FaseConfiguration : IEntityTypeConfiguration<Fase>
{
    public void Configure(EntityTypeBuilder<Fase> builder)
    {
        builder.ToTable("Fases");

        builder.HasKey(f => f.Id);
    }
}