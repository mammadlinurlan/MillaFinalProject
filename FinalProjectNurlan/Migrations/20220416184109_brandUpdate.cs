using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectNurlan.Migrations
{
    public partial class brandUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Totalsold",
                table: "Brands",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Totalsold",
                table: "Brands");
        }
    }
}
