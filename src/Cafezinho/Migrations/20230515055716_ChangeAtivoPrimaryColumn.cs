using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cafezinho.Migrations
{
    /// <inheritdoc />
    public partial class ChangeAtivoPrimaryColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registros_Ativos_ativo_id",
                table: "Registros");

            migrationBuilder.DropIndex(
                name: "IX_Registros_ativo_id",
                table: "Registros");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ativos",
                table: "Ativos");

            migrationBuilder.DropColumn(
                name: "ativo_id",
                table: "Registros");

            migrationBuilder.DropColumn(
                name: "ativo_id",
                table: "Ativos");

            migrationBuilder.AddColumn<string>(
                name: "ticker",
                table: "Registros",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ticker",
                table: "Ativos",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ativos",
                table: "Ativos",
                column: "ticker");

            migrationBuilder.InsertData(
                table: "Ativos",
                columns: new[] { "ticker", "nome" },
                values: new object[] { "AAAA", "aaaa" });

            migrationBuilder.UpdateData(
                table: "clientes",
                keyColumn: "cpf",
                keyValue: "001",
                column: "dt_nascimento",
                value: new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Registros_ticker",
                table: "Registros",
                column: "ticker");

            migrationBuilder.AddForeignKey(
                name: "FK_Registros_Ativos_ticker",
                table: "Registros",
                column: "ticker",
                principalTable: "Ativos",
                principalColumn: "ticker");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registros_Ativos_ticker",
                table: "Registros");

            migrationBuilder.DropIndex(
                name: "IX_Registros_ticker",
                table: "Registros");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ativos",
                table: "Ativos");

            migrationBuilder.DeleteData(
                table: "Ativos",
                keyColumn: "ticker",
                keyValue: "AAAA");

            migrationBuilder.DropColumn(
                name: "ticker",
                table: "Registros");

            migrationBuilder.AddColumn<int>(
                name: "ativo_id",
                table: "Registros",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "ticker",
                table: "Ativos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "ativo_id",
                table: "Ativos",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ativos",
                table: "Ativos",
                column: "ativo_id");

            migrationBuilder.UpdateData(
                table: "clientes",
                keyColumn: "cpf",
                keyValue: "001",
                column: "dt_nascimento",
                value: new DateTime(2023, 5, 15, 0, 37, 6, 690, DateTimeKind.Local).AddTicks(5175));

            migrationBuilder.CreateIndex(
                name: "IX_Registros_ativo_id",
                table: "Registros",
                column: "ativo_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Registros_Ativos_ativo_id",
                table: "Registros",
                column: "ativo_id",
                principalTable: "Ativos",
                principalColumn: "ativo_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
