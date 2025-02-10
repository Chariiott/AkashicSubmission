using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Akashic8.Migrations
{
    /// <inheritdoc />
    public partial class AddUserIdToOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d188baa-9195-4d09-965f-6abdf86108b5", "AQAAAAIAAYagAAAAENDDFMS4FhFo7Dtu39ufqZYIsEsS3OEaG8fp2g7V8Qj1KfSAz8gzRwEvNKWkDboK5Q==", "b33f88ef-4fa1-403e-a56a-d06cbfcf1e4c" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(5716), new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(5728) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(5729), new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(5731), new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(5732) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(5733), new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(5734) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(6251), new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(6252) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(6254), new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(6255) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(6257), new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(6257) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(6259), new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(6019), new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(6022), new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(6022) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(6024), new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(6024) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(6025), new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(6027), new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(6027) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(6028), new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(6030), new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(6031) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(6032), new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(6032) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(6033), new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(6034) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(6151), new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(6151) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(6153), new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(6153) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(6154), new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(6155) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(6156), new DateTime(2025, 2, 9, 21, 12, 37, 251, DateTimeKind.Local).AddTicks(6156) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Order");

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
        }
    }
}
