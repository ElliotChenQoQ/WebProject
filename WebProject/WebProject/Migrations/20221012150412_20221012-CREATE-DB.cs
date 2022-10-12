using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProject.Migrations
{
    public partial class _20221012CREATEDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "STATION_INFO",
                columns: table => new
                {
                    SI_SN = table.Column<long>(type: "BIGINT", nullable: false, comment: "PK, 自動流水號")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    STATION_CODE = table.Column<string>(type: "VARCHAR(20)", nullable: true, comment: "測站代號"),
                    CITY = table.Column<string>(type: "VARCHAR(20)", nullable: true, comment: "城市"),
                    STATION_NAME = table.Column<string>(type: "VARCHAR(20)", nullable: true, comment: "測站名稱")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STATION_INFO", x => x.SI_SN);
                });

            migrationBuilder.CreateTable(
                name: "UVI_DATA",
                columns: table => new
                {
                    UD_SN = table.Column<long>(type: "BIGINT", nullable: false, comment: "PK, 自動流水號")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    STATION_CODE = table.Column<string>(type: "VARCHAR(20)", nullable: true, comment: "測站代號"),
                    UVI_VALUE = table.Column<decimal>(type: "DECIMAL(18, 12)", nullable: true, comment: "紫外線指數最大值"),
                    OBSERVATION_DTM = table.Column<string>(type: "VARCHAR(20)", nullable: true, comment: "觀測時間"),
                    CREATE_USER = table.Column<string>(type: "NVARCHAR(20)", nullable: true, comment: "建立者"),
                    CREATE_DTM = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "GETDATE()", comment: "建立時間")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UVI_DATA", x => x.UD_SN);
                });

            migrationBuilder.CreateIndex(
                name: "IX_STATION_INFO_SI_SN",
                table: "STATION_INFO",
                column: "SI_SN")
                .Annotation("SqlServer:Clustered", false);

            migrationBuilder.CreateIndex(
                name: "IX_UVI_DATA_UD_SN",
                table: "UVI_DATA",
                column: "UD_SN")
                .Annotation("SqlServer:Clustered", false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "STATION_INFO");

            migrationBuilder.DropTable(
                name: "UVI_DATA");
        }
    }
}
