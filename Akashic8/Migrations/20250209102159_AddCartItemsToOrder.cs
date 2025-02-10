using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Akashic8.Migrations
{
    /// <inheritdoc />
    public partial class AddCartItemsToOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "CartItem",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96631c3f-e4c1-4d80-bf34-650416419dc1", "AQAAAAIAAYagAAAAEEThaW8XBC5h/itncGLXUFbJ0SaxW62WiwBOQVqBr9Rh28USwD6K3Ha9dK0pbRKsmQ==", "49ef714f-a2b1-49bb-906d-26ee660bdf7e" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(401), new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(413) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(414), new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(416), new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(418), new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(419) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(925), new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(926) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(928), new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(929) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(931), new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(931) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(933), new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(934) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(691), new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(692) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(693), new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(694) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(695), new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(695) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(697), new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(697) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(698), new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(699) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(700), new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(701), new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(701) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(703), new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(703) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(704), new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(704) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(815), new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(816) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(818), new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(818) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(820), new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(820) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(821), new DateTime(2025, 2, 9, 18, 21, 58, 328, DateTimeKind.Local).AddTicks(822) });

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_OrderId",
                table: "CartItem",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_Order_OrderId",
                table: "CartItem",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_Order_OrderId",
                table: "CartItem");

            migrationBuilder.DropIndex(
                name: "IX_CartItem_OrderId",
                table: "CartItem");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "CartItem");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd90a5fd-f2e8-4389-b5e4-30931bece3ee", "AQAAAAIAAYagAAAAEL03PQZCvvB9UTb5b13xCsklL5RMiMwBUMRji4k3seWkBQIpMEzHjptKGND89DUHnA==", "e41850e5-0cc4-44e5-b610-f5b2fb3f2433" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8400), new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8411) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8413), new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8414) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8415), new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8415) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8416), new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8417) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8856), new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8857) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8859), new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8862), new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8862) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8864), new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8864) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8623), new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8624) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8625), new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8626) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8627), new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8627) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8628), new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8629) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8630), new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8631), new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8632) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8633), new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8633) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8634), new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8635) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8636), new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8636) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8751), new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8751) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8753), new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8754), new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8755) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8756), new DateTime(2025, 2, 9, 17, 14, 20, 449, DateTimeKind.Local).AddTicks(8757) });
        }
    }
}
