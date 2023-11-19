using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace app_tech_talent.Migrations
{
    public partial class M12_Update_Table_Habilidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdHabilidades",
                table: "Habilidades",
                type: "serial",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "Habilidades",
                type: "varchar",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Habilidades",
                table: "Habilidades",
                column: "IdHabilidades");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Habilidades",
                table: "Habilidades");

            migrationBuilder.DropColumn(
                name: "IdHabilidades",
                table: "Habilidades");

            migrationBuilder.DropColumn(
                name: "CPF",
                table: "Habilidades");
        }
    }
}
