using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ims.Data.Migrations
{
    public partial class addedViewOrderInfotable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VwOrderInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    OrderNo = table.Column<string>(nullable: true),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    CustomerName = table.Column<string>(nullable: true),
                    TotalPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VwOrderInfos");
        }
    }
}
