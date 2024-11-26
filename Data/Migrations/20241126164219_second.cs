using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "OrderDboId",
                table: "produts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_produts_OrderDboId",
                table: "produts",
                column: "OrderDboId");

            migrationBuilder.AddForeignKey(
                name: "FK_produts_orders_OrderDboId",
                table: "produts",
                column: "OrderDboId",
                principalTable: "orders",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_produts_orders_OrderDboId",
                table: "produts");

            migrationBuilder.DropIndex(
                name: "IX_produts_OrderDboId",
                table: "produts");

            migrationBuilder.DropColumn(
                name: "OrderDboId",
                table: "produts");
        }
    }
}
