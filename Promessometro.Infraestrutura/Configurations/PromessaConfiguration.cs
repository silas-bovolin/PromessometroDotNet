using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Promessometro.Dominio.Promessas;

namespace Promessometro.Infraestrutura.Configurations;

public class PromessaConfiguration : IEntityTypeConfiguration<Promessa>
{
    public void Configure(EntityTypeBuilder<Promessa> builder)
    {
        builder.ToTable("Promessas");

        builder.HasKey(p => p.Id);
    }
}