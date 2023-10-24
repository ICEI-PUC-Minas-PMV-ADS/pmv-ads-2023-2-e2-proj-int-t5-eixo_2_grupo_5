using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace app_tech_talent.Migrations
{
    public partial class M11_Add_Table_Habilidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Habilidades",
                columns: table => new
                {
                    Ingles = table.Column<bool>(type: "bit", nullable: false),
                    Programacao = table.Column<bool>(type: "bit", nullable: false),
                    BancoDeDados = table.Column<bool>(type: "bit", nullable: false),
                    AnaliseDeDados = table.Column<bool>(type: "bit", nullable: false),
                    MachineLearningEInteligenciaArtificial = table.Column<bool>(type: "bit", nullable: false),
                    DesignDeInterfacesDeUsuario = table.Column<bool>(type: "bit", nullable: false),
                    DesignDeExperienciaDeUsuario = table.Column<bool>(type: "bit", nullable: false),
                    DevOps = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Habilidades");
        }
    }
}
