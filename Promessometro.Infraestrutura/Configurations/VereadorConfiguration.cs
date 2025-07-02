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
            Vereador.Create("Amélia Naomi", "PT", "https://camarasempapel.camarasjc.sp.gov.br/arquivo/images/pessoas/1b2tm1j43b44bi2878n1.jpg"),
            Vereador.Create("Carlos Abranches", "CIDADANIA", "https://camarasempapel.camarasjc.sp.gov.br/arquivo/images/pessoas/nka40a6581ghp7uuc263.jpg"),
            Vereador.Create("Cláudio Apolinário", "PSD", "https://camarasempapel.camarasjc.sp.gov.br/arquivo/images/pessoas/2h3fn76bsw3xjchm50m6.jpg"),
            Vereador.Create("Fabião Zagueiro", "PSD", "https://camarasempapel.camarasjc.sp.gov.br/arquivo/images/pessoas/261s12lofv4q281is652.jpg"),
            Vereador.Create("Fernando Petiti", "PSDB", "https://camarasempapel.camarasjc.sp.gov.br/arquivo/images/pessoas/y1epxj4jt6526xsc33b7.jpg"),
            Vereador.Create("Gilson Campos", "PRD", "https://camarasempapel.camarasjc.sp.gov.br/arquivo/images/pessoas/2nw2d3kmtm8eaus81j38.jpg"),
            Vereador.Create("Juliana Fraga", "PT", "https://camarasempapel.camarasjc.sp.gov.br/arquivo/images/pessoas/5jv7j63k76721878fkha.jpg"),
            Vereador.Create("Lino Bispo", "PL", "https://camarasempapel.camarasjc.sp.gov.br/arquivo/images/pessoas/50a1ksm38yqo07a70y23.jpg"),
            Vereador.Create("Marcão da Academia", "PSD", "https://camarasempapel.camarasjc.sp.gov.br/arquivo/images/pessoas/l706down3d3r37q8mb40.jpg"),
            Vereador.Create("Marcelo Garcia", "PRD", "https://camarasempapel.camarasjc.sp.gov.br/arquivo/images/pessoas/kx44kd5w57y333geu33i.jpg"),
            Vereador.Create("Milton Vieira Filho", "REPUBLICANOS", "https://camarasempapel.camarasjc.sp.gov.br/arquivo/images/pessoas/x782015ys02p1u205nyq.jpg"),
            Vereador.Create("Rafael Pascucci", "PSD", "https://camarasempapel.camarasjc.sp.gov.br/arquivo/images/pessoas/5co8mw162kh72optvxv7.jpg"),
            Vereador.Create("Renato Santiago", "UNIÃO", "https://camarasempapel.camarasjc.sp.gov.br/arquivo/images/pessoas/w2df70h1ac0m6g28y8f5.jpg"),
            Vereador.Create("Roberto Chagas", "PL", "https://camarasempapel.camarasjc.sp.gov.br/arquivo/images/pessoas/11x3521c2h31ms7o7ptt.jpg"),
            Vereador.Create("Roberto do Eleven", "PSD", "https://www.camarasjc.sp.gov.br/arquivo/thumb/vereadores/43b65ee2678cc21d127e_336x441_0_0.jpg"),
            Vereador.Create("Rogério da Acasem", "PP", "https://camarasempapel.camarasjc.sp.gov.br/arquivo/images/pessoas/7188t2p5tn44teiyxp21.jpg"),
            Vereador.Create("Senna", "PL", "https://camarasempapel.camarasjc.sp.gov.br/arquivo/images/pessoas/5ky0k0nfx04e7343q0u6.jpg"),
            Vereador.Create("Sérgio Camargo", "PL", "https://camarasempapel.camarasjc.sp.gov.br/arquivo/images/pessoas/m003n58e7y20dh5q16e0.jpg"),
            Vereador.Create("Sidney Campos", "PSDB", "https://camarasempapel.camarasjc.sp.gov.br/arquivo/images/pessoas/76en5j22dic35juc4w40.jpg"),
            Vereador.Create("Thomaz Henrique", "PL", "https://camarasempapel.camarasjc.sp.gov.br/arquivo/images/pessoas/4a7v208k545r10rve48p.jpg"),
            Vereador.Create("Zé Luís", "PSD", "https://camarasempapel.camarasjc.sp.gov.br/arquivo/images/pessoas/fngh4n0h1l76y1y213ua.jpg"));
    }
}
