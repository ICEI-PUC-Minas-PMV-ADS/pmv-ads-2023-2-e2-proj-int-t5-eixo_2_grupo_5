using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace app_tech_talent.Migrations
{
    public partial class M14_Update_Table_Curriculo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Curriculos",
                table: "Curriculos");

            migrationBuilder.RenameTable(
                name: "Curriculos",
                newName: "Curriculo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Curriculo",
                table: "Curriculo",
                column: "IdCurriculo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Curriculo",
                table: "Curriculo");

            migrationBuilder.RenameTable(
                name: "Curriculo",
                newName: "Curriculos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Curriculos",
                table: "Curriculos",
                column: "IdCurriculo");
        }
    }
}
