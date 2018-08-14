using Microsoft.EntityFrameworkCore.Migrations;

namespace SplitwiseDemo.Migrations
{
    public partial class Create2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bills_users_bill_created_by_id",
                table: "bills");

            migrationBuilder.DropIndex(
                name: "IX_bills_bill_created_by_id",
                table: "bills");

            migrationBuilder.RenameColumn(
                name: "bill_updated_by",
                table: "bills",
                newName: "bill_updated_by_id");

            migrationBuilder.AddColumn<int>(
                name: "bill_created_byuserid",
                table: "bills",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "bill_updated_byuserid",
                table: "bills",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_bills_bill_created_byuserid",
                table: "bills",
                column: "bill_created_byuserid");

            migrationBuilder.CreateIndex(
                name: "IX_bills_bill_updated_byuserid",
                table: "bills",
                column: "bill_updated_byuserid");

            migrationBuilder.AddForeignKey(
                name: "FK_bills_users_bill_created_byuserid",
                table: "bills",
                column: "bill_created_byuserid",
                principalTable: "users",
                principalColumn: "userid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_bills_users_bill_updated_byuserid",
                table: "bills",
                column: "bill_updated_byuserid",
                principalTable: "users",
                principalColumn: "userid",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bills_users_bill_created_byuserid",
                table: "bills");

            migrationBuilder.DropForeignKey(
                name: "FK_bills_users_bill_updated_byuserid",
                table: "bills");

            migrationBuilder.DropIndex(
                name: "IX_bills_bill_created_byuserid",
                table: "bills");

            migrationBuilder.DropIndex(
                name: "IX_bills_bill_updated_byuserid",
                table: "bills");

            migrationBuilder.DropColumn(
                name: "bill_created_byuserid",
                table: "bills");

            migrationBuilder.DropColumn(
                name: "bill_updated_byuserid",
                table: "bills");

            migrationBuilder.RenameColumn(
                name: "bill_updated_by_id",
                table: "bills",
                newName: "bill_updated_by");

            migrationBuilder.CreateIndex(
                name: "IX_bills_bill_created_by_id",
                table: "bills",
                column: "bill_created_by_id");

            migrationBuilder.AddForeignKey(
                name: "FK_bills_users_bill_created_by_id",
                table: "bills",
                column: "bill_created_by_id",
                principalTable: "users",
                principalColumn: "userid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
