using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SplitwiseDemo.Migrations
{
    public partial class Create5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "payers",
                columns: table => new
                {
                    payerid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    paid_by = table.Column<int>(nullable: false),
                    amount_paid = table.Column<double>(nullable: false),
                    bill_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payers", x => x.payerid);
                    table.ForeignKey(
                        name: "FK_payers_bills_bill_id",
                        column: x => x.bill_id,
                        principalTable: "bills",
                        principalColumn: "billid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_payers_users_paid_by",
                        column: x => x.paid_by,
                        principalTable: "users",
                        principalColumn: "userid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_payers_bill_id",
                table: "payers",
                column: "bill_id");

            migrationBuilder.CreateIndex(
                name: "IX_payers_paid_by",
                table: "payers",
                column: "paid_by");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "payers");
        }
    }
}
