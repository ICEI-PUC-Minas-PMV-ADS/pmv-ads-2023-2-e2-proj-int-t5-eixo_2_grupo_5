﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace app_tech_talent.Migrations
{
    public partial class M15_Add_Table_FormacaoAcademica : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FormacaoAcademica",
                columns: table => new
                {
                    IdFormacaoAcademica = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCurriculo = table.Column<int>(type: "int", nullable: false),
                    InstituicaoDeEnsino = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    grauObtido = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AnoDeConclusao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AreaDeEstudo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormacaoAcademica", x => x.IdFormacaoAcademica);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormacaoAcademica");
        }
    }
}
