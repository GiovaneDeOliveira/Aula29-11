using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp1.Data.Migrations
{
    public partial class IncluindoPessoas2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "Pessoa",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "Pessoa");
        }
    }
}
