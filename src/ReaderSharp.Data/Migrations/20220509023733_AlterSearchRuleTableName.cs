using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReaderSharp.Data.Migrations
{
    public partial class AlterSearchRuleTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SourceSearchRule_BookSource_BookSourceId",
                table: "SourceSearchRule");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SourceSearchRule",
                table: "SourceSearchRule");

            migrationBuilder.RenameTable(
                name: "SourceSearchRule",
                newName: "SourceSearchRules");

            migrationBuilder.RenameIndex(
                name: "IX_SourceSearchRule_BookSourceId",
                table: "SourceSearchRules",
                newName: "IX_SourceSearchRules_BookSourceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SourceSearchRules",
                table: "SourceSearchRules",
                column: "SearchRuleId");

            migrationBuilder.AddForeignKey(
                name: "FK_SourceSearchRules_BookSource_BookSourceId",
                table: "SourceSearchRules",
                column: "BookSourceId",
                principalTable: "BookSource",
                principalColumn: "BookSourceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SourceSearchRules_BookSource_BookSourceId",
                table: "SourceSearchRules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SourceSearchRules",
                table: "SourceSearchRules");

            migrationBuilder.RenameTable(
                name: "SourceSearchRules",
                newName: "SourceSearchRule");

            migrationBuilder.RenameIndex(
                name: "IX_SourceSearchRules_BookSourceId",
                table: "SourceSearchRule",
                newName: "IX_SourceSearchRule_BookSourceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SourceSearchRule",
                table: "SourceSearchRule",
                column: "SearchRuleId");

            migrationBuilder.AddForeignKey(
                name: "FK_SourceSearchRule_BookSource_BookSourceId",
                table: "SourceSearchRule",
                column: "BookSourceId",
                principalTable: "BookSource",
                principalColumn: "BookSourceId");
        }
    }
}
