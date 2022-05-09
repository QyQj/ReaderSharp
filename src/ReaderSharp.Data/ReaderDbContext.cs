using Microsoft.EntityFrameworkCore;
using ReaderSharp.Models.Entities;

namespace ReaderSharp.Data
{
    public class ReaderDbContext : DbContext
    {
        public ReaderDbContext(DbContextOptions<ReaderDbContext> options) : base(options) { }

        public DbSet<BookSource> BookSources { get; set; }

        public DbSet<SourceBookInfoRule> SourceBookInfoRules { get; set; }

        public DbSet<SourceCatalogRule> SourceCatalogRules { get; set; }

        public DbSet<SourceContentRule> SourceContentRules { get; set; }

        public DbSet<SourceSearchRule> SourceSearchRules { get; set; }

        public DbSet<Book> BookInfos { get; set; }

        public DbSet<BookChapter> BookChapters { get; set; }

        public DbSet<BookParagraph> BookParagraphs { get; set; }
    }
}
