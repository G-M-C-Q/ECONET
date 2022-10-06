using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructuree.Migrations
{
    public partial class CreateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ItemBrandId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ItemCategoryID",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ItemBrands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemBrands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCategories", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_ItemBrandId",
                table: "Items",
                column: "ItemBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ItemCategoryID",
                table: "Items",
                column: "ItemCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemBrands_ItemBrandId",
                table: "Items",
                column: "ItemBrandId",
                principalTable: "ItemBrands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemCategories_ItemCategoryID",
                table: "Items",
                column: "ItemCategoryID",
                principalTable: "ItemCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemBrands_ItemBrandId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemCategories_ItemCategoryID",
                table: "Items");

            migrationBuilder.DropTable(
                name: "ItemBrands");

            migrationBuilder.DropTable(
                name: "ItemCategories");

            migrationBuilder.DropIndex(
                name: "IX_Items_ItemBrandId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_ItemCategoryID",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ItemBrandId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ItemCategoryID",
                table: "Items");
        }
    }
}
