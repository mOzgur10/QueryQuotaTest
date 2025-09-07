using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QueryQuota.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init1 : Migration
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
                name: "MyData",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedAtUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QueryLogs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Term = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAtUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QueryLogs", x => x.Id);
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "84878F73-0C39-45DD-A61C-DB4AE17BD255", 0, "ace8a4a0-4dd2-4992-9a4e-cf9195bdea67", "userA@example.com", true, false, null, "USERA@EXAMPLE.COM", "USERA@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMr3MJVJaoXFwMoJ4yILFJWx36PMkhgscOPrU4utr7laLKNmpf6KgaNw0oUOjEWZPg==", null, false, "8753fda5-98fc-4484-a67e-6b8b81c8b167", false, "userA@example.com" },
                    { "FFE95EC4-C3C8-4255-842C-7ECBAF332778", 0, "8ab343b6-573e-4b0b-9699-d147c3fbeecd", "userB@example.com", true, false, null, "USERB@EXAMPLE.COM", "USERB@EXAMPLE.COM", "AQAAAAIAAYagAAAAEILTJsl3Jlm19GaTHq/jqF2Fn/ti7Wht5l38XCGaix6ff+RJ/doK7YBO6dsAFYkypg==", null, false, "d9e64749-42a3-47c9-97c5-8b3941ded4e1", false, "userB@example.com" }
                });

            migrationBuilder.InsertData(
                table: "MyData",
                columns: new[] { "Id", "CreatedAtUtc", "Data", "Status" },
                values: new object[,]
                {
                    { "11111111-1111-1111-1111-111111111111", new DateTime(2024, 12, 31, 23, 59, 59, 0, DateTimeKind.Unspecified), "Alpha", 0 },
                    { "22222222-2222-2222-2222-222222222222", new DateTime(2025, 1, 5, 10, 30, 0, 0, DateTimeKind.Unspecified), "Beta", 0 },
                    { "33333333-3333-3333-3333-333333333333", new DateTime(2025, 1, 10, 15, 45, 0, 0, DateTimeKind.Unspecified), "Gamma", 0 },
                    { "44444444-4444-4444-4444-444444444444", new DateTime(2025, 1, 15, 8, 20, 0, 0, DateTimeKind.Unspecified), "Delta", 0 },
                    { "55555555-5555-5555-5555-555555555555", new DateTime(2025, 2, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "Epsilon", 0 },
                    { "66666666-6666-6666-6666-666666666666", new DateTime(2025, 2, 14, 19, 30, 0, 0, DateTimeKind.Unspecified), "Zeta", 0 },
                    { "77777777-7777-7777-7777-777777777777", new DateTime(2025, 3, 3, 6, 10, 0, 0, DateTimeKind.Unspecified), "Eta", 0 },
                    { "88888888-8888-8888-8888-888888888888", new DateTime(2025, 3, 15, 14, 50, 0, 0, DateTimeKind.Unspecified), "Theta", 0 },
                    { "99999999-9999-9999-9999-999999999999", new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iota", 0 },
                    { "aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa", new DateTime(2025, 4, 20, 22, 45, 0, 0, DateTimeKind.Unspecified), "Kappa", 0 }
                });

            migrationBuilder.InsertData(
                table: "QueryLogs",
                columns: new[] { "Id", "CreatedAtUtc", "Status", "Term", "UserId" },
                values: new object[,]
                {
                    { "11111111-1111-1111-1111-111111111111", new DateTime(2025, 3, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), 0, "alpha", "84878F73-0C39-45DD-A61C-DB4AE17BD255" },
                    { "11111111-aaaa-aaaa-aaaa-111111111111", new DateTime(2025, 2, 11, 17, 10, 0, 0, DateTimeKind.Unspecified), 0, "query 16", "FFE95EC4-C3C8-4255-842C-7ECBAF332778" },
                    { "22222222-2222-2222-2222-222222222222", new DateTime(2025, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 0, "beta", "84878F73-0C39-45DD-A61C-DB4AE17BD255" },
                    { "22222222-bbbb-bbbb-bbbb-222222222222", new DateTime(2025, 2, 12, 18, 25, 0, 0, DateTimeKind.Unspecified), 0, "query 17", "FFE95EC4-C3C8-4255-842C-7ECBAF332778" },
                    { "33333333-3333-3333-3333-333333333333", new DateTime(2025, 3, 2, 12, 30, 0, 0, DateTimeKind.Unspecified), 0, "gamma", "84878F73-0C39-45DD-A61C-DB4AE17BD255" },
                    { "33333333-cccc-cccc-cccc-333333333333", new DateTime(2025, 2, 13, 20, 45, 0, 0, DateTimeKind.Unspecified), 0, "query 18", "FFE95EC4-C3C8-4255-842C-7ECBAF332778" },
                    { "44444444-4444-4444-4444-444444444444", new DateTime(2025, 3, 3, 18, 45, 0, 0, DateTimeKind.Unspecified), 0, "delta", "84878F73-0C39-45DD-A61C-DB4AE17BD255" },
                    { "44444444-dddd-dddd-dddd-444444444444", new DateTime(2025, 2, 14, 9, 15, 0, 0, DateTimeKind.Unspecified), 0, "query 19", "FFE95EC4-C3C8-4255-842C-7ECBAF332778" },
                    { "55555555-5555-5555-5555-555555555555", new DateTime(2025, 3, 4, 7, 15, 0, 0, DateTimeKind.Unspecified), 0, "epsilon", "84878F73-0C39-45DD-A61C-DB4AE17BD255" },
                    { "55555555-eeee-eeee-eeee-555555555555", new DateTime(2025, 2, 15, 11, 40, 0, 0, DateTimeKind.Unspecified), 0, "query 20", "FFE95EC4-C3C8-4255-842C-7ECBAF332778" },
                    { "66666666-6666-6666-6666-666666666666", new DateTime(2025, 2, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, "query 6", "FFE95EC4-C3C8-4255-842C-7ECBAF332778" },
                    { "66666666-ffff-ffff-ffff-666666666666", new DateTime(2025, 2, 16, 13, 5, 0, 0, DateTimeKind.Unspecified), 0, "query 21", "FFE95EC4-C3C8-4255-842C-7ECBAF332778" },
                    { "77777777-7777-7777-7777-777777777777", new DateTime(2025, 2, 2, 10, 15, 0, 0, DateTimeKind.Unspecified), 0, "query 7", "FFE95EC4-C3C8-4255-842C-7ECBAF332778" },
                    { "77777777-abcd-abcd-abcd-777777777777", new DateTime(2025, 2, 17, 14, 30, 0, 0, DateTimeKind.Unspecified), 0, "query 22", "FFE95EC4-C3C8-4255-842C-7ECBAF332778" },
                    { "88888888-8888-8888-8888-888888888888", new DateTime(2025, 2, 3, 11, 45, 0, 0, DateTimeKind.Unspecified), 0, "query 8", "FFE95EC4-C3C8-4255-842C-7ECBAF332778" },
                    { "88888888-abcd-abcd-abcd-888888888888", new DateTime(2025, 2, 18, 15, 55, 0, 0, DateTimeKind.Unspecified), 0, "query 23", "FFE95EC4-C3C8-4255-842C-7ECBAF332778" },
                    { "99999999-9999-9999-9999-999999999999", new DateTime(2025, 2, 4, 14, 20, 0, 0, DateTimeKind.Unspecified), 0, "query 9", "FFE95EC4-C3C8-4255-842C-7ECBAF332778" },
                    { "99999999-abcd-abcd-abcd-999999999999", new DateTime(2025, 2, 19, 17, 20, 0, 0, DateTimeKind.Unspecified), 0, "query 24", "FFE95EC4-C3C8-4255-842C-7ECBAF332778" },
                    { "aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa", new DateTime(2025, 2, 5, 16, 40, 0, 0, DateTimeKind.Unspecified), 0, "query 10", "FFE95EC4-C3C8-4255-842C-7ECBAF332778" },
                    { "aaaaaaaa-abcd-abcd-abcd-aaaaaaaaaaaa", new DateTime(2025, 2, 20, 18, 45, 0, 0, DateTimeKind.Unspecified), 0, "query 25", "FFE95EC4-C3C8-4255-842C-7ECBAF332778" },
                    { "bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb", new DateTime(2025, 2, 6, 19, 0, 0, 0, DateTimeKind.Unspecified), 0, "query 11", "FFE95EC4-C3C8-4255-842C-7ECBAF332778" },
                    { "cccccccc-cccc-cccc-cccc-cccccccccccc", new DateTime(2025, 2, 7, 8, 15, 0, 0, DateTimeKind.Unspecified), 0, "query 12", "FFE95EC4-C3C8-4255-842C-7ECBAF332778" },
                    { "dddddddd-dddd-dddd-dddd-dddddddddddd", new DateTime(2025, 2, 8, 12, 25, 0, 0, DateTimeKind.Unspecified), 0, "query 13", "FFE95EC4-C3C8-4255-842C-7ECBAF332778" },
                    { "eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee", new DateTime(2025, 2, 9, 13, 50, 0, 0, DateTimeKind.Unspecified), 0, "query 14", "FFE95EC4-C3C8-4255-842C-7ECBAF332778" },
                    { "ffffffff-ffff-ffff-ffff-ffffffffffff", new DateTime(2025, 2, 10, 15, 30, 0, 0, DateTimeKind.Unspecified), 0, "query 15", "FFE95EC4-C3C8-4255-842C-7ECBAF332778" }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_QueryLogs_UserId_CreatedAtUtc",
                table: "QueryLogs",
                columns: new[] { "UserId", "CreatedAtUtc" });
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
                name: "MyData");

            migrationBuilder.DropTable(
                name: "QueryLogs");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
