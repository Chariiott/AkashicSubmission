using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Akashic8.Migrations
{
    /// <inheritdoc />
    public partial class CartIems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    BookName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    AddedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardholderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpiryDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CVV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3a92b67-5712-420d-850f-59dfe0d34a90", "AQAAAAIAAYagAAAAEN+mGIv73mhU8pdhEjZ46tHen1F1RUaj1CKarv4PIQnNsgAkHH0/kas4MAR9up4p0w==", "ff1fbc93-2dbc-4658-9c59-a307894aead4" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6272), new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6285) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6289), new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6289) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6291), new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6291) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6292), new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6293) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6768), new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6769) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6771), new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6771) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6773), new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6774) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6776), new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6776) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6542), new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6543) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6545), new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6545) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6546), new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6547) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6547), new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6548) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6549), new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6550) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6551), new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6551) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6552), new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6552) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6554), new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6554) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6555), new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6555) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6660), new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6662), new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6662) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6663), new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6664) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6665), new DateTime(2025, 2, 8, 12, 23, 7, 906, DateTimeKind.Local).AddTicks(6666) });

            migrationBuilder.CreateIndex(
                name: "IX_Book_GenreId",
                table: "Book",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Genre_GenreId",
                table: "Book",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Genre_GenreId",
                table: "Book");

            migrationBuilder.DropTable(
                name: "CartItem");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_Book_GenreId",
                table: "Book");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2c187a6-06f2-4ef0-9b9f-f20082f17372", "AQAAAAIAAYagAAAAEOEARkpR4JdoKcsvcY+c1JBNC9pIPOjFjnW+pwgdBpiXdFTZ96p4UQTG/jLBbr5yAQ==", "49371a1b-ece8-4cd5-b26f-20d9ef943e0d" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(906), new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(917) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(920), new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(920) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(922), new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(922) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(923), new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(924) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(1358), new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(1358) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(1361), new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(1362) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(1363), new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(1364) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(1413), new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(1129), new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(1131), new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(1132) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(1133), new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(1134) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(1135), new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(1135) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(1136), new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(1137) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(1138), new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(1138) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(1139), new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(1140) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(1141), new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(1142) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(1143), new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(1143) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(1253), new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(1254) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(1256), new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(1256) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(1257), new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(1258) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(1259), new DateTime(2025, 2, 5, 22, 37, 19, 142, DateTimeKind.Local).AddTicks(1259) });
        }
    }
}
