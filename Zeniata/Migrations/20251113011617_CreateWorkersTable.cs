using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zeniata.Migrations
{
    /// <inheritdoc />
    public partial class CreateWorkersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Workers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Cidade = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    DistanciaMatriz = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    EstiloTrabalho = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Cargo = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    Setor = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    StatusSaude = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    DataAdmissao = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Observacoes = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Workers");
        }
    }
}
