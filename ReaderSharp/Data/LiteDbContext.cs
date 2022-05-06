using Microsoft.EntityFrameworkCore;
using ReaderSharp.Models.Entities;

namespace ReaderSharp.Data
{
    public class LiteDbContext : DbContext
    {
        public LiteDbContext(DbContextOptions<LiteDbContext> options) : base(options)
        {

        }
        public DbSet<BookSource> BookSources { get; set; }

        public DbSet<BookInfo> BookInfos { get; set; }

        public DbSet<BookChapter> BookChapters { get; set; }

        public DbSet<BookParagraph> BookParagraphs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
