using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Promessometro.Infraestrutura.Migrations
{
    /// <inheritdoc />
    public partial class ArrumandoCaminhoImagem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: new Guid("8e54ceb0-04ef-41ac-8cc1-e857827ba790"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("0d5c5cea-aea7-44ab-93e7-3b93b284839a"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("1e918a99-36d5-4d37-b862-eddb4909575b"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("2792b548-f56a-4df8-a10d-c74136104b29"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("2a763dee-a189-410f-91d3-08274608cc2c"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("46b7b815-4dc4-4b04-9943-4e15cb69a3a3"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("47f336a2-05d6-43e0-9d54-9ca34d79fcdf"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("4a09d1c3-90e4-4afa-a8b8-18f4a451cec6"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("4ecc62a7-98fe-40d8-a064-bd40a3eebac1"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("613f5f6d-8e5c-43c7-be78-6c5981f65ad1"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("8cf43309-6ea6-45fb-8cfd-fa12412ed917"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("91243476-d9c0-40bd-a071-aae33fb24f9d"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("91831de7-6806-4939-9385-5861808b9349"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("a2ebdaee-25ef-448e-8829-76b9ef6c20f2"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("a2f79f19-a026-46fd-9e6c-70fc8e696979"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("b38e8455-1d46-490d-9045-60e47b2ed1cb"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("c19328e6-5083-40aa-addd-0e5403d1ba15"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("c7371ee0-c96a-454b-9770-2488b177c782"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("c82016c8-1527-4516-a1af-e8007e55fe36"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("e41797cc-97bb-467f-b864-632bd495c43f"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("f43b2d58-49f1-4dbd-b869-57296870a266"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("fb1109d2-a13b-423e-bf97-a58ad8bd5c88"));

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "AceitouOsTermos", "Email", "Nome", "SenhaCriptografada", "Telefone" },
                values: new object[] { new Guid("520f600e-ccdf-4a59-898f-d0c4be82d280"), true, "adm@gmail.com", "ADMINISTRADOR", "1h0ATANFe6x7kMHo1PURE74WI0ayevUwfK/+Ie+IWX/xWrFWngcVUwL/ewryn38EMVMQBFaNo4SaVwgXaBWnDw==", "" });

            migrationBuilder.InsertData(
                table: "Vereadores",
                columns: new[] { "Id", "CaminhoImagem", "Nome", "Partido" },
                values: new object[,]
                {
                    { new Guid("0c0a2f2c-9387-487c-b1f3-b3a2369de884"), "https://camarasempapel.camarasjc.sp.gov.br/arquivo/images/pessoas/nka40a6581ghp7uuc263.jpg", "Carlos Abranches", "CIDADANIA" },
                    { new Guid("2581c60f-8e4a-4a51-9499-c8d4ef4588e8"), "https://camarasempapel.camarasjc.sp.gov.br/arquivo/images/pessoas/2nw2d3kmtm8eaus81j38.jpg", "Gilson Campos", "PRD" },
                    { new Guid("3a94564c-1048-4f45-b4f2-0bd58508de26"), "https://camarasempapel.camarasjc.sp.gov.br/arquivo/images/pessoas/261s12lofv4q281is652.jpg", "Fabião Zagueiro", "PSD" },
                    { new Guid("53e28a74-9110-4f7b-a138-979280880846"), "https://camarasempapel.camarasjc.sp.gov.br/arquivo/images/pessoas/y1epxj4jt6526xsc33b7.jpg", "Fernando Petiti", "PSDB" },
                    { new Guid("552c3d8d-9293-4128-839a-ac064ce1c627"), "https://camarasempapel.camarasjc.sp.gov.br/arquivo/images/pessoas/x782015ys02p1u205nyq.jpg", "Milton Vieira Filho", "REPUBLICANOS" },
                    { new Guid("612427d9-0349-4aac-8fee-c6e733172ec9"), "https://camarasempapel.camarasjc.sp.gov.br/arquivo/images/pessoas/76en5j22dic35juc4w40.jpg", "Sidney Campos", "PSDB" },
                    { new Guid("6181f4d3-7a10-4a83-9aca-33d7684e7660"), "https://camarasempapel.camarasjc.sp.gov.br/arquivo/images/pessoas/fngh4n0h1l76y1y213ua.jpg", "Zé Luís", "PSD" },
                    { new Guid("7ae3aafb-66af-4cfa-89d0-d5cf3d6fe0be"), "https://camarasempapel.camarasjc.sp.gov.br/arquivo/images/pessoas/7188t2p5tn44teiyxp21.jpg", "Rogério da Acasem", "PP" },
                    { new Guid("7b853f0f-06ef-4069-b87c-94cdf33ba0d6"), "https://camarasempapel.camarasjc.sp.gov.br/arquivo/images/pessoas/kx44kd5w57y333geu33i.jpg", "Marcelo Garcia", "PRD" },
                    { new Guid("8196c9e3-44bb-451a-9ffe-5210b74cb1ab"), "https://www.camarasjc.sp.gov.br/arquivo/thumb/vereadores/43b65ee2678cc21d127e_336x441_0_0.jpg", "Roberto do Eleven", "PSD" },
                    { new Guid("91cef42c-8fae-4ae6-8eda-5b7857f86325"), "https://camarasempapel.camarasjc.sp.gov.br/arquivo/images/pessoas/5jv7j63k76721878fkha.jpg", "Juliana Fraga", "PT" },
                    { new Guid("9a55c214-d216-4458-9bc0-8fd0fd77b195"), "https://camarasempapel.camarasjc.sp.gov.br/arquivo/images/pessoas/11x3521c2h31ms7o7ptt.jpg", "Roberto Chagas", "PL" },
                    { new Guid("a8f89a6b-3547-4114-9893-f930c6d7d04f"), "https://camarasempapel.camarasjc.sp.gov.br/arquivo/images/pessoas/l706down3d3r37q8mb40.jpg", "Marcão da Academia", "PSD" },
                    { new Guid("abf89b21-2c5d-4e84-91a2-3ff05f295194"), "https://camarasempapel.camarasjc.sp.gov.br/arquivo/images/pessoas/4a7v208k545r10rve48p.jpg", "Thomaz Henrique", "PL" },
                    { new Guid("ada52ad0-9caa-45f4-84e8-efc279ae8013"), "https://camarasempapel.camarasjc.sp.gov.br/arquivo/images/pessoas/5co8mw162kh72optvxv7.jpg", "Rafael Pascucci", "PSD" },
                    { new Guid("b36e72c6-2548-43d3-becc-f45e6e36255e"), "https://camarasempapel.camarasjc.sp.gov.br/arquivo/images/pessoas/2h3fn76bsw3xjchm50m6.jpg", "Cláudio Apolinário", "PSD" },
                    { new Guid("b9cbf0ac-ec12-4a9f-91ab-bde2ccc93448"), "https://camarasempapel.camarasjc.sp.gov.br/arquivo/images/pessoas/1b2tm1j43b44bi2878n1.jpg", "Amélia Naomi", "PT" },
                    { new Guid("d714732e-b37b-488b-ba28-4c4227b13959"), "https://camarasempapel.camarasjc.sp.gov.br/arquivo/images/pessoas/5ky0k0nfx04e7343q0u6.jpg", "Senna", "PL" },
                    { new Guid("dc958b0c-8f71-419a-aa82-f342d3e16a52"), "https://camarasempapel.camarasjc.sp.gov.br/arquivo/images/pessoas/50a1ksm38yqo07a70y23.jpg", "Lino Bispo", "PL" },
                    { new Guid("eaf216c9-a8ac-45a1-8863-0efa0bf71a4b"), "https://camarasempapel.camarasjc.sp.gov.br/arquivo/images/pessoas/w2df70h1ac0m6g28y8f5.jpg", "Renato Santiago", "UNIÃO" },
                    { new Guid("f29f99af-3320-4bc9-91e9-de9afcb485e0"), "https://camarasempapel.camarasjc.sp.gov.br/arquivo/images/pessoas/m003n58e7y20dh5q16e0.jpg", "Sérgio Camargo", "PL" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: new Guid("520f600e-ccdf-4a59-898f-d0c4be82d280"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("0c0a2f2c-9387-487c-b1f3-b3a2369de884"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("2581c60f-8e4a-4a51-9499-c8d4ef4588e8"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("3a94564c-1048-4f45-b4f2-0bd58508de26"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("53e28a74-9110-4f7b-a138-979280880846"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("552c3d8d-9293-4128-839a-ac064ce1c627"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("612427d9-0349-4aac-8fee-c6e733172ec9"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("6181f4d3-7a10-4a83-9aca-33d7684e7660"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("7ae3aafb-66af-4cfa-89d0-d5cf3d6fe0be"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("7b853f0f-06ef-4069-b87c-94cdf33ba0d6"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("8196c9e3-44bb-451a-9ffe-5210b74cb1ab"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("91cef42c-8fae-4ae6-8eda-5b7857f86325"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("9a55c214-d216-4458-9bc0-8fd0fd77b195"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("a8f89a6b-3547-4114-9893-f930c6d7d04f"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("abf89b21-2c5d-4e84-91a2-3ff05f295194"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("ada52ad0-9caa-45f4-84e8-efc279ae8013"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("b36e72c6-2548-43d3-becc-f45e6e36255e"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("b9cbf0ac-ec12-4a9f-91ab-bde2ccc93448"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("d714732e-b37b-488b-ba28-4c4227b13959"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("dc958b0c-8f71-419a-aa82-f342d3e16a52"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("eaf216c9-a8ac-45a1-8863-0efa0bf71a4b"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("f29f99af-3320-4bc9-91e9-de9afcb485e0"));

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "AceitouOsTermos", "Email", "Nome", "SenhaCriptografada", "Telefone" },
                values: new object[] { new Guid("8e54ceb0-04ef-41ac-8cc1-e857827ba790"), true, "adm@gmail.com", "ADMINISTRADOR", "1h0ATANFe6x7kMHo1PURE74WI0ayevUwfK/+Ie+IWX/xWrFWngcVUwL/ewryn38EMVMQBFaNo4SaVwgXaBWnDw==", "" });

            migrationBuilder.InsertData(
                table: "Vereadores",
                columns: new[] { "Id", "CaminhoImagem", "Nome", "Partido" },
                values: new object[,]
                {
                    { new Guid("0d5c5cea-aea7-44ab-93e7-3b93b284839a"), "zeluis.jpg", "Zé Luís", "PSD" },
                    { new Guid("1e918a99-36d5-4d37-b862-eddb4909575b"), "julianafraga.jpg", "Juliana Fraga", "PT" },
                    { new Guid("2792b548-f56a-4df8-a10d-c74136104b29"), "senna.jpg", "Senna", "PL" },
                    { new Guid("2a763dee-a189-410f-91d3-08274608cc2c"), "fernandopetiti.jpg", "Fernando Petiti", "PSDB" },
                    { new Guid("46b7b815-4dc4-4b04-9943-4e15cb69a3a3"), "claudioapolinario.jpg", "Cláudio Apolinário", "PSD" },
                    { new Guid("47f336a2-05d6-43e0-9d54-9ca34d79fcdf"), "thomazhenrique.jpg", "Thomaz Henrique", "PL" },
                    { new Guid("4a09d1c3-90e4-4afa-a8b8-18f4a451cec6"), "rafaelpascucci.jpg", "Rafael Pascucci", "PSD" },
                    { new Guid("4ecc62a7-98fe-40d8-a064-bd40a3eebac1"), "miltonvieirafilho.jpg", "Milton Vieira Filho", "REPUBLICANOS" },
                    { new Guid("613f5f6d-8e5c-43c7-be78-6c5981f65ad1"), "sergiocamargo.jpg", "Sérgio Camargo", "PL" },
                    { new Guid("8cf43309-6ea6-45fb-8cfd-fa12412ed917"), "robertodoeleven.jpg", "Roberto do Eleven", "PSD" },
                    { new Guid("91243476-d9c0-40bd-a071-aae33fb24f9d"), "rogeriodaacasem.jpg", "Rogério da Acasem", "PP" },
                    { new Guid("91831de7-6806-4939-9385-5861808b9349"), "marcelogarcia.jpg", "Marcelo Garcia", "PRD" },
                    { new Guid("a2ebdaee-25ef-448e-8829-76b9ef6c20f2"), "marcaodaacademia.jpg", "Marcão da Academia", "PSD" },
                    { new Guid("a2f79f19-a026-46fd-9e6c-70fc8e696979"), "sidneycampos.jpg", "Sidney Campos", "PSDB" },
                    { new Guid("b38e8455-1d46-490d-9045-60e47b2ed1cb"), "renatosantiago.jpg", "Renato Santiago", "UNIÃO" },
                    { new Guid("c19328e6-5083-40aa-addd-0e5403d1ba15"), "robertochagas.jpg", "Roberto Chagas", "PL" },
                    { new Guid("c7371ee0-c96a-454b-9770-2488b177c782"), "carlosabranches.jpg", "Carlos Abranches", "CIDADANIA" },
                    { new Guid("c82016c8-1527-4516-a1af-e8007e55fe36"), "amelianaomi.jpg", "Amélia Naomi", "PT" },
                    { new Guid("e41797cc-97bb-467f-b864-632bd495c43f"), "linobispo.jpg", "Lino Bispo", "PL" },
                    { new Guid("f43b2d58-49f1-4dbd-b869-57296870a266"), "fabiaozagueiro.jpg", "Fabião Zagueiro", "PSD" },
                    { new Guid("fb1109d2-a13b-423e-bf97-a58ad8bd5c88"), "gilsoncampos.jpg", "Gilson Campos", "PRD" }
                });
        }
    }
}
