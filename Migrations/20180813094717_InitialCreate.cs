using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SplitwiseDemo.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "currencies",
                columns: table => new
                {
                    currencyid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    currency_name = table.Column<string>(nullable: true),
                    currency_symbol = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_currencies", x => x.currencyid);
                });

            migrationBuilder.CreateTable(
                name: "languages",
                columns: table => new
                {
                    languageid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    language_name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_languages", x => x.languageid);
                });

            migrationBuilder.CreateTable(
                name: "timezones",
                columns: table => new
                {
                    timezoneid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    timezone_name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_timezones", x => x.timezoneid);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    userid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    user_name = table.Column<string>(nullable: true),
                    email_id = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    phone_no = table.Column<string>(nullable: true),
                    profile_pic = table.Column<byte[]>(nullable: true),
                    currencyid = table.Column<int>(nullable: true),
                    timezoneid = table.Column<int>(nullable: true),
                    languageid = table.Column<int>(nullable: true),
                    created_on = table.Column<DateTime>(nullable: false),
                    updated_on = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.userid);
                    table.ForeignKey(
                        name: "FK_users_currencies_currencyid",
                        column: x => x.currencyid,
                        principalTable: "currencies",
                        principalColumn: "currencyid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_users_languages_languageid",
                        column: x => x.languageid,
                        principalTable: "languages",
                        principalColumn: "languageid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_users_timezones_timezoneid",
                        column: x => x.timezoneid,
                        principalTable: "timezones",
                        principalColumn: "timezoneid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "groups",
                columns: table => new
                {
                    groupid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    group_name = table.Column<string>(nullable: true),
                    group_created_on = table.Column<DateTime>(nullable: false),
                    group_created_by = table.Column<int>(nullable: false),
                    is_simplified_depts = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_groups", x => x.groupid);
                    table.ForeignKey(
                        name: "FK_groups_users_group_created_by",
                        column: x => x.group_created_by,
                        principalTable: "users",
                        principalColumn: "userid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "bills",
                columns: table => new
                {
                    billid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(nullable: true),
                    total_amount = table.Column<double>(nullable: false),
                    bill_created_by_id = table.Column<int>(nullable: false),
                    bill_updated_by = table.Column<int>(nullable: false),
                    bill_created_at = table.Column<DateTime>(nullable: false),
                    bill_updated_at = table.Column<DateTime>(nullable: false),
                    groupid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bills", x => x.billid);
                    table.ForeignKey(
                        name: "FK_bills_users_bill_created_by_id",
                        column: x => x.bill_created_by_id,
                        principalTable: "users",
                        principalColumn: "userid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bills_groups_groupid",
                        column: x => x.groupid,
                        principalTable: "groups",
                        principalColumn: "groupid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "groupmembers",
                columns: table => new
                {
                    memberid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    userid = table.Column<int>(nullable: true),
                    groupid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_groupmembers", x => x.memberid);
                    table.ForeignKey(
                        name: "FK_groupmembers_groups_groupid",
                        column: x => x.groupid,
                        principalTable: "groups",
                        principalColumn: "groupid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_groupmembers_users_userid",
                        column: x => x.userid,
                        principalTable: "users",
                        principalColumn: "userid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_bills_bill_created_by_id",
                table: "bills",
                column: "bill_created_by_id");

            migrationBuilder.CreateIndex(
                name: "IX_bills_groupid",
                table: "bills",
                column: "groupid");

            migrationBuilder.CreateIndex(
                name: "IX_groupmembers_groupid",
                table: "groupmembers",
                column: "groupid");

            migrationBuilder.CreateIndex(
                name: "IX_groupmembers_userid",
                table: "groupmembers",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "IX_groups_group_created_by",
                table: "groups",
                column: "group_created_by");

            migrationBuilder.CreateIndex(
                name: "IX_users_currencyid",
                table: "users",
                column: "currencyid");

            migrationBuilder.CreateIndex(
                name: "IX_users_languageid",
                table: "users",
                column: "languageid");

            migrationBuilder.CreateIndex(
                name: "IX_users_timezoneid",
                table: "users",
                column: "timezoneid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bills");

            migrationBuilder.DropTable(
                name: "groupmembers");

            migrationBuilder.DropTable(
                name: "groups");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "currencies");

            migrationBuilder.DropTable(
                name: "languages");

            migrationBuilder.DropTable(
                name: "timezones");
        }
    }
}
