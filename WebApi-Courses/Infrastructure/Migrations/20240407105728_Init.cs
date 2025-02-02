﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OriginalPrice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscountedPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hours = table.Column<int>(type: "int", nullable: false),
                    LikesInProcent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberofLikes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDigital = table.Column<bool>(type: "bit", nullable: false),
                    IsBestseller = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BigImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    learn1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    learn2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    learn3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    learn4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    learn5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    programdetails1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    programdetails2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    programdetails3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    programdetails4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    programdetails5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    programdetails6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CategoryId",
                table: "Courses",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
