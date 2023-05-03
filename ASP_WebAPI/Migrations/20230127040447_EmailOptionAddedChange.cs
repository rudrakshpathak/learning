using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class EmailOptionAddedChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "User",
                type: "longtext",
                nullable: false);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "Email" },
                values: new object[] { new DateTime(2023, 1, 27, 9, 34, 47, 414, DateTimeKind.Local).AddTicks(5048), "som" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "User");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTimestamp",
                value: new DateTime(2023, 1, 27, 9, 30, 25, 873, DateTimeKind.Local).AddTicks(7581));
        }
    }
}
