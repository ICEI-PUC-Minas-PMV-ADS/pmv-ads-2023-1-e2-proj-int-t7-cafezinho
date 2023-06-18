using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cafezinho.Migrations
{
    /// <inheritdoc />
    public partial class CreateDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    cpf = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dt_nascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cep = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    logradouro = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    numero = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bairro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    cidade = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    estado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    perfil = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.cpf);
                });

            migrationBuilder.CreateTable(
                name: "Dashboard",
                columns: table => new
                {
                    DashboardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalEmCarteira = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dashboard", x => x.DashboardId);
                });

            migrationBuilder.CreateTable(
                name: "Ativos",
                columns: table => new
                {
                    ticker = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DashboardId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ativos", x => x.ticker);
                    table.ForeignKey(
                        name: "FK_Ativos_Dashboard_DashboardId",
                        column: x => x.DashboardId,
                        principalTable: "Dashboard",
                        principalColumn: "DashboardId");
                });

            migrationBuilder.CreateTable(
                name: "Registros",
                columns: table => new
                {
                    registro_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    quantidade = table.Column<int>(type: "int", nullable: false),
                    data_transacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    valor_total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ticker = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    cliente_id = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DashboardId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registros", x => x.registro_id);
                    table.ForeignKey(
                        name: "FK_Registros_Ativos_ticker",
                        column: x => x.ticker,
                        principalTable: "Ativos",
                        principalColumn: "ticker");
                    table.ForeignKey(
                        name: "FK_Registros_Dashboard_DashboardId",
                        column: x => x.DashboardId,
                        principalTable: "Dashboard",
                        principalColumn: "DashboardId");
                    table.ForeignKey(
                        name: "FK_Registros_clientes_cliente_id",
                        column: x => x.cliente_id,
                        principalTable: "clientes",
                        principalColumn: "cpf");
                });

            migrationBuilder.CreateTable(
                name: "Vendas",
                columns: table => new
                {
                    venda_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    quantidade = table.Column<int>(type: "int", nullable: false),
                    data_transacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    valor_total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    registro_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendas", x => x.venda_id);
                    table.ForeignKey(
                        name: "FK_Vendas_Registros_registro_id",
                        column: x => x.registro_id,
                        principalTable: "Registros",
                        principalColumn: "registro_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "clientes",
                columns: new[] { "cpf", "bairro", "cep", "cidade", "Complemento", "dt_nascimento", "email", "estado", "logradouro", "nome", "numero", "perfil", "senha" },
                values: new object[] { "001", "", "", "", "", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", "", "Admin", "", 1, "$2a$10$6z4B.MIAncvz0rsrTRnuDORmDZUXXa1hXAXs9Pfa7Twwjylz2qujS" });

            migrationBuilder.CreateIndex(
                name: "IX_Ativos_DashboardId",
                table: "Ativos",
                column: "DashboardId");

            migrationBuilder.CreateIndex(
                name: "IX_Registros_cliente_id",
                table: "Registros",
                column: "cliente_id");

            migrationBuilder.CreateIndex(
                name: "IX_Registros_DashboardId",
                table: "Registros",
                column: "DashboardId");

            migrationBuilder.CreateIndex(
                name: "IX_Registros_ticker",
                table: "Registros",
                column: "ticker");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_registro_id",
                table: "Vendas",
                column: "registro_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vendas");

            migrationBuilder.DropTable(
                name: "Registros");

            migrationBuilder.DropTable(
                name: "Ativos");

            migrationBuilder.DropTable(
                name: "clientes");

            migrationBuilder.DropTable(
                name: "Dashboard");
        }
    }
}
