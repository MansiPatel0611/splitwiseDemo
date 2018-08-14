using Microsoft.EntityFrameworkCore.Migrations;

namespace SplitwiseDemo.Migrations
{
    public partial class Create3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bill_created_by_id",
                table: "bills");

            migrationBuilder.DropColumn(
                name: "bill_updated_by_id",
                table: "bills");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "bill_created_by_id",
                table: "bills",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "bill_updated_by_id",
                table: "bills",
                nullable: false,
                defaultValue: 0);
        }
    }
}
