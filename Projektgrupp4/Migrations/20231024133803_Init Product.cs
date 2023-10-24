using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projektgrupp4.Migrations
{
    /// <inheritdoc />
    public partial class InitProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ArticleNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPrice = table.Column<int>(type: "int", nullable: false),
                    ProductOfferPrice = table.Column<int>(type: "int", nullable: true),
                    ProductPriceOrOffer = table.Column<bool>(type: "bit", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductColor = table.Column<int>(type: "int", nullable: true),
                    ProductLabel = table.Column<int>(type: "int", nullable: true),
                    ProductSize = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ArticleNumber);
                });

            migrationBuilder.CreateTable(
                name: "ReviewEntity",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewEntity", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_ReviewEntity_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ArticleNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReviewEntity_ProductId",
                table: "ReviewEntity",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReviewEntity");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
