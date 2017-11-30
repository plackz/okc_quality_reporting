using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace okc_quality_reporting.Migrations
{
    public partial class ChangeTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Movie",
                table: "Movie");

            migrationBuilder.RenameTable(
                name: "Movie",
                newName: "ReportData");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReportData",
                table: "ReportData",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ReportData",
                table: "ReportData");

            migrationBuilder.RenameTable(
                name: "ReportData",
                newName: "Movie");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movie",
                table: "Movie",
                column: "Id");
        }
    }
}
