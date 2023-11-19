﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace app_tech_talent.Migrations
{
    public partial class M17AddTableVagas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vagas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "varchar", nullable: false),
                    Descricao = table.Column<string>(type: "varchar", nullable: false),
                    Localizacao = table.Column<string>(type: "varchar", nullable: false),
                    formacao = table.Column<string>(type: "varchar", nullable: true),
                    ExperienciaProficional = table.Column<string>(type: "varchar", nullable: true),
                    Habilidades = table.Column<string>(type: "varchar", nullable: true),
                    salario = table.Column<double>(type: "float", nullable: false),
                    status = table.Column<bool>(type: "bit", nullable: false),
                    dateAbertura = table.Column<DateTime>(type: "timestamp", nullable: false),
                    dataFechamento = table.Column<DateTime>(type: "timestamp", nullable: false),
                    EmpresaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vagas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vagas");
        }
    }
}
