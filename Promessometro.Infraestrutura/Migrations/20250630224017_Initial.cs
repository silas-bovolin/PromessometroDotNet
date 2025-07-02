using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Promessometro.Infraestrutura.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Promessas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Titulo = table.Column<string>(type: "text", nullable: false),
                    Descricao = table.Column<string>(type: "text", nullable: false),
                    ConclusaoPorcentagem = table.Column<int>(type: "integer", nullable: false),
                    Detalhes = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promessas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Requerimentos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Codigo = table.Column<string>(type: "text", nullable: false),
                    Descricao = table.Column<string>(type: "text", nullable: false),
                    Aprovado = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requerimentos", x => x.Id);
                    table.UniqueConstraint("AK_Requerimentos_Codigo", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    SenhaCriptografada = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vereadores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Partido = table.Column<string>(type: "text", nullable: false),
                    CaminhoImagem = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vereadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fases",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Titulo = table.Column<string>(type: "text", nullable: false),
                    Descricao = table.Column<string>(type: "text", nullable: false),
                    ConclusaoPorcentagem = table.Column<int>(type: "integer", nullable: false),
                    PromessaId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fases_Promessas_PromessaId",
                        column: x => x.PromessaId,
                        principalTable: "Promessas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Votos",
                columns: table => new
                {
                    RequerimentoId = table.Column<Guid>(type: "uuid", nullable: false),
                    VereadorId = table.Column<Guid>(type: "uuid", nullable: false),
                    Aprovacao = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Votos", x => new { x.VereadorId, x.RequerimentoId });
                    table.ForeignKey(
                        name: "FK_Votos_Requerimentos_RequerimentoId",
                        column: x => x.RequerimentoId,
                        principalTable: "Requerimentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Votos_Vereadores_VereadorId",
                        column: x => x.VereadorId,
                        principalTable: "Vereadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
            
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

            migrationBuilder.CreateIndex(
                name: "IX_Fases_PromessaId",
                table: "Fases",
                column: "PromessaId");

            migrationBuilder.CreateIndex(
                name: "IX_Votos_RequerimentoId",
                table: "Votos",
                column: "RequerimentoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fases");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Votos");

            migrationBuilder.DropTable(
                name: "Promessas");

            migrationBuilder.DropTable(
                name: "Requerimentos");

            migrationBuilder.DropTable(
                name: "Vereadores");
        }
    }
}
