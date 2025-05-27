using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Promessometro.Dominio.Requerimentos;

namespace Promessometro.Infraestrutura.Configurations;

public class RequerimentoConfiguration : IEntityTypeConfiguration<Requerimento>
{
    public void Configure(EntityTypeBuilder<Requerimento> builder)
    {
        builder.ToTable("Requerimentos");

        builder.HasKey(r => r.Id);
    }
}