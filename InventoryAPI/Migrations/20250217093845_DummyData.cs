using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InventoryAPI.Migrations
{
    /// <inheritdoc />
    public partial class DummyData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Product 1" },
                    { 2, "Product 2" },
                    { 3, "Product 3" },
                    { 4, "Product 4" },
                    { 5, "Product 5" },
                    { 6, "Product 6" },
                    { 7, "Product 7" },
                    { 8, "Product 8" },
                    { 9, "Product 9" },
                    { 10, "Product 10" },
                    { 11, "Product 11" },
                    { 12, "Product 12" },
                    { 13, "Product 13" },
                    { 14, "Product 14" },
                    { 15, "Product 15" },
                    { 16, "Product 16" },
                    { 17, "Product 17" },
                    { 18, "Product 18" },
                    { 19, "Product 19" },
                    { 20, "Product 20" },
                    { 21, "Product 21" },
                    { 22, "Product 22" },
                    { 23, "Product 23" },
                    { 24, "Product 24" },
                    { 25, "Product 25" },
                    { 26, "Product 26" },
                    { 27, "Product 27" },
                    { 28, "Product 28" },
                    { 29, "Product 29" },
                    { 30, "Product 30" },
                    { 31, "Product 31" },
                    { 32, "Product 32" },
                    { 33, "Product 33" },
                    { 34, "Product 34" },
                    { 35, "Product 35" },
                    { 36, "Product 36" },
                    { 37, "Product 37" },
                    { 38, "Product 38" },
                    { 39, "Product 39" },
                    { 40, "Product 40" },
                    { 41, "Product 41" },
                    { 42, "Product 42" },
                    { 43, "Product 43" },
                    { 44, "Product 44" },
                    { 45, "Product 45" },
                    { 46, "Product 46" },
                    { 47, "Product 47" },
                    { 48, "Product 48" },
                    { 49, "Product 49" },
                    { 50, "Product 50" },
                    { 51, "Product 51" },
                    { 52, "Product 52" },
                    { 53, "Product 53" },
                    { 54, "Product 54" },
                    { 55, "Product 55" },
                    { 56, "Product 56" },
                    { 57, "Product 57" },
                    { 58, "Product 58" },
                    { 59, "Product 59" },
                    { 60, "Product 60" },
                    { 61, "Product 61" },
                    { 62, "Product 62" },
                    { 63, "Product 63" },
                    { 64, "Product 64" },
                    { 65, "Product 65" },
                    { 66, "Product 66" },
                    { 67, "Product 67" },
                    { 68, "Product 68" },
                    { 69, "Product 69" },
                    { 70, "Product 70" },
                    { 71, "Product 71" },
                    { 72, "Product 72" },
                    { 73, "Product 73" },
                    { 74, "Product 74" },
                    { 75, "Product 75" },
                    { 76, "Product 76" },
                    { 77, "Product 77" },
                    { 78, "Product 78" },
                    { 79, "Product 79" },
                    { 80, "Product 80" },
                    { 81, "Product 81" },
                    { 82, "Product 82" },
                    { 83, "Product 83" },
                    { 84, "Product 84" },
                    { 85, "Product 85" },
                    { 86, "Product 86" },
                    { 87, "Product 87" },
                    { 88, "Product 88" },
                    { 89, "Product 89" },
                    { 90, "Product 90" },
                    { 91, "Product 91" },
                    { 92, "Product 92" },
                    { 93, "Product 93" },
                    { 94, "Product 94" },
                    { 95, "Product 95" },
                    { 96, "Product 96" },
                    { 97, "Product 97" },
                    { 98, "Product 98" },
                    { 99, "Product 99" },
                    { 100, "Product 100" }
                });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Warehouse 1" },
                    { 2, "Warehouse 2" },
                    { 3, "Warehouse 3" },
                    { 4, "Warehouse 4" },
                    { 5, "Warehouse 5" },
                    { 6, "Warehouse 6" },
                    { 7, "Warehouse 7" },
                    { 8, "Warehouse 8" },
                    { 9, "Warehouse 9" },
                    { 10, "Warehouse 10" }
                });

            migrationBuilder.InsertData(
                table: "StockRecords",
                columns: new[] { "Id", "ProductId", "Quantity", "WarehouseId" },
                values: new object[,]
                {
                    { 1, 1, 10, 2 },
                    { 2, 1, 20, 7 },
                    { 3, 2, 20, 3 },
                    { 4, 2, 40, 8 },
                    { 5, 3, 30, 4 },
                    { 6, 3, 60, 9 },
                    { 7, 4, 40, 5 },
                    { 8, 4, 80, 10 },
                    { 9, 5, 50, 6 },
                    { 10, 5, 10, 1 },
                    { 11, 6, 60, 7 },
                    { 12, 6, 20, 2 },
                    { 13, 7, 70, 8 },
                    { 14, 7, 40, 3 },
                    { 15, 8, 80, 9 },
                    { 16, 8, 60, 4 },
                    { 17, 9, 90, 10 },
                    { 18, 9, 80, 5 },
                    { 19, 10, 10, 1 },
                    { 20, 10, 10, 6 },
                    { 21, 11, 10, 2 },
                    { 22, 11, 20, 7 },
                    { 23, 12, 20, 3 },
                    { 24, 12, 40, 8 },
                    { 25, 13, 30, 4 },
                    { 26, 13, 60, 9 },
                    { 27, 14, 40, 5 },
                    { 28, 14, 80, 10 },
                    { 29, 15, 50, 6 },
                    { 30, 15, 10, 1 },
                    { 31, 16, 60, 7 },
                    { 32, 16, 20, 2 },
                    { 33, 17, 70, 8 },
                    { 34, 17, 40, 3 },
                    { 35, 18, 80, 9 },
                    { 36, 18, 60, 4 },
                    { 37, 19, 90, 10 },
                    { 38, 19, 80, 5 },
                    { 39, 20, 10, 1 },
                    { 40, 20, 10, 6 },
                    { 41, 21, 10, 2 },
                    { 42, 21, 20, 7 },
                    { 43, 22, 20, 3 },
                    { 44, 22, 40, 8 },
                    { 45, 23, 30, 4 },
                    { 46, 23, 60, 9 },
                    { 47, 24, 40, 5 },
                    { 48, 24, 80, 10 },
                    { 49, 25, 50, 6 },
                    { 50, 25, 10, 1 },
                    { 51, 26, 60, 7 },
                    { 52, 26, 20, 2 },
                    { 53, 27, 70, 8 },
                    { 54, 27, 40, 3 },
                    { 55, 28, 80, 9 },
                    { 56, 28, 60, 4 },
                    { 57, 29, 90, 10 },
                    { 58, 29, 80, 5 },
                    { 59, 30, 10, 1 },
                    { 60, 30, 10, 6 },
                    { 61, 31, 10, 2 },
                    { 62, 31, 20, 7 },
                    { 63, 32, 20, 3 },
                    { 64, 32, 40, 8 },
                    { 65, 33, 30, 4 },
                    { 66, 33, 60, 9 },
                    { 67, 34, 40, 5 },
                    { 68, 34, 80, 10 },
                    { 69, 35, 50, 6 },
                    { 70, 35, 10, 1 },
                    { 71, 36, 60, 7 },
                    { 72, 36, 20, 2 },
                    { 73, 37, 70, 8 },
                    { 74, 37, 40, 3 },
                    { 75, 38, 80, 9 },
                    { 76, 38, 60, 4 },
                    { 77, 39, 90, 10 },
                    { 78, 39, 80, 5 },
                    { 79, 40, 10, 1 },
                    { 80, 40, 10, 6 },
                    { 81, 41, 10, 2 },
                    { 82, 41, 20, 7 },
                    { 83, 42, 20, 3 },
                    { 84, 42, 40, 8 },
                    { 85, 43, 30, 4 },
                    { 86, 43, 60, 9 },
                    { 87, 44, 40, 5 },
                    { 88, 44, 80, 10 },
                    { 89, 45, 50, 6 },
                    { 90, 45, 10, 1 },
                    { 91, 46, 60, 7 },
                    { 92, 46, 20, 2 },
                    { 93, 47, 70, 8 },
                    { 94, 47, 40, 3 },
                    { 95, 48, 80, 9 },
                    { 96, 48, 60, 4 },
                    { 97, 49, 90, 10 },
                    { 98, 49, 80, 5 },
                    { 99, 50, 10, 1 },
                    { 100, 50, 10, 6 },
                    { 101, 51, 10, 2 },
                    { 102, 51, 20, 7 },
                    { 103, 52, 20, 3 },
                    { 104, 52, 40, 8 },
                    { 105, 53, 30, 4 },
                    { 106, 53, 60, 9 },
                    { 107, 54, 40, 5 },
                    { 108, 54, 80, 10 },
                    { 109, 55, 50, 6 },
                    { 110, 55, 10, 1 },
                    { 111, 56, 60, 7 },
                    { 112, 56, 20, 2 },
                    { 113, 57, 70, 8 },
                    { 114, 57, 40, 3 },
                    { 115, 58, 80, 9 },
                    { 116, 58, 60, 4 },
                    { 117, 59, 90, 10 },
                    { 118, 59, 80, 5 },
                    { 119, 60, 10, 1 },
                    { 120, 60, 10, 6 },
                    { 121, 61, 10, 2 },
                    { 122, 61, 20, 7 },
                    { 123, 62, 20, 3 },
                    { 124, 62, 40, 8 },
                    { 125, 63, 30, 4 },
                    { 126, 63, 60, 9 },
                    { 127, 64, 40, 5 },
                    { 128, 64, 80, 10 },
                    { 129, 65, 50, 6 },
                    { 130, 65, 10, 1 },
                    { 131, 66, 60, 7 },
                    { 132, 66, 20, 2 },
                    { 133, 67, 70, 8 },
                    { 134, 67, 40, 3 },
                    { 135, 68, 80, 9 },
                    { 136, 68, 60, 4 },
                    { 137, 69, 90, 10 },
                    { 138, 69, 80, 5 },
                    { 139, 70, 10, 1 },
                    { 140, 70, 10, 6 },
                    { 141, 71, 10, 2 },
                    { 142, 71, 20, 7 },
                    { 143, 72, 20, 3 },
                    { 144, 72, 40, 8 },
                    { 145, 73, 30, 4 },
                    { 146, 73, 60, 9 },
                    { 147, 74, 40, 5 },
                    { 148, 74, 80, 10 },
                    { 149, 75, 50, 6 },
                    { 150, 75, 10, 1 },
                    { 151, 76, 60, 7 },
                    { 152, 76, 20, 2 },
                    { 153, 77, 70, 8 },
                    { 154, 77, 40, 3 },
                    { 155, 78, 80, 9 },
                    { 156, 78, 60, 4 },
                    { 157, 79, 90, 10 },
                    { 158, 79, 80, 5 },
                    { 159, 80, 10, 1 },
                    { 160, 80, 10, 6 },
                    { 161, 81, 10, 2 },
                    { 162, 81, 20, 7 },
                    { 163, 82, 20, 3 },
                    { 164, 82, 40, 8 },
                    { 165, 83, 30, 4 },
                    { 166, 83, 60, 9 },
                    { 167, 84, 40, 5 },
                    { 168, 84, 80, 10 },
                    { 169, 85, 50, 6 },
                    { 170, 85, 10, 1 },
                    { 171, 86, 60, 7 },
                    { 172, 86, 20, 2 },
                    { 173, 87, 70, 8 },
                    { 174, 87, 40, 3 },
                    { 175, 88, 80, 9 },
                    { 176, 88, 60, 4 },
                    { 177, 89, 90, 10 },
                    { 178, 89, 80, 5 },
                    { 179, 90, 10, 1 },
                    { 180, 90, 10, 6 },
                    { 181, 91, 10, 2 },
                    { 182, 91, 20, 7 },
                    { 183, 92, 20, 3 },
                    { 184, 92, 40, 8 },
                    { 185, 93, 30, 4 },
                    { 186, 93, 60, 9 },
                    { 187, 94, 40, 5 },
                    { 188, 94, 80, 10 },
                    { 189, 95, 50, 6 },
                    { 190, 95, 10, 1 },
                    { 191, 96, 60, 7 },
                    { 192, 96, 20, 2 },
                    { 193, 97, 70, 8 },
                    { 194, 97, 40, 3 },
                    { 195, 98, 80, 9 },
                    { 196, 98, 60, 4 },
                    { 197, 99, 90, 10 },
                    { 198, 99, 80, 5 },
                    { 199, 100, 10, 1 },
                    { 200, 100, 10, 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "StockRecords",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

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

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
