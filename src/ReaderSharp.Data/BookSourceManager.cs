namespace ReaderSharp.Data
{
    public class BookSourceManager : IBookSourceManager
    {
        private ReaderDbContext _dbContext;

        public BookSourceManager(ReaderDbContext dbContext)
        {
            _dbContext=dbContext;
        }
    }
}
