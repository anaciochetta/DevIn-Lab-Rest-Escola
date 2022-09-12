using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Escola.Infra.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SOBRENOME",
                table: "ALUNO",
                type: "VARCHAR(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "NOME",
                table: "ALUNO",
                type: "VARCHAR(80)",
                maxLength: 80,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(80)",
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<string>(
                name: "EMAIL",
                table: "ALUNO",
                type: "VARCHAR(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(200)",
                oldMaxLength: 200);

            migrationBuilder.CreateTable(
                name: "Boletim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlunoId = table.Column<int>(type: "int", nullable: false),
                    AlunoId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    order_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boletim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Boletim_ALUNO_AlunoId1",
                        column: x => x.AlunoId1,
                        principalTable: "ALUNO",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "MATERIAS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOME = table.Column<string>(type: "VARCHAR", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MateriaID", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NotasMateria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MateriaId = table.Column<int>(type: "int", nullable: false),
                    BoletimId = table.Column<int>(type: "int", nullable: false),
                    Nota = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotasMateria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotasMateria_Boletim_BoletimId",
                        column: x => x.BoletimId,
                        principalTable: "Boletim",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NotasMateria_MATERIAS_MateriaId",
                        column: x => x.MateriaId,
                        principalTable: "MATERIAS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ALUNO_Matricula",
                table: "ALUNO",
                column: "Matricula",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Boletim_AlunoId1",
                table: "Boletim",
                column: "AlunoId1");

            migrationBuilder.CreateIndex(
                name: "IX_NotasMateria_BoletimId",
                table: "NotasMateria",
                column: "BoletimId");

            migrationBuilder.CreateIndex(
                name: "IX_NotasMateria_MateriaId",
                table: "NotasMateria",
                column: "MateriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotasMateria");

            migrationBuilder.DropTable(
                name: "Boletim");

            migrationBuilder.DropTable(
                name: "MATERIAS");

            migrationBuilder.DropIndex(
                name: "IX_ALUNO_Matricula",
                table: "ALUNO");

            migrationBuilder.AlterColumn<string>(
                name: "SOBRENOME",
                table: "ALUNO",
                type: "VARCHAR(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOME",
                table: "ALUNO",
                type: "VARCHAR(80)",
                maxLength: 80,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(80)",
                oldMaxLength: 80,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EMAIL",
                table: "ALUNO",
                type: "VARCHAR(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(200)",
                oldMaxLength: 200,
                oldNullable: true);
        }
    }
}
