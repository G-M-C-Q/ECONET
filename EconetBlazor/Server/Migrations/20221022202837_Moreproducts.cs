using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EconetBlazor.Server.Migrations
{
    public partial class Moreproducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CategoryId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://i5.walmartimages.com/asr/fb7c02b1-6dbe-4c09-808b-03481f62e9f9.d5b7c792e2fe17292f76c76bfd8149b1.jpeg");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 4, 3, "Red Sundress", "https://xcdn.next.co.uk/COMMON/Items/Default/Default/ItemImages/AltItemShot/315x472/A57518s.jpg", 15.50m, "Sun Dress" },
                    { 5, 1, "Cream Cropped Jumper, High neckline", "https://media3.newlookassets.com/i/newlook/821129816/womens/clothing/knitwear/blue-vanilla-stone-cable-knit-roll-neck-crop-jumper.jpg?strip=true&qlt=80&w=720", 4.50m, "Cropped Jumper" },
                    { 6, 2, "Black faux leather pant", "https://th.bing.com/th/id/R.bc70a7d3ed0d142eab927ca61b63916b?rik=rticQCYYDgN9wg&pid=ImgRaw&r=0", 9.99m, "Pleather Pants" },
                    { 7, 3, "Midnight Blue Satin Midi dress", "https://th.bing.com/th/id/OIP.HT8GDy8mfo8AcGa5BSS4YAHaLz?pid=ImgDet&rs=1", 12.00m, "Midi Dress" },
                    { 8, 3, "Little black dress with sequin detail", "https://img.promgirl.com/_img/PGPRODUCTS/2270536/1000/black-dress-SOP-D17733LCS-b.jpg", 9.99m, "LBD" },
                    { 9, 2, "Pink Turtleneck Jumper", "https://tommy-europe.scene7.com/is/image/TommyEurope/KG0KG06895_TZO_main?$main$", 6.00m, "Turtle neck" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://en.wikipedia.org/wiki/Jeans#/media/File:Jeans.jpg");
        }
    }
}
