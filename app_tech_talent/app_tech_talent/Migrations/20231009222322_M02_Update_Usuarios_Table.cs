using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace app_tech_talent.Migrations
{
    public partial class M02_Update_Usuarios_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Usuarios",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "TipoPerfil",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "TipoPerfil",
                table: "Usuarios");
        }
    }
}
