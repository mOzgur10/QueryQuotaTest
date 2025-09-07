using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QueryQuota.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84878F73-0C39-45DD-A61C-DB4AE17BD255",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ace8a4a0-4dd2-4992-9a4e-cf9195bdea67", "AQAAAAIAAYagAAAAEMr3MJVJaoXFwMoJ4yILFJWx36PMkhgscOPrU4utr7laLKNmpf6KgaNw0oUOjEWZPg==", "8753fda5-98fc-4484-a67e-6b8b81c8b167" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FFE95EC4-C3C8-4255-842C-7ECBAF332778",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ab343b6-573e-4b0b-9699-d147c3fbeecd", "AQAAAAIAAYagAAAAEILTJsl3Jlm19GaTHq/jqF2Fn/ti7Wht5l38XCGaix6ff+RJ/doK7YBO6dsAFYkypg==", "d9e64749-42a3-47c9-97c5-8b3941ded4e1" });
        }
    }
}
