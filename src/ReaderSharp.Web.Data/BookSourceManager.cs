using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReaderSharp.Web.API.Models.Entities;

namespace ReaderSharp.Web.Data
{
    public class BookSourceManager : IBookSourceManager
    {
        private readonly ReaderDbContext _dbContext;

        public BookSourceManager(ReaderDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<BookSource>> GetBookSource()
        {
            return await _dbContext.BookSources
                .Include(o => o.BookInfoRule)
                .Include(o => o.CatalogRule)
                .Include(o => o.ContentRule)
                .Include(o => o.SearchRule)
                .ToListAsync();
        }

        public async Task<bool> ImportBookSource(List<BookSource> sources)
        {

            foreach (var bookSource in sources)
            {
                bookSource.BookInfoRule.BookSourceId = bookSource.BookSourceId;
                bookSource.BookInfoRule.BookSource = bookSource;

                bookSource.CatalogRule.BookSourceId = bookSource.BookSourceId;
                bookSource.CatalogRule.BookSource = bookSource;

                bookSource.ContentRule.BookSourceId = bookSource.BookSourceId;
                bookSource.ContentRule.BookSource = bookSource;

                bookSource.SearchRule.BookSourceId = bookSource.BookSourceId;
                bookSource.SearchRule.BookSource = bookSource;
            }
            await _dbContext.AddRangeAsync(sources);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteBookSource(List<string> baseUrls)
        {
            var sources =
                _dbContext.BookSources
                    .Where(o => baseUrls.Contains(o.BaseUrl))
                    .Include(o => o.BookInfoRule)
                    .Include(o => o.CatalogRule)
                    .Include(o => o.ContentRule)
                    .Include(o => o.SearchRule);
            _dbContext.BookSources.RemoveRange(sources);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
