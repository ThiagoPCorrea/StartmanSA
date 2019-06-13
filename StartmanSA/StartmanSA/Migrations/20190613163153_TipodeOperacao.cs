using Microsoft.EntityFrameworkCore.Migrations;

namespace StartmanSA.Migrations
{
    public partial class TipodeOperacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TipodeOperacao",
                table: "logs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipodeOperacao",
                table: "logs");
        }
    }
}
