using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cafezinho.Migrations
{
    /// <inheritdoc />
    public partial class SeedAdministrator : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "clientes",
                columns: new[] { "cpf", "bairro", "cep", "cidade", "Complemento", "dt_nascimento", "email", "estado", "logradouro", "nome", "numero", "perfil", "senha" },
                values: new object[] { "001", "", "", "", "", new DateTime(2023, 5, 15, 0, 37, 6, 690, DateTimeKind.Local).AddTicks(5175), "", "", "", "Admin", "", 1, "$2a$10$6z4B.MIAncvz0rsrTRnuDORmDZUXXa1hXAXs9Pfa7Twwjylz2qujS" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "clientes",
                keyColumn: "cpf",
                keyValue: "001");
        }
    }
}
