using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestTaskAionys.Migrations
{
    public partial class editClietnTask : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StartTime",
                table: "ClientTasks",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "EndTime",
                table: "ClientTasks",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<int>(
                name: "ClientsId",
                table: "ClientTasks",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClientTasks_ClientsId",
                table: "ClientTasks",
                column: "ClientsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientTasks_Clientes_ClientsId",
                table: "ClientTasks",
                column: "ClientsId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientTasks_Clientes_ClientsId",
                table: "ClientTasks");

            migrationBuilder.DropIndex(
                name: "IX_ClientTasks_ClientsId",
                table: "ClientTasks");

            migrationBuilder.DropColumn(
                name: "ClientsId",
                table: "ClientTasks");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "ClientTasks",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "ClientTasks",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
