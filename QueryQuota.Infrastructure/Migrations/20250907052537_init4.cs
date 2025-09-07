using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QueryQuota.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "f82509e1-a494-4937-9e41-5dd23c85d3c7", "AQAAAAIAAYagAAAAEP9nZBCm6tsn2WcU/f7qLzPyAEQ99j+F3da25zLAUXz/inO0sNDJhyKnqukWHLXMPA==", "02c059f1-769f-47ed-ad59-4ba354bdf8ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FFE95EC4-C3C8-4255-842C-7ECBAF332778",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7d5361a-93af-4030-bad9-b56fb6d311a0", "AQAAAAIAAYagAAAAEHJvFdn+vK1bHVRWMAhW/q3HG2vM+ZhgEmdsA+Ed4H5N/oOkBxeOgvIKaKrxy0Ugcg==", "867ed95d-d705-4be8-b9f9-fe4c24549bc3" });

            migrationBuilder.CreateIndex(
                name: "IX_QueryLogs_UserId_CreatedAtUtc",
                table: "QueryLogs",
                columns: new[] { "UserId", "CreatedAtUtc" });

            migrationBuilder.AddForeignKey(
                name: "FK_QueryLogs_AspNetUsers_UserId",
                table: "QueryLogs",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QueryLogs_AspNetUsers_UserId",
                table: "QueryLogs");

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
        }
    }
}
