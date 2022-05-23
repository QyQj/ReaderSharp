using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReaderSharp.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    BookId = table.Column<string>(type: "TEXT", nullable: false),
                    BookName = table.Column<string>(type: "TEXT", nullable: true),
                    Author = table.Column<string>(type: "TEXT", nullable: true),
                    SourceId = table.Column<string>(type: "TEXT", nullable: true),
                    Picture = table.Column<byte[]>(type: "BLOB", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.BookId);
                });

            migrationBuilder.CreateTable(
                name: "BookSource",
                columns: table => new
                {
                    BookSourceId = table.Column<string>(type: "TEXT", nullable: false),
                    BookSourceName = table.Column<string>(type: "TEXT", nullable: true),
                    BookSourceType = table.Column<int>(type: "INTEGER", nullable: false),
                    IsEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    BaseUrl = table.Column<string>(type: "TEXT", nullable: true),
                    BookSourceNote = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookSource", x => x.BookSourceId);
                });

            migrationBuilder.CreateTable(
                name: "BookChapter",
                columns: table => new
                {
                    ChapterId = table.Column<string>(type: "TEXT", nullable: false),
                    ChapterName = table.Column<string>(type: "TEXT", nullable: true),
                    CatalogIndex = table.Column<int>(type: "INTEGER", nullable: false),
                    BookId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookChapter", x => x.ChapterId);
                    table.ForeignKey(
                        name: "FK_BookChapter_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SourceBookInfoRule",
                columns: table => new
                {
                    BookInfoRuleId = table.Column<string>(type: "TEXT", nullable: false),
                    BookName = table.Column<string>(type: "TEXT", nullable: true),
                    Author = table.Column<string>(type: "TEXT", nullable: true),
                    CoverUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Introduction = table.Column<string>(type: "TEXT", nullable: true),
                    LastChapter = table.Column<string>(type: "TEXT", nullable: true),
                    CatalogUrl = table.Column<string>(type: "TEXT", nullable: true),
                    WordCount = table.Column<string>(type: "TEXT", nullable: true),
                    BookSourceId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SourceBookInfoRule", x => x.BookInfoRuleId);
                    table.ForeignKey(
                        name: "FK_SourceBookInfoRule_BookSource_BookSourceId",
                        column: x => x.BookSourceId,
                        principalTable: "BookSource",
                        principalColumn: "BookSourceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SourceCatalogRule",
                columns: table => new
                {
                    CatalogRuleId = table.Column<string>(type: "TEXT", nullable: false),
                    ChapterList = table.Column<string>(type: "TEXT", nullable: true),
                    ChapterName = table.Column<string>(type: "TEXT", nullable: true),
                    ChapterUrl = table.Column<string>(type: "TEXT", nullable: true),
                    IsVip = table.Column<string>(type: "TEXT", nullable: true),
                    NextCatalogUrl = table.Column<string>(type: "TEXT", nullable: true),
                    UpdateTime = table.Column<string>(type: "TEXT", nullable: true),
                    BookSourceId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SourceCatalogRule", x => x.CatalogRuleId);
                    table.ForeignKey(
                        name: "FK_SourceCatalogRule_BookSource_BookSourceId",
                        column: x => x.BookSourceId,
                        principalTable: "BookSource",
                        principalColumn: "BookSourceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SourceContentRule",
                columns: table => new
                {
                    ContentRuleId = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: true),
                    NextContent = table.Column<string>(type: "TEXT", nullable: true),
                    BookSourceId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SourceContentRule", x => x.ContentRuleId);
                    table.ForeignKey(
                        name: "FK_SourceContentRule_BookSource_BookSourceId",
                        column: x => x.BookSourceId,
                        principalTable: "BookSource",
                        principalColumn: "BookSourceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SourceSearchRule",
                columns: table => new
                {
                    SearchRuleId = table.Column<string>(type: "TEXT", nullable: false),
                    BookList = table.Column<string>(type: "TEXT", nullable: true),
                    BookName = table.Column<string>(type: "TEXT", nullable: true),
                    Author = table.Column<string>(type: "TEXT", nullable: true),
                    Introduction = table.Column<string>(type: "TEXT", nullable: true),
                    BookUrl = table.Column<string>(type: "TEXT", nullable: true),
                    CoverUrl = table.Column<string>(type: "TEXT", nullable: true),
                    WordCount = table.Column<string>(type: "TEXT", nullable: true),
                    LastChapter = table.Column<string>(type: "TEXT", nullable: true),
                    BookSourceId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SourceSearchRule", x => x.SearchRuleId);
                    table.ForeignKey(
                        name: "FK_SourceSearchRule_BookSource_BookSourceId",
                        column: x => x.BookSourceId,
                        principalTable: "BookSource",
                        principalColumn: "BookSourceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookParagraph",
                columns: table => new
                {
                    ParagraphId = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: true),
                    ChapterId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookParagraph", x => x.ParagraphId);
                    table.ForeignKey(
                        name: "FK_BookParagraph_BookChapter_ChapterId",
                        column: x => x.ChapterId,
                        principalTable: "BookChapter",
                        principalColumn: "ChapterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookChapter_BookId",
                table: "BookChapter",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookParagraph_ChapterId",
                table: "BookParagraph",
                column: "ChapterId");

            migrationBuilder.CreateIndex(
                name: "IX_SourceBookInfoRule_BookSourceId",
                table: "SourceBookInfoRule",
                column: "BookSourceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SourceCatalogRule_BookSourceId",
                table: "SourceCatalogRule",
                column: "BookSourceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SourceContentRule_BookSourceId",
                table: "SourceContentRule",
                column: "BookSourceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SourceSearchRule_BookSourceId",
                table: "SourceSearchRule",
                column: "BookSourceId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookParagraph");

            migrationBuilder.DropTable(
                name: "SourceBookInfoRule");

            migrationBuilder.DropTable(
                name: "SourceCatalogRule");

            migrationBuilder.DropTable(
                name: "SourceContentRule");

            migrationBuilder.DropTable(
                name: "SourceSearchRule");

            migrationBuilder.DropTable(
                name: "BookChapter");

            migrationBuilder.DropTable(
                name: "BookSource");

            migrationBuilder.DropTable(
                name: "Book");
        }
    }
}
