using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ReaderSharp.Models.Entities;

namespace ReaderSharp.Data
{
    public class BookSourceManager : IBookSourceManager
    {
        private ReaderDbContext _dbContext;

        public BookSourceManager(ReaderDbContext dbContext)
        {
            _dbContext = dbContext;
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
            return true;
        }
    }
}
