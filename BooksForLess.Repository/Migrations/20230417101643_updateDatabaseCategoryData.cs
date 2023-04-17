﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BooksForLess.Repository.Migrations
{
    /// <inheritdoc />
    public partial class updateDatabaseCategoryData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DisplayOrder",
                value: "2");

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DisplayOrder",
                value: "3");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DisplayOrder",
                value: "1");

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DisplayOrder",
                value: "1");
        }
    }
}
