using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StartmanSA.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "logs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Encarregado = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    MateriaPrima = table.Column<string>(unicode: false, maxLength: 300, nullable: false),
                    QuantidadeAlterada = table.Column<long>(nullable: false),
                    DiaAlteracao = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_logs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "materiaprima",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(unicode: false, maxLength: 300, nullable: false),
                    QuantidadeEstoque = table.Column<long>(nullable: false),
                    QuantidadeEstoqueMax = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_materiaprima", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "logs");

            migrationBuilder.DropTable(
                name: "materiaprima");
        }
    }
}
