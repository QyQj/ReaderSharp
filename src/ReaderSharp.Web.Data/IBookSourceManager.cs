using System.Collections.Generic;
using System.Threading.Tasks;
using ReaderSharp.Web.API.Models.Entities;

namespace ReaderSharp.Web.Data
{
    public interface IBookSourceManager
    {
        public Task<IEnumerable<BookSource>> GetBookSource();

        public Task<bool> ImportBookSource(List<BookSource> sources);

        public Task<bool> DeleteBookSource(List<string> baseUrls);
    }
}
