using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SplitwiseDemo.Migrations
{
    public partial class Create6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sharedwiths",
                columns: table => new
                {
                    sharedid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    shared_withuserid = table.Column<int>(nullable: true),
                    owes_amount = table.Column<double>(nullable: false),
                    bill_id = table.Column<int>(nullable: false),
                    owes_touserid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sharedwiths", x => x.sharedid);
                    table.ForeignKey(
                        name: "FK_sharedwiths_bills_bill_id",
                        column: x => x.bill_id,
                        principalTable: "bills",
                        principalColumn: "billid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sharedwiths_users_owes_touserid",
                        column: x => x.owes_touserid,
                        principalTable: "users",
                        principalColumn: "userid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_sharedwiths_users_shared_withuserid",
                        column: x => x.shared_withuserid,
                        principalTable: "users",
                        principalColumn: "userid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_sharedwiths_bill_id",
                table: "sharedwiths",
                column: "bill_id");

            migrationBuilder.CreateIndex(
                name: "IX_sharedwiths_owes_touserid",
                table: "sharedwiths",
                column: "owes_touserid");

            migrationBuilder.CreateIndex(
                name: "IX_sharedwiths_shared_withuserid",
                table: "sharedwiths",
                column: "shared_withuserid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sharedwiths");
        }
    }
}
