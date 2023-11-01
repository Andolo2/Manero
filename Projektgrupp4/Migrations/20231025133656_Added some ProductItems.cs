using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projektgrupp4.Migrations
{
    /// <inheritdoc />
    public partial class AddedsomeProductItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ColorId", "ColorName" },
                values: new object[] { 11, "Purple" });

            migrationBuilder.InsertData(
                table: "ProductItem",
                columns: new[] { "ProductEntryId", "ColorId", "ProductId", "SizeId" },
                values: new object[,]
                {
                    { 1, 2, 1, 7 },
                    { 2, 2, 1, 8 },
                    { 3, 2, 1, 9 },
                    { 4, 2, 1, 10 },
                    { 5, 2, 1, 11 },
                    { 6, 2, 1, 12 },
                    { 7, 2, 1, 13 },
                    { 8, 2, 1, 14 },
                    { 9, 1, 2, 1 },
                    { 10, 1, 2, 2 },
                    { 11, 1, 2, 3 },
                    { 12, 1, 2, 4 },
                    { 13, 1, 2, 5 },
                    { 14, 1, 2, 6 },
                    { 15, 6, 2, 1 },
                    { 16, 6, 2, 2 },
                    { 17, 6, 2, 3 },
                    { 18, 6, 2, 4 },
                    { 19, 6, 2, 5 },
                    { 20, 6, 2, 6 },
                    { 21, 7, 2, 1 },
                    { 22, 7, 2, 2 },
                    { 23, 7, 2, 3 },
                    { 24, 7, 2, 4 },
                    { 25, 7, 2, 5 },
                    { 26, 7, 2, 6 },
                    { 27, 10, 2, 1 },
                    { 28, 10, 2, 2 },
                    { 29, 10, 2, 3 },
                    { 30, 10, 2, 4 },
                    { 31, 10, 2, 5 },
                    { 32, 10, 2, 6 },
                    { 33, 7, 4, 1 },
                    { 34, 7, 4, 2 },
                    { 35, 7, 4, 3 },
                    { 36, 7, 4, 4 },
                    { 37, 7, 4, 5 },
                    { 38, 7, 4, 6 },
                    { 39, 8, 4, 1 },
                    { 40, 8, 4, 2 },
                    { 41, 8, 4, 3 },
                    { 42, 8, 4, 4 },
                    { 43, 8, 4, 5 },
                    { 44, 8, 4, 6 },
                    { 45, 2, 4, 1 },
                    { 46, 2, 4, 2 },
                    { 47, 2, 4, 3 },
                    { 48, 2, 4, 4 },
                    { 49, 2, 4, 5 },
                    { 50, 2, 4, 6 },
                    { 51, 5, 4, 1 },
                    { 52, 5, 4, 2 },
                    { 53, 5, 4, 3 },
                    { 54, 5, 4, 4 },
                    { 55, 5, 4, 5 },
                    { 56, 5, 4, 6 },
                    { 57, 7, 5, 1 },
                    { 58, 7, 5, 2 },
                    { 59, 7, 5, 3 },
                    { 60, 7, 5, 4 },
                    { 61, 7, 5, 5 },
                    { 62, 7, 5, 6 },
                    { 63, 1, 5, 1 },
                    { 64, 1, 5, 2 },
                    { 65, 1, 5, 3 },
                    { 66, 1, 5, 4 },
                    { 67, 1, 5, 5 },
                    { 68, 1, 5, 6 },
                    { 69, 6, 5, 1 },
                    { 70, 6, 5, 2 },
                    { 71, 6, 5, 3 },
                    { 72, 6, 5, 4 },
                    { 73, 6, 5, 5 },
                    { 74, 6, 5, 6 },
                    { 75, 1, 8, 1 },
                    { 76, 1, 8, 2 },
                    { 77, 1, 8, 3 },
                    { 78, 1, 8, 4 },
                    { 79, 1, 8, 5 },
                    { 80, 1, 8, 6 },
                    { 81, 2, 8, 1 },
                    { 82, 2, 8, 2 },
                    { 83, 2, 8, 3 },
                    { 84, 2, 8, 4 },
                    { 85, 2, 8, 5 },
                    { 86, 2, 8, 6 },
                    { 87, 3, 8, 1 },
                    { 88, 3, 8, 2 },
                    { 89, 3, 8, 3 },
                    { 90, 3, 8, 4 },
                    { 91, 3, 8, 5 },
                    { 92, 3, 8, 6 },
                    { 93, 4, 8, 1 },
                    { 94, 4, 8, 2 },
                    { 95, 4, 8, 3 },
                    { 96, 4, 8, 4 },
                    { 97, 4, 8, 5 },
                    { 98, 4, 8, 6 },
                    { 99, 5, 8, 1 },
                    { 100, 5, 8, 2 },
                    { 101, 5, 8, 3 },
                    { 102, 5, 8, 4 },
                    { 103, 5, 8, 5 },
                    { 104, 5, 8, 6 },
                    { 105, 6, 8, 1 },
                    { 106, 6, 8, 2 },
                    { 107, 6, 8, 3 },
                    { 108, 6, 8, 4 },
                    { 109, 6, 8, 5 },
                    { 110, 6, 8, 6 },
                    { 111, 7, 8, 1 },
                    { 112, 7, 8, 2 },
                    { 113, 7, 8, 3 },
                    { 114, 7, 8, 4 },
                    { 115, 7, 8, 5 },
                    { 116, 7, 8, 6 },
                    { 117, 8, 8, 1 },
                    { 118, 8, 8, 2 },
                    { 119, 8, 8, 3 },
                    { 120, 8, 8, 4 },
                    { 121, 8, 8, 5 },
                    { 122, 8, 8, 6 },
                    { 123, 9, 8, 1 },
                    { 124, 9, 8, 2 },
                    { 125, 9, 8, 3 },
                    { 126, 9, 8, 4 },
                    { 127, 9, 8, 5 },
                    { 128, 9, 8, 6 },
                    { 129, 10, 8, 1 },
                    { 130, 10, 8, 2 },
                    { 131, 10, 8, 3 },
                    { 132, 10, 8, 4 },
                    { 133, 10, 8, 5 },
                    { 134, 10, 8, 6 },
                    { 135, 11, 8, 1 },
                    { 136, 11, 8, 2 },
                    { 137, 11, 8, 3 },
                    { 138, 11, 8, 4 },
                    { 139, 11, 8, 5 },
                    { 140, 11, 8, 6 },
                    { 141, 11, 9, 7 },
                    { 142, 11, 9, 8 },
                    { 143, 11, 9, 9 },
                    { 144, 11, 9, 10 },
                    { 145, 11, 9, 11 },
                    { 146, 11, 9, 12 },
                    { 147, 11, 9, 13 },
                    { 148, 11, 9, 14 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "ProductItem",
                keyColumn: "ProductEntryId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "ColorId",
                keyValue: 11);
        }
    }
}
