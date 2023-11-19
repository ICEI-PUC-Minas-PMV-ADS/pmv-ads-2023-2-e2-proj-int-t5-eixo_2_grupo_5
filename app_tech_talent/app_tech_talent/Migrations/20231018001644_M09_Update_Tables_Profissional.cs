using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace app_tech_talent.Migrations
{
    public partial class M09_Update_Tables_Profissional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "Profissionais",
                type: "varchar",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Idade",
                table: "Profissionais",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CPF",
                table: "Profissionais");

            migrationBuilder.DropColumn(
                name: "Idade",
                table: "Profissionais");
        }
    }
}
