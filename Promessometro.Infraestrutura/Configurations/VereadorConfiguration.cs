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

        builder.HasData(
            Vereador.Create("Amélia Naomi", "PT", "amelianaomi.jpg"),
            Vereador.Create("Carlos Abranches", "CIDADANIA", "carlosabranches.jpg"),
            Vereador.Create("Cláudio Apolinário", "PSD", "claudioapolinario.jpg"),
            Vereador.Create("Fabião Zagueiro", "PSD", "fabiaozagueiro.jpg"),
            Vereador.Create("Fernando Petiti", "PSDB", "fernandopetiti.jpg"),
            Vereador.Create("Gilson Campos", "PRD", "gilsoncampos.jpg"),
            Vereador.Create("Juliana Fraga", "PT", "julianafraga.jpg"),
            Vereador.Create("Lino Bispo", "PL", "linobispo.jpg"),
            Vereador.Create("Marcão da Academia", "PSD", "marcaodaacademia.jpg"),
            Vereador.Create("Marcelo Garcia", "PRD", "marcelogarcia.jpg"),
            Vereador.Create("Milton Vieira Filho", "REPUBLICANOS", "miltonvieirafilho.jpg"),
            Vereador.Create("Rafael Pascucci", "PSD", "rafaelpascucci.jpg"),
            Vereador.Create("Renato Santiago", "UNIÃO", "renatosantiago.jpg"),
            Vereador.Create("Roberto Chagas", "PL", "robertochagas.jpg"),
            Vereador.Create("Roberto do Eleven", "PSD", "robertodoeleven.jpg"),
            Vereador.Create("Rogério da Acasem", "PP", "rogeriodaacasem.jpg"),
            Vereador.Create("Senna", "PL", "senna.jpg"),
            Vereador.Create("Sérgio Camargo", "PL", "sergiocamargo.jpg"),
            Vereador.Create("Sidney Campos", "PSDB", "sidneycampos.jpg"),
            Vereador.Create("Thomaz Henrique", "PL", "thomazhenrique.jpg"),
            Vereador.Create("Zé Luís", "PSD", "zeluis.jpg"));
    }
}
