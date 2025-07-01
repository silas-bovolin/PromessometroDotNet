using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Promessometro.Infraestrutura.Migrations
{
    /// <inheritdoc />
    public partial class RemoverDescricaoRequerimento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: new Guid("b024e690-d423-4c3a-b512-00e648419154"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("0310cc93-cbc6-4939-8938-ebca31ef7adf"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("03e9d60f-8ac2-4f02-9a63-3b88ad321498"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("12f6fc30-ba32-4d2b-94fe-30182711d346"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("19038e54-027a-42cf-8ada-7b75dac200e4"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("20ac281e-8410-42cd-8758-3d46f658f4d0"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("2a65ce12-a183-4814-9994-934e93a8c5b7"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("3f0acc8f-1737-4e24-b998-1abb1948cbee"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("40c7ee39-b72b-4fdf-9616-27aaf823893b"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("50154f04-f133-47cb-91c9-a825a2a2009a"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("59292331-80b7-4d63-9205-6b02a02a01e1"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("77ea3add-9771-4bd6-827d-93165bc536a1"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("8073f8dd-a627-4cc7-81da-1995b47dec01"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("81a6166b-833d-4129-b174-0b6c7b8621f2"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("81dab524-b6f6-422d-8c8e-898122153e61"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("82f2e4bb-16c7-4120-990d-89de1334b43b"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("a0737c88-80af-4322-b80f-f333f034d4d8"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("bac8fd32-9580-4d84-95e8-299c413d7646"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("c4cebc7f-7f03-4192-bb16-c9701ed81a69"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("da08182f-d354-4731-b45c-6a27a206842d"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("dc4b87e4-ab77-4a21-9ae9-654f8784e882"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("eae6ed0d-6f55-42af-964a-2813c768c1cd"));

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Requerimentos");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Requerimentos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "AceitouOsTermos", "Email", "Nome", "SenhaCriptografada", "Telefone" },
                values: new object[] { new Guid("b024e690-d423-4c3a-b512-00e648419154"), true, "adm@gmail.com", "ADMINISTRADOR", "1h0ATANFe6x7kMHo1PURE74WI0ayevUwfK/+Ie+IWX/xWrFWngcVUwL/ewryn38EMVMQBFaNo4SaVwgXaBWnDw==", "" });

            migrationBuilder.InsertData(
                table: "Vereadores",
                columns: new[] { "Id", "CaminhoImagem", "Nome", "Partido" },
                values: new object[,]
                {
                    { new Guid("0310cc93-cbc6-4939-8938-ebca31ef7adf"), "zeluis.jpg", "Zé Luís", "PSD" },
                    { new Guid("03e9d60f-8ac2-4f02-9a63-3b88ad321498"), "robertochagas.jpg", "Roberto Chagas", "PL" },
                    { new Guid("12f6fc30-ba32-4d2b-94fe-30182711d346"), "rafaelpascucci.jpg", "Rafael Pascucci", "PSD" },
                    { new Guid("19038e54-027a-42cf-8ada-7b75dac200e4"), "marcelogarcia.jpg", "Marcelo Garcia", "PRD" },
                    { new Guid("20ac281e-8410-42cd-8758-3d46f658f4d0"), "thomazhenrique.jpg", "Thomaz Henrique", "PL" },
                    { new Guid("2a65ce12-a183-4814-9994-934e93a8c5b7"), "robertodoeleven.jpg", "Roberto do Eleven", "PSD" },
                    { new Guid("3f0acc8f-1737-4e24-b998-1abb1948cbee"), "julianafraga.jpg", "Juliana Fraga", "PT" },
                    { new Guid("40c7ee39-b72b-4fdf-9616-27aaf823893b"), "linobispo.jpg", "Lino Bispo", "PL" },
                    { new Guid("50154f04-f133-47cb-91c9-a825a2a2009a"), "rogeriodaacasem.jpg", "Rogério da Acasem", "PP" },
                    { new Guid("59292331-80b7-4d63-9205-6b02a02a01e1"), "fabiaozagueiro.jpg", "Fabião Zagueiro", "PSD" },
                    { new Guid("77ea3add-9771-4bd6-827d-93165bc536a1"), "miltonvieirafilho.jpg", "Milton Vieira Filho", "REPUBLICANOS" },
                    { new Guid("8073f8dd-a627-4cc7-81da-1995b47dec01"), "senna.jpg", "Senna", "PL" },
                    { new Guid("81a6166b-833d-4129-b174-0b6c7b8621f2"), "sergiocamargo.jpg", "Sérgio Camargo", "PL" },
                    { new Guid("81dab524-b6f6-422d-8c8e-898122153e61"), "sidneycampos.jpg", "Sidney Campos", "PSDB" },
                    { new Guid("82f2e4bb-16c7-4120-990d-89de1334b43b"), "fernandopetiti.jpg", "Fernando Petiti", "PSDB" },
                    { new Guid("a0737c88-80af-4322-b80f-f333f034d4d8"), "claudioapolinario.jpg", "Cláudio Apolinário", "PSD" },
                    { new Guid("bac8fd32-9580-4d84-95e8-299c413d7646"), "marcaodaacademia.jpg", "Marcão da Academia", "PSD" },
                    { new Guid("c4cebc7f-7f03-4192-bb16-c9701ed81a69"), "gilsoncampos.jpg", "Gilson Campos", "PRD" },
                    { new Guid("da08182f-d354-4731-b45c-6a27a206842d"), "renatosantiago.jpg", "Renato Santiago", "UNIÃO" },
                    { new Guid("dc4b87e4-ab77-4a21-9ae9-654f8784e882"), "carlosabranches.jpg", "Carlos Abranches", "CIDADANIA" },
                    { new Guid("eae6ed0d-6f55-42af-964a-2813c768c1cd"), "amelianaomi.jpg", "Amélia Naomi", "PT" }
                });
        }
    }
}
