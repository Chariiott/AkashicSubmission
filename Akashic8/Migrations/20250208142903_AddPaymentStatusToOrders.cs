using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Akashic8.Migrations
{
    /// <inheritdoc />
    public partial class AddPaymentStatusToOrders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PaymentStatus",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55fd22e2-91af-4dd9-82d5-86be4a82d42c", "AQAAAAIAAYagAAAAEHcBktiTXWoiu0B52DjxQuJjmOiMNiEvhxXZJWeA6oB4WOj+IZG9QszJsL5h2rPVOA==", "d33b78fd-b3ef-4798-b8b9-f363aa1c38b8" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7479), new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7493) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7495), new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7496) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7497), new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7498) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7499), new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7499) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7949), new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7953), new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7953) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7955), new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7956) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7958), new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7958) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7729), new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7729) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7732), new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7732) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7733), new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7734) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7735), new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7735) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7736), new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7737) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7738), new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7738) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7739), new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7741), new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7743), new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7743) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7848), new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7849) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7850), new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7851) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7852), new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7852) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7853), new DateTime(2025, 2, 8, 22, 29, 2, 897, DateTimeKind.Local).AddTicks(7854) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentStatus",
                table: "Order");

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
        }
    }
}
