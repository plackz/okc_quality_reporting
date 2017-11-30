using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace okc_quality_reporting.Migrations
{
    public partial class AddedFieldTarget : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Target",
                table: "Movie",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Target",
                table: "Movie");
        }
    }
}
