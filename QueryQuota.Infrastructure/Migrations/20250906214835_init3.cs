using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QueryQuota.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_QueryLogs_UserId_CreatedAtUtc",
                table: "QueryLogs");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "QueryLogs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84878F73-0C39-45DD-A61C-DB4AE17BD255",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e9b0e72-e15a-4eb9-aba6-687482d1d15d", "AQAAAAIAAYagAAAAEOVWaMNXQVMSBjaLjcKBhSdPZkXbK7IFiFcx5F9BsyhsgwWAmJ+OMQTzhsSd7Pcv9g==", "0d128900-c5ed-4515-b911-c0f72e0bf67b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FFE95EC4-C3C8-4255-842C-7ECBAF332778",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2b409e9-5a0c-43bc-8ee5-97841690f817", "AQAAAAIAAYagAAAAEJJsKw6pbLjZIAY0ALEd8Mq+aMwpxtRgfDuDvhvmGNWy18IV6Ko9/ztbRqprTuR55Q==", "66c37970-daee-4e03-b14d-8fd21ccd4315" });

            migrationBuilder.UpdateData(
                table: "QueryLogs",
                keyColumn: "Id",
                keyValue: "11111111-aaaa-aaaa-aaaa-111111111111",
                column: "CreatedAtUtc",
                value: new DateTime(2025, 9, 1, 17, 10, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "QueryLogs",
                keyColumn: "Id",
                keyValue: "22222222-bbbb-bbbb-bbbb-222222222222",
                column: "CreatedAtUtc",
                value: new DateTime(2025, 9, 1, 18, 25, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "QueryLogs",
                keyColumn: "Id",
                keyValue: "33333333-cccc-cccc-cccc-333333333333",
                column: "CreatedAtUtc",
                value: new DateTime(2025, 9, 1, 20, 45, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "QueryLogs",
                keyColumn: "Id",
                keyValue: "44444444-dddd-dddd-dddd-444444444444",
                column: "CreatedAtUtc",
                value: new DateTime(2025, 9, 1, 9, 15, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "QueryLogs",
                keyColumn: "Id",
                keyValue: "55555555-eeee-eeee-eeee-555555555555",
                column: "CreatedAtUtc",
                value: new DateTime(2025, 9, 1, 11, 40, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "QueryLogs",
                keyColumn: "Id",
                keyValue: "66666666-6666-6666-6666-666666666666",
                column: "CreatedAtUtc",
                value: new DateTime(2025, 9, 1, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "QueryLogs",
                keyColumn: "Id",
                keyValue: "66666666-ffff-ffff-ffff-666666666666",
                column: "CreatedAtUtc",
                value: new DateTime(2025, 9, 1, 13, 5, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "QueryLogs",
                keyColumn: "Id",
                keyValue: "77777777-7777-7777-7777-777777777777",
                column: "CreatedAtUtc",
                value: new DateTime(2025, 9, 1, 10, 15, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "QueryLogs",
                keyColumn: "Id",
                keyValue: "88888888-8888-8888-8888-888888888888",
                column: "CreatedAtUtc",
                value: new DateTime(2025, 9, 1, 11, 45, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "QueryLogs",
                keyColumn: "Id",
                keyValue: "99999999-9999-9999-9999-999999999999",
                column: "CreatedAtUtc",
                value: new DateTime(2025, 9, 1, 14, 20, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "QueryLogs",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa",
                column: "CreatedAtUtc",
                value: new DateTime(2025, 9, 1, 16, 40, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "QueryLogs",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb",
                column: "CreatedAtUtc",
                value: new DateTime(2025, 9, 1, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "QueryLogs",
                keyColumn: "Id",
                keyValue: "cccccccc-cccc-cccc-cccc-cccccccccccc",
                column: "CreatedAtUtc",
                value: new DateTime(2025, 9, 1, 8, 15, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "QueryLogs",
                keyColumn: "Id",
                keyValue: "dddddddd-dddd-dddd-dddd-dddddddddddd",
                column: "CreatedAtUtc",
                value: new DateTime(2025, 9, 1, 12, 25, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "QueryLogs",
                keyColumn: "Id",
                keyValue: "eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee",
                column: "CreatedAtUtc",
                value: new DateTime(2025, 9, 1, 13, 50, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "QueryLogs",
                keyColumn: "Id",
                keyValue: "ffffffff-ffff-ffff-ffff-ffffffffffff",
                column: "CreatedAtUtc",
                value: new DateTime(2025, 9, 1, 15, 30, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "QueryLogs",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84878F73-0C39-45DD-A61C-DB4AE17BD255",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2610a896-46ce-4fdb-b1c5-3a7b87efb09b", "AQAAAAIAAYagAAAAEFFaDpG7msEddDGWI4HqvC0sqfAPQqXB1nYkBzZF6Awu96IAvJLVYcylK0kQVe5Vsg==", "5661c3e6-0bcb-4033-8f1a-2a77a672d6f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FFE95EC4-C3C8-4255-842C-7ECBAF332778",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0902ac27-5260-4d52-89df-f48a2f2a11f0", "AQAAAAIAAYagAAAAEMOoUifY8xxiVKa3j0ewQBflePkM/M+ckE41ln6UKCLj02WGHIScKFyyFEdsc4bKlQ==", "480c1486-9a85-420f-8794-05ee5dc37278" });

            migrationBuilder.UpdateData(
                table: "QueryLogs",
                keyColumn: "Id",
                keyValue: "11111111-aaaa-aaaa-aaaa-111111111111",
                column: "CreatedAtUtc",
                value: new DateTime(2025, 2, 11, 17, 10, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "QueryLogs",
                keyColumn: "Id",
                keyValue: "22222222-bbbb-bbbb-bbbb-222222222222",
                column: "CreatedAtUtc",
                value: new DateTime(2025, 2, 12, 18, 25, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "QueryLogs",
                keyColumn: "Id",
                keyValue: "33333333-cccc-cccc-cccc-333333333333",
                column: "CreatedAtUtc",
                value: new DateTime(2025, 2, 13, 20, 45, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "QueryLogs",
                keyColumn: "Id",
                keyValue: "44444444-dddd-dddd-dddd-444444444444",
                column: "CreatedAtUtc",
                value: new DateTime(2025, 2, 14, 9, 15, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "QueryLogs",
                keyColumn: "Id",
                keyValue: "55555555-eeee-eeee-eeee-555555555555",
                column: "CreatedAtUtc",
                value: new DateTime(2025, 2, 15, 11, 40, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "QueryLogs",
                keyColumn: "Id",
                keyValue: "66666666-6666-6666-6666-666666666666",
                column: "CreatedAtUtc",
                value: new DateTime(2025, 2, 1, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "QueryLogs",
                keyColumn: "Id",
                keyValue: "66666666-ffff-ffff-ffff-666666666666",
                column: "CreatedAtUtc",
                value: new DateTime(2025, 2, 16, 13, 5, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "QueryLogs",
                keyColumn: "Id",
                keyValue: "77777777-7777-7777-7777-777777777777",
                column: "CreatedAtUtc",
                value: new DateTime(2025, 2, 2, 10, 15, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "QueryLogs",
                keyColumn: "Id",
                keyValue: "88888888-8888-8888-8888-888888888888",
                column: "CreatedAtUtc",
                value: new DateTime(2025, 2, 3, 11, 45, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "QueryLogs",
                keyColumn: "Id",
                keyValue: "99999999-9999-9999-9999-999999999999",
                column: "CreatedAtUtc",
                value: new DateTime(2025, 2, 4, 14, 20, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "QueryLogs",
                keyColumn: "Id",
                keyValue: "aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa",
                column: "CreatedAtUtc",
                value: new DateTime(2025, 2, 5, 16, 40, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "QueryLogs",
                keyColumn: "Id",
                keyValue: "bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb",
                column: "CreatedAtUtc",
                value: new DateTime(2025, 2, 6, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "QueryLogs",
                keyColumn: "Id",
                keyValue: "cccccccc-cccc-cccc-cccc-cccccccccccc",
                column: "CreatedAtUtc",
                value: new DateTime(2025, 2, 7, 8, 15, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "QueryLogs",
                keyColumn: "Id",
                keyValue: "dddddddd-dddd-dddd-dddd-dddddddddddd",
                column: "CreatedAtUtc",
                value: new DateTime(2025, 2, 8, 12, 25, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "QueryLogs",
                keyColumn: "Id",
                keyValue: "eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee",
                column: "CreatedAtUtc",
                value: new DateTime(2025, 2, 9, 13, 50, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "QueryLogs",
                keyColumn: "Id",
                keyValue: "ffffffff-ffff-ffff-ffff-ffffffffffff",
                column: "CreatedAtUtc",
                value: new DateTime(2025, 2, 10, 15, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_QueryLogs_UserId_CreatedAtUtc",
                table: "QueryLogs",
                columns: new[] { "UserId", "CreatedAtUtc" });
        }
    }
}
