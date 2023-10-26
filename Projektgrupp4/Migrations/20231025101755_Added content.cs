using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projektgrupp4.Migrations
{
    /// <inheritdoc />
    public partial class Addedcontent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Men" },
                    { 2, "Women" },
                    { 3, "Kids" },
                    { 4, "Accessories" },
                    { 5, "Shoes" },
                    { 6, "Dresses" },
                    { 7, "Pants" },
                    { 8, "Bestsellers" },
                    { 9, "Featured" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ColorId", "ColorName" },
                values: new object[,]
                {
                    { 1, "White" },
                    { 2, "Black" },
                    { 3, "Red" },
                    { 4, "Green" },
                    { 5, "Blue" },
                    { 6, "Beige" },
                    { 7, "LightBlue" },
                    { 8, "DarkBlue" },
                    { 9, "Orange" },
                    { 10, "Yellow" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ArticleNumber", "ProductDescription", "ProductImageUrl", "ProductOfferPrice", "ProductPrice", "ProductPriceOrOffer", "ProductTitle" },
                values: new object[] { 1, "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.", "#", 0m, 29.80m, false, "Black sneakers" });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "SizeId", "SizeName" },
                values: new object[,]
                {
                    { 1, "XS" },
                    { 2, "S" },
                    { 3, "M" },
                    { 4, "L" },
                    { 5, "XL" },
                    { 6, "XXL" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 6);
        }
    }
}
