using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace app_tech_talent.Migrations
{
    public partial class M10_Update_Tables_Create_Empresas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    EmpresaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RazaoSocial = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    CNPJ = table.Column<string>(type: "varchar(max)", nullable: false),
                    Logradouro = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UF = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: true),
                    CEP = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: true),
                    Bairro = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Cidade = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    WebSite = table.Column<string>(type: "varchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.EmpresaId);
                    table.ForeignKey(
                        name: "FK_Empresas_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empresas_UsuarioId",
                table: "Empresas",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empresas");
        }
    }
}
