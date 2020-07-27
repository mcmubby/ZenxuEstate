﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Zenxu.Data.Migrations.ApplicationDb
{
    public partial class UpdatedPropertyEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Properties",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContantPhoneNumber",
                table: "Properties",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Properties",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Properties",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfBaths",
                table: "Properties",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfRooms",
                table: "Properties",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfToilets",
                table: "Properties",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Properties",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "ContantPhoneNumber",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "NumberOfBaths",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "NumberOfRooms",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "NumberOfToilets",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Properties");
        }
    }
}
