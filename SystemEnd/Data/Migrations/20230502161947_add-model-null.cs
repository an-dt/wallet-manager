﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SystemEnd.Data.Migrations
{
    public partial class addmodelnull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Categories_CategoryId",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInfors_AspNetUsers_UserId",
                table: "UserInfors");

            migrationBuilder.DropForeignKey(
                name: "FK_Wallets_AspNetUsers_UserId",
                table: "Wallets");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Wallets",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Wallets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserInfors",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "UserInfors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "UserInfors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Transactions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Categories_CategoryId",
                table: "Transactions",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserInfors_AspNetUsers_UserId",
                table: "UserInfors",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Wallets_AspNetUsers_UserId",
                table: "Wallets",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Categories_CategoryId",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInfors_AspNetUsers_UserId",
                table: "UserInfors");

            migrationBuilder.DropForeignKey(
                name: "FK_Wallets_AspNetUsers_UserId",
                table: "Wallets");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Wallets",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Wallets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserInfors",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "UserInfors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "UserInfors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Transactions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Categories_CategoryId",
                table: "Transactions",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserInfors_AspNetUsers_UserId",
                table: "UserInfors",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wallets_AspNetUsers_UserId",
                table: "Wallets",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
