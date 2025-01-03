﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kognito.Usuarios.App.Migrations
{
    /// <inheritdoc />
    public partial class cpfunico : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Cpf",
                table: "Usuarios",
                column: "Cpf",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Usuarios_Cpf",
                table: "Usuarios");
        }
    }
}
