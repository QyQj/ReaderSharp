using AngleSharp;

namespace ReaderSharp.Data
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
