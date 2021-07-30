using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HelloDotNet.Data.Migrations
{
    public partial class UpdateDefaultValueSqlDatetime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("058ae154-3e2b-4c0d-9380-50c4d929b8e2"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("058ae154-3e2b-4c0d-9380-50c4d929b8e2"), new Guid("c30d9f5e-05e3-49d9-80cb-d02741465e5f") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("c30d9f5e-05e3-49d9-80cb-d02741465e5f"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime(6)",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP(6)",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2021, 7, 28, 20, 20, 13, 18, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("ef8f6404-3489-4b30-8032-0a3e0407e96b"), "63fb337b-815d-4f67-a4d7-200f35893995", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("ef8f6404-3489-4b30-8032-0a3e0407e96b"), new Guid("20eb6e8b-21c5-4a47-bc05-213be61b6485") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("20eb6e8b-21c5-4a47-bc05-213be61b6485"), 0, "aceeb30a-78ab-4fdd-8c44-a8213eca160c", new DateTime(1999, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "anhhtchy@gmail.com", true, "The-Anh", "Hoang", false, null, "anhhtchy@gmail.com", "admin", "AQAAAAEAACcQAAAAEHjWvWfd7rDlyNg2HJt+9orpNSP2GeSWLioq20Vcjtt4vXoCCq7GYLeiqyHG0E9JYQ==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 29, 15, 53, 19, 13, DateTimeKind.Local).AddTicks(9820));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ef8f6404-3489-4b30-8032-0a3e0407e96b"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("ef8f6404-3489-4b30-8032-0a3e0407e96b"), new Guid("20eb6e8b-21c5-4a47-bc05-213be61b6485") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("20eb6e8b-21c5-4a47-bc05-213be61b6485"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 20, 20, 13, 18, DateTimeKind.Local).AddTicks(3280),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValueSql: "CURRENT_TIMESTAMP(6)");

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("058ae154-3e2b-4c0d-9380-50c4d929b8e2"), "3a06f476-4c34-4d85-ad35-31e7bf5f5601", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("058ae154-3e2b-4c0d-9380-50c4d929b8e2"), new Guid("c30d9f5e-05e3-49d9-80cb-d02741465e5f") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("c30d9f5e-05e3-49d9-80cb-d02741465e5f"), 0, "a9a6f5d7-5e66-40e4-bbc5-ca5ee18d6eef", new DateTime(1999, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "anhhtchy@gmail.com", true, "The-Anh", "Hoang", false, null, "anhhtchy@gmail.com", "admin", "AQAAAAEAACcQAAAAEBMENaZjjkFtyie3fEm1zc0qHm5dq9JyZ69f3antuuFDpNPIKLPfIBXYK4N57jh9kA==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 28, 20, 20, 13, 45, DateTimeKind.Local).AddTicks(5230));
        }
    }
}
