using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Promessometro.Dominio.Vereadores;

namespace Promessometro.Infraestrutura.Configurations;

public class VereadorConfiguration : IEntityTypeConfiguration<Vereador>
{
    public void Configure(EntityTypeBuilder<Vereador> builder)
    {
        builder.ToTable("Vereadores");

        builder.HasKey(v => v.Id);
    }
}
