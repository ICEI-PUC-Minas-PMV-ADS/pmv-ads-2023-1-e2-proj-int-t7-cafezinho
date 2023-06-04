using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cafezinho.Migrations
{
    /// <inheritdoc />
    public partial class Dashboards : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ativos",
                keyColumn: "ticker",
                keyValue: "AAAA");

            migrationBuilder.AddColumn<int>(
                name: "DashboardId",
                table: "Registros",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DashboardId",
                table: "Ativos",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Registros_DashboardId",
                table: "Registros",
                column: "DashboardId");

            migrationBuilder.CreateIndex(
                name: "IX_Ativos_DashboardId",
                table: "Ativos",
                column: "DashboardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ativos_Dashboard_DashboardId",
                table: "Ativos",
                column: "DashboardId",
                principalTable: "Dashboard",
                principalColumn: "DashboardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Registros_Dashboard_DashboardId",
                table: "Registros",
                column: "DashboardId",
                principalTable: "Dashboard",
                principalColumn: "DashboardId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ativos_Dashboard_DashboardId",
                table: "Ativos");

            migrationBuilder.DropForeignKey(
                name: "FK_Registros_Dashboard_DashboardId",
                table: "Registros");

            migrationBuilder.DropTable(
                name: "Dashboard");

            migrationBuilder.DropIndex(
                name: "IX_Registros_DashboardId",
                table: "Registros");

            migrationBuilder.DropIndex(
                name: "IX_Ativos_DashboardId",
                table: "Ativos");

            migrationBuilder.DropColumn(
                name: "DashboardId",
                table: "Registros");

            migrationBuilder.DropColumn(
                name: "DashboardId",
                table: "Ativos");

            migrationBuilder.InsertData(
                table: "Ativos",
                columns: new[] { "ticker", "nome" },
                values: new object[] { "AAAA", "aaaa" });
        }
    }
}
