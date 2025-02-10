using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Akashic8.Migrations
{
    /// <inheritdoc />
    public partial class AddUserIdToPayments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Payment");

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
    }
}
