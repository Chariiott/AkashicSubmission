using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Akashic8.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "a2c187a6-06f2-4ef0-9b9f-f20082f17372", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEOEARkpR4JdoKcsvcY+c1JBNC9pIPOjFjnW+pwgdBpiXdFTZ96p4UQTG/jLBbr5yAQ==", null, false, "49371a1b-ece8-4cd5-b26f-20d9ef943e0d", false, "admin@localhost.com" });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(303), new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(315) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(318), new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(318) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(320), new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(320) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(321), new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(322) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(804), new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(805) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(808), new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(809) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(811), new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(811) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(814), new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(814) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(563), new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(564) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(566), new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(567) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(568), new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(568) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(570), new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(570) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(571), new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(572) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(573), new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(574) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(575), new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(575) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(577), new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(577) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(578), new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(579) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(697), new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(698) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(700), new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(701) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(702), new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(702) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(703), new DateTime(2025, 2, 5, 22, 30, 55, 445, DateTimeKind.Local).AddTicks(704) });
        }
    }
}
