using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Promessometro.Dominio.Votos;

namespace Promessometro.Infraestrutura.Configurations;

public class VotoConfiguration : IEntityTypeConfiguration<Voto>
{
    public void Configure(EntityTypeBuilder<Voto> builder)
    {
        builder.ToTable("Votos");

        builder.HasKey(v => new { v.VereadorId, v.RequerimentoId });
    }
}