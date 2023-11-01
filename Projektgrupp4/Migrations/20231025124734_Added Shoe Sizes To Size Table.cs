using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projektgrupp4.Migrations
{
    /// <inheritdoc />
    public partial class AddedShoeSizesToSizeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ArticleNumber", "ProductDescription", "ProductImageUrl", "ProductOfferPrice", "ProductPrice", "ProductPriceOrOffer", "ProductTitle" },
                values: new object[,]
                {
                    { 2, "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.", "#", 15.98m, 36.00m, true, "Summer dress" },
                    { 3, "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.", "#", 30.00m, 38.00m, true, "Shoulder bag" },
                    { 4, "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.", "#", 0m, 54.96m, false, "Denim shorts" },
                    { 5, "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.", "#", 0m, 31.78m, false, "Summer pants" },
                    { 6, "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.", "#", 0m, 6.93m, false, "Warm hat" },
                    { 7, "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.", "#", 0m, 24.95m, false, "Hand bag" },
                    { 8, "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.", "#", 0m, 12.95m, false, "T-shirt" },
                    { 9, "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.", "#", 0m, 22.87m, false, "Purple sneakers" },
                    { 10, "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.", "#", 0m, 54.96m, false, "Denim shorts" }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "SizeId", "SizeName" },
                values: new object[,]
                {
                    { 7, "37" },
                    { 8, "38" },
                    { 9, "39" },
                    { 10, "40" },
                    { 11, "41" },
                    { 12, "42" },
                    { 13, "43" },
                    { 14, "44" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ArticleNumber",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 14);
        }
    }
}
