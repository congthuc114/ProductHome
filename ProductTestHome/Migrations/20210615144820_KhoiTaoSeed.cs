using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductTestHome.Migrations
{
    public partial class KhoiTaoSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "datePro", "photo", "price" },
                values: new object[] { 1, "Nhà", new DateTime(2021, 6, 15, 21, 48, 19, 669, DateTimeKind.Local).AddTicks(197), "https://i.ibb.co/0yfVm4t/download.jpg", "20000" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "datePro", "photo", "price" },
                values: new object[] { 2, "Tâm Lý Học", new DateTime(2021, 6, 15, 21, 48, 19, 669, DateTimeKind.Local).AddTicks(8451), "https://i.ibb.co/4jZTVnH/download.jpg", "25000" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
