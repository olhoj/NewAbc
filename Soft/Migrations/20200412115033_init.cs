using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Abc.Soft.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MeasureTerms",
                columns: table => new
                {
                    MasterId = table.Column<string>(nullable: false),
                    TermId = table.Column<string>(nullable: false),
                    ValidFrom = table.Column<DateTime>(nullable: true),
                    ValidTo = table.Column<DateTime>(nullable: true),
                    Power = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeasureTerms", x => new { x.MasterId, x.TermId });
                });

            migrationBuilder.CreateTable(
                name: "UnitTerms",
                columns: table => new
                {
                    MasterId = table.Column<string>(nullable: false),
                    TermId = table.Column<string>(nullable: false),
                    ValidFrom = table.Column<DateTime>(nullable: true),
                    ValidTo = table.Column<DateTime>(nullable: true),
                    Power = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitTerms", x => new { x.MasterId, x.TermId });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MeasureTerms");

            migrationBuilder.DropTable(
                name: "UnitTerms");
        }
    }
}
