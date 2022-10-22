using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EconetBlazor.Server.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "blue and white striped relaxed fit trousers - super summery and slouched - size 10, could fit a small 12", "https://th.bing.com/th/id/OIP.qimv_2tIcl5A_u_k4iURGAHaLH?pid=ImgDet&rs=1", 9.99m, "Trousers" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "If you want to look like a banana buy this jumper", "https://xcdn.next.co.uk/Common/Items/Default/Default/ItemImages/AltItemShot/315x472/T76851s.jpg", 7.99m, "Jumper" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "denim straight leg trousers with logo loop on the back.", "https://en.wikipedia.org/wiki/Jeans#/media/File:Jeans.jpg", 6.99m, "Jeans" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
