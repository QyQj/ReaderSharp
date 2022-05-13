using System.Collections.Generic;
using System.Threading.Tasks;
using ReaderSharp.Models.Entities;

namespace ReaderSharp.Data
{
    public interface IBookSourceManager
    {
        public Task<IEnumerable<BookSource>> GetBookSource();

        public Task<bool> ImportBookSource(List<BookSource> sources);

        public Task<bool> DeleteBookSource(List<string> baseUrls);
    }
}
