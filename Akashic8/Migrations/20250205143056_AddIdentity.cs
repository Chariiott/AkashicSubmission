using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Akashic8.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6325), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6338) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6342), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6342) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6344), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6344) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6345), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6346) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6795), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6796) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6798), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6799) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6801), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6802) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6804), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6805) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6534), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6535) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6537), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6537) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6539), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6539) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6540), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6541) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6542), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6542) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6543), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6544) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6545), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6546) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6547), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6547) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6548), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6549) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6703), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6704) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6706), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6707) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6708), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6708) });

            migrationBuilder.UpdateData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6710), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6710) });
        }
    }
}
