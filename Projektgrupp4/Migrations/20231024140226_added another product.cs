using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projektgrupp4.Migrations
{
    /// <inheritdoc />
    public partial class addedanotherproduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ArticleNumber", "ProductColor", "ProductDescription", "ProductImageUrl", "ProductLabel", "ProductOfferPrice", "ProductPrice", "ProductPriceOrOffer", "ProductSize", "ProductTitle" },
                values: new object[] { 2, 2, "This is a pair of jeans", null, 7, 150, 399, true, 3, "Jeans" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ArticleNumber",
                keyValue: 2);
        }
    }
}
