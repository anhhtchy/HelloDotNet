using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HelloDotNet.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Caption = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDefault = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    FileSize = table.Column<decimal>(type: "decimal(65,30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

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
    }
}
