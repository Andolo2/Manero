using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projektgrupp4.Migrations
{
    /// <inheritdoc />
    public partial class addedproduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ArticleNumber", "ProductColor", "ProductDescription", "ProductImageUrl", "ProductLabel", "ProductOfferPrice", "ProductPrice", "ProductPriceOrOffer", "ProductSize", "ProductTitle" },
                values: new object[] { 1, 1, "This is a T-shirt", null, 5, 150, 399, true, 2, "T-shirt" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ArticleNumber",
                keyValue: 1);
        }
    }
}
