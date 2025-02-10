using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Akashic8.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6325), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6338), "Harper Lee", "System" },
                    { 2, "System", new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6342), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6342), "J.R.R. Tolkien", "System" },
                    { 3, "System", new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6344), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6344), "Herman Melville", "System" },
                    { 4, "System", new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6345), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6346), "J.K. Rowling", "System" }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "CreatedBy", "DateCreated", "DateUpdated", "Description", "GenreId", "ISBN", "ImageUrl", "LanguageId", "Name", "Price", "Quantity", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, "System", new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6795), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6796), "A novel by Harper Lee", 1, "978-0-06-112008-4", "/images/To Kill A Mockingbird.jpg", 1, "To Kill A Mockingbird", 12.99, 10, "System" },
                    { 2, 2, "System", new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6798), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6799), "A novel by J.R.R. Tolkien", 9, "978-0-21-102080-4", "/images/The Hobbit.jpg", 1, "The Hobbit", 15.99, 3, "System" },
                    { 3, 3, "System", new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6801), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6802), "A novel by Herman Melville", 1, "978-0-43-265346-1", "/images/Moby Dick.jpg", 1, "Moby-Dick", 11.5, 17, "System" },
                    { 4, 4, "System", new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6804), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6805), "A novel by J.K. Rowling", 9, "978-0-43-265346-1", "/images/Harry Potter and The Sorcerer's Stone.jpg", 1, "Harry Potter and the Sorcerer's Stone", 18.989999999999998, 34, "System" }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6534), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6535), "Fiction", "System" },
                    { 2, "System", new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6537), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6537), "Romance", "System" },
                    { 3, "System", new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6539), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6539), "Mystery", "System" },
                    { 4, "System", new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6540), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6541), "Horror", "System" },
                    { 5, "System", new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6542), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6542), "Cereal Killer Thriller", "System" },
                    { 6, "System", new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6543), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6544), "Non-fiction", "System" },
                    { 7, "System", new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6545), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6546), "Graphic Novel", "System" },
                    { 8, "System", new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6547), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6547), "Crime", "System" },
                    { 9, "System", new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6548), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6549), "Fantasy", "System" }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6703), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6704), "English", "System" },
                    { 2, "System", new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6706), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6707), "Chinese", "System" },
                    { 3, "System", new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6708), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6708), "Malay", "System" },
                    { 4, "System", new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6710), new DateTime(2025, 2, 5, 22, 26, 10, 402, DateTimeKind.Local).AddTicks(6710), "Tamil", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
