using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace crp_api.Migrations
{
    public partial class crp1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "crp");

            migrationBuilder.CreateTable(
                name: "REPORTSTATUSES",
                schema: "crp",
                columns: table => new
                {
                    REPORTSTATUS_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newsequentialid()"),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_REPORTSTATUSES", x => x.REPORTSTATUS_ID);
                });

            migrationBuilder.CreateTable(
                name: "REPORTTYPES",
                schema: "crp",
                columns: table => new
                {
                    REPORTTYPE_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newsequentialid()"),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_REPORTTYPES", x => x.REPORTTYPE_ID);
                });

            migrationBuilder.CreateTable(
                name: "USERS",
                schema: "crp",
                columns: table => new
                {
                    USER_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newsequentialid()"),
                    FNAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LNAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMAIL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USERS", x => x.USER_ID);
                });

            migrationBuilder.CreateTable(
                name: "REPORTS",
                schema: "crp",
                columns: table => new
                {
                    REPORT_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newsequentialid()"),
                    TITLE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BODY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REPORTTYPE_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    USER_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    REPORTSTATUS_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_REPORTS", x => x.REPORT_ID);
                    table.ForeignKey(
                        name: "FK_REPORTS_REPORTSTATUSES_REPORTSTATUS_ID",
                        column: x => x.REPORTSTATUS_ID,
                        principalSchema: "crp",
                        principalTable: "REPORTSTATUSES",
                        principalColumn: "REPORTSTATUS_ID");
                    table.ForeignKey(
                        name: "FK_REPORTS_REPORTTYPES_REPORTTYPE_ID",
                        column: x => x.REPORTTYPE_ID,
                        principalSchema: "crp",
                        principalTable: "REPORTTYPES",
                        principalColumn: "REPORTTYPE_ID");
                    table.ForeignKey(
                        name: "FK_REPORTS_USERS_USER_ID",
                        column: x => x.USER_ID,
                        principalSchema: "crp",
                        principalTable: "USERS",
                        principalColumn: "USER_ID");
                });

            migrationBuilder.CreateTable(
                name: "REPORTLOGS",
                schema: "crp",
                columns: table => new
                {
                    REPORTLOG_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newsequentialid()"),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REPORT_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_REPORTLOGS", x => x.REPORTLOG_ID);
                    table.ForeignKey(
                        name: "FK_REPORTLOGS_REPORTS_REPORT_ID",
                        column: x => x.REPORT_ID,
                        principalSchema: "crp",
                        principalTable: "REPORTS",
                        principalColumn: "REPORT_ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_REPORTLOGS_REPORT_ID",
                schema: "crp",
                table: "REPORTLOGS",
                column: "REPORT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_REPORTS_REPORTSTATUS_ID",
                schema: "crp",
                table: "REPORTS",
                column: "REPORTSTATUS_ID");

            migrationBuilder.CreateIndex(
                name: "IX_REPORTS_REPORTTYPE_ID",
                schema: "crp",
                table: "REPORTS",
                column: "REPORTTYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_REPORTS_USER_ID",
                schema: "crp",
                table: "REPORTS",
                column: "USER_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "REPORTLOGS",
                schema: "crp");

            migrationBuilder.DropTable(
                name: "REPORTS",
                schema: "crp");

            migrationBuilder.DropTable(
                name: "REPORTSTATUSES",
                schema: "crp");

            migrationBuilder.DropTable(
                name: "REPORTTYPES",
                schema: "crp");

            migrationBuilder.DropTable(
                name: "USERS",
                schema: "crp");
        }
    }
}
