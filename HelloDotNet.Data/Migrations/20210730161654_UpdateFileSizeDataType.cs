using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HelloDotNet.Data.Migrations
{
    public partial class UpdateFileSizeDataType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("b3a64a07-6100-4865-9766-823ed5a2afa9"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b3a64a07-6100-4865-9766-823ed5a2afa9"), new Guid("ddaa8c2d-5596-42d9-8b8f-4cefc474c39c") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ddaa8c2d-5596-42d9-8b8f-4cefc474c39c"));

            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("964e0f3d-31c0-434d-8469-d8758ae38fcf"), "f3208ac3-13b3-46d8-a083-cc3ec0ac8732", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("964e0f3d-31c0-434d-8469-d8758ae38fcf"), new Guid("52bc5c9a-95a2-4c8e-aae0-02e157be5800") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("52bc5c9a-95a2-4c8e-aae0-02e157be5800"), 0, "d14cf914-e8c6-4c80-ab08-5ac04c1d4ff7", new DateTime(1999, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "anhhtchy@gmail.com", true, "The-Anh", "Hoang", false, null, "anhhtchy@gmail.com", "admin", "AQAAAAEAACcQAAAAENWSd+pMH24u+FLRhcY8zRkgpqYZlHibLBIPbzhwosSDAdLw/mYbaHn1XY7fNMH5aw==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 30, 23, 16, 53, 338, DateTimeKind.Local).AddTicks(6450));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("964e0f3d-31c0-434d-8469-d8758ae38fcf"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("964e0f3d-31c0-434d-8469-d8758ae38fcf"), new Guid("52bc5c9a-95a2-4c8e-aae0-02e157be5800") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("52bc5c9a-95a2-4c8e-aae0-02e157be5800"));

            migrationBuilder.AlterColumn<decimal>(
                name: "FileSize",
                table: "ProductImages",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("b3a64a07-6100-4865-9766-823ed5a2afa9"), "ebaf0b6f-fe27-4720-bf78-4fdea168bd91", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("b3a64a07-6100-4865-9766-823ed5a2afa9"), new Guid("ddaa8c2d-5596-42d9-8b8f-4cefc474c39c") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("ddaa8c2d-5596-42d9-8b8f-4cefc474c39c"), 0, "cebdfa86-387d-4389-b070-7c8bf7ab048c", new DateTime(1999, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "anhhtchy@gmail.com", true, "The-Anh", "Hoang", false, null, "anhhtchy@gmail.com", "admin", "AQAAAAEAACcQAAAAEFCWa0DkzbxXZnJ/JUPxMXjvlO/sLvbjOWtimIPO7i7YdMcpsiQ+UUXsr5c9wnbYRQ==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 7, 29, 22, 58, 58, 255, DateTimeKind.Local).AddTicks(6490));
        }
    }
}
