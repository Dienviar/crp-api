using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace crp_api.Migrations
{
    public partial class crp2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CREATED_BY",
                schema: "crp",
                table: "USERS",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DATE_CREATED",
                schema: "crp",
                table: "USERS",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DATE_UPDATED",
                schema: "crp",
                table: "USERS",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IS_ACTIVE",
                schema: "crp",
                table: "USERS",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ROLE_ID",
                schema: "crp",
                table: "USERS",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UPDATED_BY",
                schema: "crp",
                table: "USERS",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CREATED_BY",
                schema: "crp",
                table: "REPORTTYPES",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DATE_CREATED",
                schema: "crp",
                table: "REPORTTYPES",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DATE_UPDATED",
                schema: "crp",
                table: "REPORTTYPES",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DESCRIPTION",
                schema: "crp",
                table: "REPORTTYPES",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IS_ACTIVE",
                schema: "crp",
                table: "REPORTTYPES",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UPDATED_BY",
                schema: "crp",
                table: "REPORTTYPES",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CREATED_BY",
                schema: "crp",
                table: "REPORTSTATUSES",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DATE_CREATED",
                schema: "crp",
                table: "REPORTSTATUSES",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DATE_UPDATED",
                schema: "crp",
                table: "REPORTSTATUSES",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DESCRIPTION",
                schema: "crp",
                table: "REPORTSTATUSES",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IS_ACTIVE",
                schema: "crp",
                table: "REPORTSTATUSES",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UPDATED_BY",
                schema: "crp",
                table: "REPORTSTATUSES",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CREATED_BY",
                schema: "crp",
                table: "REPORTS",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DATE_COMPLETED",
                schema: "crp",
                table: "REPORTS",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DATE_CREATED",
                schema: "crp",
                table: "REPORTS",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DATE_FILLED",
                schema: "crp",
                table: "REPORTS",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DATE_UPDATED",
                schema: "crp",
                table: "REPORTS",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IS_ACTIVE",
                schema: "crp",
                table: "REPORTS",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UPDATED_BY",
                schema: "crp",
                table: "REPORTS",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CREATED_BY",
                schema: "crp",
                table: "REPORTLOGS",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DATE_CREATED",
                schema: "crp",
                table: "REPORTLOGS",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DATE_UPDATED",
                schema: "crp",
                table: "REPORTLOGS",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IS_ACTIVE",
                schema: "crp",
                table: "REPORTLOGS",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UPDATED_BY",
                schema: "crp",
                table: "REPORTLOGS",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "crp_apiRole",
                schema: "crp",
                columns: table => new
                {
                    ROLE_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newsequentialid()"),
                    TITLE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DATE_CREATED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATED_BY = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DATE_UPDATED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPDATED_BY = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IS_ACTIVE = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_crp_apiRole", x => x.ROLE_ID);
                });

            migrationBuilder.CreateTable(
                name: "Proof",
                schema: "crp",
                columns: table => new
                {
                    PROOF_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newsequentialid()"),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REMARKS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DATE_CREATED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CREATED_BY = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DATE_UPDATED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPDATED_BY = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IS_ACTIVE = table.Column<bool>(type: "bit", nullable: true),
                    REPORT_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proof", x => x.PROOF_ID);
                    table.ForeignKey(
                        name: "FK_Proof_REPORTS_REPORT_ID",
                        column: x => x.REPORT_ID,
                        principalSchema: "crp",
                        principalTable: "REPORTS",
                        principalColumn: "REPORT_ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_USERS_ROLE_ID",
                schema: "crp",
                table: "USERS",
                column: "ROLE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Proof_REPORT_ID",
                schema: "crp",
                table: "Proof",
                column: "REPORT_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_USERS_crp_apiRole_ROLE_ID",
                schema: "crp",
                table: "USERS",
                column: "ROLE_ID",
                principalSchema: "crp",
                principalTable: "crp_apiRole",
                principalColumn: "ROLE_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_USERS_crp_apiRole_ROLE_ID",
                schema: "crp",
                table: "USERS");

            migrationBuilder.DropTable(
                name: "crp_apiRole",
                schema: "crp");

            migrationBuilder.DropTable(
                name: "Proof",
                schema: "crp");

            migrationBuilder.DropIndex(
                name: "IX_USERS_ROLE_ID",
                schema: "crp",
                table: "USERS");

            migrationBuilder.DropColumn(
                name: "CREATED_BY",
                schema: "crp",
                table: "USERS");

            migrationBuilder.DropColumn(
                name: "DATE_CREATED",
                schema: "crp",
                table: "USERS");

            migrationBuilder.DropColumn(
                name: "DATE_UPDATED",
                schema: "crp",
                table: "USERS");

            migrationBuilder.DropColumn(
                name: "IS_ACTIVE",
                schema: "crp",
                table: "USERS");

            migrationBuilder.DropColumn(
                name: "ROLE_ID",
                schema: "crp",
                table: "USERS");

            migrationBuilder.DropColumn(
                name: "UPDATED_BY",
                schema: "crp",
                table: "USERS");

            migrationBuilder.DropColumn(
                name: "CREATED_BY",
                schema: "crp",
                table: "REPORTTYPES");

            migrationBuilder.DropColumn(
                name: "DATE_CREATED",
                schema: "crp",
                table: "REPORTTYPES");

            migrationBuilder.DropColumn(
                name: "DATE_UPDATED",
                schema: "crp",
                table: "REPORTTYPES");

            migrationBuilder.DropColumn(
                name: "DESCRIPTION",
                schema: "crp",
                table: "REPORTTYPES");

            migrationBuilder.DropColumn(
                name: "IS_ACTIVE",
                schema: "crp",
                table: "REPORTTYPES");

            migrationBuilder.DropColumn(
                name: "UPDATED_BY",
                schema: "crp",
                table: "REPORTTYPES");

            migrationBuilder.DropColumn(
                name: "CREATED_BY",
                schema: "crp",
                table: "REPORTSTATUSES");

            migrationBuilder.DropColumn(
                name: "DATE_CREATED",
                schema: "crp",
                table: "REPORTSTATUSES");

            migrationBuilder.DropColumn(
                name: "DATE_UPDATED",
                schema: "crp",
                table: "REPORTSTATUSES");

            migrationBuilder.DropColumn(
                name: "DESCRIPTION",
                schema: "crp",
                table: "REPORTSTATUSES");

            migrationBuilder.DropColumn(
                name: "IS_ACTIVE",
                schema: "crp",
                table: "REPORTSTATUSES");

            migrationBuilder.DropColumn(
                name: "UPDATED_BY",
                schema: "crp",
                table: "REPORTSTATUSES");

            migrationBuilder.DropColumn(
                name: "CREATED_BY",
                schema: "crp",
                table: "REPORTS");

            migrationBuilder.DropColumn(
                name: "DATE_COMPLETED",
                schema: "crp",
                table: "REPORTS");

            migrationBuilder.DropColumn(
                name: "DATE_CREATED",
                schema: "crp",
                table: "REPORTS");

            migrationBuilder.DropColumn(
                name: "DATE_FILLED",
                schema: "crp",
                table: "REPORTS");

            migrationBuilder.DropColumn(
                name: "DATE_UPDATED",
                schema: "crp",
                table: "REPORTS");

            migrationBuilder.DropColumn(
                name: "IS_ACTIVE",
                schema: "crp",
                table: "REPORTS");

            migrationBuilder.DropColumn(
                name: "UPDATED_BY",
                schema: "crp",
                table: "REPORTS");

            migrationBuilder.DropColumn(
                name: "CREATED_BY",
                schema: "crp",
                table: "REPORTLOGS");

            migrationBuilder.DropColumn(
                name: "DATE_CREATED",
                schema: "crp",
                table: "REPORTLOGS");

            migrationBuilder.DropColumn(
                name: "DATE_UPDATED",
                schema: "crp",
                table: "REPORTLOGS");

            migrationBuilder.DropColumn(
                name: "IS_ACTIVE",
                schema: "crp",
                table: "REPORTLOGS");

            migrationBuilder.DropColumn(
                name: "UPDATED_BY",
                schema: "crp",
                table: "REPORTLOGS");
        }
    }
}
