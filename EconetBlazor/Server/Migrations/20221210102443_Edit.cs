using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EconetBlazor.Server.Migrations
{
    public partial class Edit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "State",
                table: "Addresses",
                newName: "County");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "County",
                table: "Addresses",
                newName: "State");
        }
    }
}
