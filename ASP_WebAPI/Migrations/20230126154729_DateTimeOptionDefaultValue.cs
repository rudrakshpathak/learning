using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP_WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class DateTimeOptionDefaultValue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTimestamp",
                value: new DateTime(2023, 1, 26, 21, 17, 29, 648, DateTimeKind.Local).AddTicks(5674));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTimestamp",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
