using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReaderSharp.Data.Migrations
{
    public partial class AlterTableName220509 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SourceBookInfoRules_BookSource_BookSourceId",
                table: "SourceBookInfoRules");

            migrationBuilder.DropForeignKey(
                name: "FK_SourceCatalogRules_BookSource_BookSourceId",
                table: "SourceCatalogRules");

            migrationBuilder.DropForeignKey(
                name: "FK_SourceContentRules_BookSource_BookSourceId",
                table: "SourceContentRules");

            migrationBuilder.DropForeignKey(
                name: "FK_SourceSearchRules_BookSource_BookSourceId",
                table: "SourceSearchRules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SourceSearchRules",
                table: "SourceSearchRules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SourceContentRules",
                table: "SourceContentRules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SourceCatalogRules",
                table: "SourceCatalogRules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SourceBookInfoRules",
                table: "SourceBookInfoRules");

            migrationBuilder.RenameTable(
                name: "SourceSearchRules",
                newName: "SourceSearchRule");

            migrationBuilder.RenameTable(
                name: "SourceContentRules",
                newName: "SourceContentRule");

            migrationBuilder.RenameTable(
                name: "SourceCatalogRules",
                newName: "SourceCatalogRule");

            migrationBuilder.RenameTable(
                name: "SourceBookInfoRules",
                newName: "SourceBookInfoRule");

            migrationBuilder.RenameIndex(
                name: "IX_SourceSearchRules_BookSourceId",
                table: "SourceSearchRule",
                newName: "IX_SourceSearchRule_BookSourceId");

            migrationBuilder.RenameIndex(
                name: "IX_SourceContentRules_BookSourceId",
                table: "SourceContentRule",
                newName: "IX_SourceContentRule_BookSourceId");

            migrationBuilder.RenameIndex(
                name: "IX_SourceCatalogRules_BookSourceId",
                table: "SourceCatalogRule",
                newName: "IX_SourceCatalogRule_BookSourceId");

            migrationBuilder.RenameIndex(
                name: "IX_SourceBookInfoRules_BookSourceId",
                table: "SourceBookInfoRule",
                newName: "IX_SourceBookInfoRule_BookSourceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SourceSearchRule",
                table: "SourceSearchRule",
                column: "SearchRuleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SourceContentRule",
                table: "SourceContentRule",
                column: "ContentRuleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SourceCatalogRule",
                table: "SourceCatalogRule",
                column: "CatalogRuleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SourceBookInfoRule",
                table: "SourceBookInfoRule",
                column: "BookInfoRuleId");

            migrationBuilder.AddForeignKey(
                name: "FK_SourceBookInfoRule_BookSource_BookSourceId",
                table: "SourceBookInfoRule",
                column: "BookSourceId",
                principalTable: "BookSource",
                principalColumn: "BookSourceId");

            migrationBuilder.AddForeignKey(
                name: "FK_SourceCatalogRule_BookSource_BookSourceId",
                table: "SourceCatalogRule",
                column: "BookSourceId",
                principalTable: "BookSource",
                principalColumn: "BookSourceId");

            migrationBuilder.AddForeignKey(
                name: "FK_SourceContentRule_BookSource_BookSourceId",
                table: "SourceContentRule",
                column: "BookSourceId",
                principalTable: "BookSource",
                principalColumn: "BookSourceId");

            migrationBuilder.AddForeignKey(
                name: "FK_SourceSearchRule_BookSource_BookSourceId",
                table: "SourceSearchRule",
                column: "BookSourceId",
                principalTable: "BookSource",
                principalColumn: "BookSourceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SourceBookInfoRule_BookSource_BookSourceId",
                table: "SourceBookInfoRule");

            migrationBuilder.DropForeignKey(
                name: "FK_SourceCatalogRule_BookSource_BookSourceId",
                table: "SourceCatalogRule");

            migrationBuilder.DropForeignKey(
                name: "FK_SourceContentRule_BookSource_BookSourceId",
                table: "SourceContentRule");

            migrationBuilder.DropForeignKey(
                name: "FK_SourceSearchRule_BookSource_BookSourceId",
                table: "SourceSearchRule");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SourceSearchRule",
                table: "SourceSearchRule");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SourceContentRule",
                table: "SourceContentRule");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SourceCatalogRule",
                table: "SourceCatalogRule");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SourceBookInfoRule",
                table: "SourceBookInfoRule");

            migrationBuilder.RenameTable(
                name: "SourceSearchRule",
                newName: "SourceSearchRules");

            migrationBuilder.RenameTable(
                name: "SourceContentRule",
                newName: "SourceContentRules");

            migrationBuilder.RenameTable(
                name: "SourceCatalogRule",
                newName: "SourceCatalogRules");

            migrationBuilder.RenameTable(
                name: "SourceBookInfoRule",
                newName: "SourceBookInfoRules");

            migrationBuilder.RenameIndex(
                name: "IX_SourceSearchRule_BookSourceId",
                table: "SourceSearchRules",
                newName: "IX_SourceSearchRules_BookSourceId");

            migrationBuilder.RenameIndex(
                name: "IX_SourceContentRule_BookSourceId",
                table: "SourceContentRules",
                newName: "IX_SourceContentRules_BookSourceId");

            migrationBuilder.RenameIndex(
                name: "IX_SourceCatalogRule_BookSourceId",
                table: "SourceCatalogRules",
                newName: "IX_SourceCatalogRules_BookSourceId");

            migrationBuilder.RenameIndex(
                name: "IX_SourceBookInfoRule_BookSourceId",
                table: "SourceBookInfoRules",
                newName: "IX_SourceBookInfoRules_BookSourceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SourceSearchRules",
                table: "SourceSearchRules",
                column: "SearchRuleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SourceContentRules",
                table: "SourceContentRules",
                column: "ContentRuleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SourceCatalogRules",
                table: "SourceCatalogRules",
                column: "CatalogRuleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SourceBookInfoRules",
                table: "SourceBookInfoRules",
                column: "BookInfoRuleId");

            migrationBuilder.AddForeignKey(
                name: "FK_SourceBookInfoRules_BookSource_BookSourceId",
                table: "SourceBookInfoRules",
                column: "BookSourceId",
                principalTable: "BookSource",
                principalColumn: "BookSourceId");

            migrationBuilder.AddForeignKey(
                name: "FK_SourceCatalogRules_BookSource_BookSourceId",
                table: "SourceCatalogRules",
                column: "BookSourceId",
                principalTable: "BookSource",
                principalColumn: "BookSourceId");

            migrationBuilder.AddForeignKey(
                name: "FK_SourceContentRules_BookSource_BookSourceId",
                table: "SourceContentRules",
                column: "BookSourceId",
                principalTable: "BookSource",
                principalColumn: "BookSourceId");

            migrationBuilder.AddForeignKey(
                name: "FK_SourceSearchRules_BookSource_BookSourceId",
                table: "SourceSearchRules",
                column: "BookSourceId",
                principalTable: "BookSource",
                principalColumn: "BookSourceId");
        }
    }
}
