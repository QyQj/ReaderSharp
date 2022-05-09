using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReaderSharp.Data.Migrations
{
    public partial class AlterBookSource220509 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CatalogUrl",
                table: "SourceBookInfoRules",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WordCount",
                table: "SourceBookInfoRules",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BookSourceNote",
                table: "BookSource",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CatalogUrl",
                table: "SourceBookInfoRules");

            migrationBuilder.DropColumn(
                name: "WordCount",
                table: "SourceBookInfoRules");

            migrationBuilder.DropColumn(
                name: "BookSourceNote",
                table: "BookSource");
        }
    }
}
