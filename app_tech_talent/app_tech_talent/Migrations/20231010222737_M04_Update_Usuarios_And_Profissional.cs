using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace app_tech_talent.Migrations
{
    public partial class M04_Update_Usuarios_And_Profissional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoPerfil",
                table: "Usuarios");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoPerfil",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
