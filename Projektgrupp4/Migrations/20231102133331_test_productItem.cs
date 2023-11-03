using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projektgrupp4.Migrations
{
    /// <inheritdoc />
    public partial class test_productItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "ProductItem",
                type: "int",
                nullable: false
            );

            migrationBuilder.CreateIndex(
                name: "IX_ProductItem_CategoryId",
                table: "ProductItem",
                column: "CategoryId"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_ProductItem_Categories_CategoryId",
                table: "ProductItem",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
