using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SplitwiseDemo.Migrations
{
    public partial class Create7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "bill_date",
                table: "bills",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "settelments",
                columns: table => new
                {
                    settelmentid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    payeruserid = table.Column<int>(nullable: true),
                    payeeuserid = table.Column<int>(nullable: true),
                    paid_amount = table.Column<double>(nullable: false),
                    paid_on = table.Column<DateTime>(nullable: false),
                    bill_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_settelments", x => x.settelmentid);
                    table.ForeignKey(
                        name: "FK_settelments_bills_bill_id",
                        column: x => x.bill_id,
                        principalTable: "bills",
                        principalColumn: "billid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_settelments_users_payeeuserid",
                        column: x => x.payeeuserid,
                        principalTable: "users",
                        principalColumn: "userid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_settelments_users_payeruserid",
                        column: x => x.payeruserid,
                        principalTable: "users",
                        principalColumn: "userid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_settelments_bill_id",
                table: "settelments",
                column: "bill_id");

            migrationBuilder.CreateIndex(
                name: "IX_settelments_payeeuserid",
                table: "settelments",
                column: "payeeuserid");

            migrationBuilder.CreateIndex(
                name: "IX_settelments_payeruserid",
                table: "settelments",
                column: "payeruserid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "settelments");

            migrationBuilder.DropColumn(
                name: "bill_date",
                table: "bills");
        }
    }
}
