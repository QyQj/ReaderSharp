using System.Collections.Generic;
using System.Threading.Tasks;
using ReaderSharp.Models.Entities;

namespace ReaderSharp.Data
{
    public interface IBookSourceManager
    {
        public Task<bool> ImportBookSource(List<BookSource> sources);
    }
}
