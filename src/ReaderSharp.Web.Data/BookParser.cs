using AngleSharp;

namespace ReaderSharp.Web.Data
{
    public static class BookParser
    {
        private static IConfiguration AngleConfig { get; }

        private static IBrowsingContext AngleContext { get; }

        static BookParser()
        {
            AngleConfig = Configuration.Default.WithDefaultLoader();
            AngleContext = BrowsingContext.New(AngleConfig);
        }
    }
}
