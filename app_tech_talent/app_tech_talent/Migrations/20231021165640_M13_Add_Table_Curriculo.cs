using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace app_tech_talent.Migrations
{
    public partial class M13_Add_Table_Curriculo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Curriculos",
                columns: table => new
                {
                    IdCurriculo = table.Column<int>(type: "serial", nullable: false),
                    CPF = table.Column<string>(type: "varchar", nullable: true),
                    ResumoProfissional = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curriculos", x => x.IdCurriculo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Curriculos");
        }
    }
}
