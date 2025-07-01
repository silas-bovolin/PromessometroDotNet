using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Promessometro.Infraestrutura.Migrations
{
    /// <inheritdoc />
    public partial class AtualizacaoUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: new Guid("32c95da9-f7dc-4a22-94cc-126d43f635ed"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("06872ddd-5f1e-46ff-a461-48f81386d91c"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("202b4562-23c8-4e00-9641-57acacdaf8d6"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("28fd1d7d-240d-4c69-a6c0-78ab6d83243a"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("2c62f66e-580f-4335-9aa6-baa668cfb4fc"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("2c64b30d-d589-4cc0-bfe8-26cefc6ce658"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("36350b02-02e0-408c-8a01-90944da66d77"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("44fdf391-0b3f-4bf5-ac0b-baa05f7e8dd8"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("726fe199-38bc-4d09-8a83-ac02e94b6ba4"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("7554dbea-a134-407d-a2dc-45edb7b2fe41"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("901c0e0c-10d9-41ea-9061-b087fa799fba"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("ad52d164-7bc7-4f63-9d0d-3967927a1cca"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("b3982944-ea36-4b37-9476-6ef2a5f2b326"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("b9c40986-c66f-47fa-a3d5-67746fcbc9db"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("bd77e8be-5150-4a03-b71a-7741165dde5f"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("c37256e2-fba5-4487-8ad8-167469da49e4"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("c414354c-d8a9-48ec-b50c-f1103620aa14"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("cb615dae-0e63-4dfb-89da-dffd4760e48d"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("cf93cb5b-c549-419c-80eb-282303bc6770"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("df5b8b4c-15b3-4f7a-b335-e0e0b257ad69"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("e864d5db-c515-4235-9c6e-bac04906f1eb"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("ee11f2a6-716f-4105-8f4f-1b7e32301eaa"));

            migrationBuilder.AddColumn<bool>(
                name: "AceitouOsTermos",
                table: "Usuarios",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Usuarios",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "AceitouOsTermos",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Usuarios");

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Email", "Nome", "SenhaCriptografada" },
                values: new object[] { new Guid("32c95da9-f7dc-4a22-94cc-126d43f635ed"), "adm@gmail.com", "ADMINISTRADOR", "1h0ATANFe6x7kMHo1PURE74WI0ayevUwfK/+Ie+IWX/xWrFWngcVUwL/ewryn38EMVMQBFaNo4SaVwgXaBWnDw==" });

            migrationBuilder.InsertData(
                table: "Vereadores",
                columns: new[] { "Id", "CaminhoImagem", "Nome", "Partido" },
                values: new object[,]
                {
                    { new Guid("06872ddd-5f1e-46ff-a461-48f81386d91c"), "linobispo.jpg", "Lino Bispo", "PL" },
                    { new Guid("202b4562-23c8-4e00-9641-57acacdaf8d6"), "senna.jpg", "Senna", "PL" },
                    { new Guid("28fd1d7d-240d-4c69-a6c0-78ab6d83243a"), "robertochagas.jpg", "Roberto Chagas", "PL" },
                    { new Guid("2c62f66e-580f-4335-9aa6-baa668cfb4fc"), "sidneycampos.jpg", "Sidney Campos", "PSDB" },
                    { new Guid("2c64b30d-d589-4cc0-bfe8-26cefc6ce658"), "amelianaomi.jpg", "Amélia Naomi", "PT" },
                    { new Guid("36350b02-02e0-408c-8a01-90944da66d77"), "carlosabranches.jpg", "Carlos Abranches", "CIDADANIA" },
                    { new Guid("44fdf391-0b3f-4bf5-ac0b-baa05f7e8dd8"), "zeluis.jpg", "Zé Luís", "PSD" },
                    { new Guid("726fe199-38bc-4d09-8a83-ac02e94b6ba4"), "rogeriodaacasem.jpg", "Rogério da Acasem", "PP" },
                    { new Guid("7554dbea-a134-407d-a2dc-45edb7b2fe41"), "marcaodaacademia.jpg", "Marcão da Academia", "PSD" },
                    { new Guid("901c0e0c-10d9-41ea-9061-b087fa799fba"), "gilsoncampos.jpg", "Gilson Campos", "PRD" },
                    { new Guid("ad52d164-7bc7-4f63-9d0d-3967927a1cca"), "claudioapolinario.jpg", "Cláudio Apolinário", "PSD" },
                    { new Guid("b3982944-ea36-4b37-9476-6ef2a5f2b326"), "fernandopetiti.jpg", "Fernando Petiti", "PSDB" },
                    { new Guid("b9c40986-c66f-47fa-a3d5-67746fcbc9db"), "julianafraga.jpg", "Juliana Fraga", "PT" },
                    { new Guid("bd77e8be-5150-4a03-b71a-7741165dde5f"), "sergiocamargo.jpg", "Sérgio Camargo", "PL" },
                    { new Guid("c37256e2-fba5-4487-8ad8-167469da49e4"), "thomazhenrique.jpg", "Thomaz Henrique", "PL" },
                    { new Guid("c414354c-d8a9-48ec-b50c-f1103620aa14"), "rafaelpascucci.jpg", "Rafael Pascucci", "PSD" },
                    { new Guid("cb615dae-0e63-4dfb-89da-dffd4760e48d"), "robertodoeleven.jpg", "Roberto do Eleven", "PSD" },
                    { new Guid("cf93cb5b-c549-419c-80eb-282303bc6770"), "renatosantiago.jpg", "Renato Santiago", "UNIÃO" },
                    { new Guid("df5b8b4c-15b3-4f7a-b335-e0e0b257ad69"), "miltonvieirafilho.jpg", "Milton Vieira Filho", "REPUBLICANOS" },
                    { new Guid("e864d5db-c515-4235-9c6e-bac04906f1eb"), "fabiaozagueiro.jpg", "Fabião Zagueiro", "PSD" },
                    { new Guid("ee11f2a6-716f-4105-8f4f-1b7e32301eaa"), "marcelogarcia.jpg", "Marcelo Garcia", "PRD" }
                });
        }
    }
}
