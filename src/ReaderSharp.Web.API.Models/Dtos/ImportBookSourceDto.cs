namespace ReaderSharp.Web.API.Models.Dtos
{
    public class ImportBookSourceDto
    {
        public string Name { get; set; }

        public string BaseUrl { get; set; }

        public string Note { get; set; }

        public ImportBookInfoRuleDto BookInfoRule { get; set; }

        public ImportCatalogRuleDto CatalogRule { get; set; }

        public ImportContentRuleDto ContentRule { get; set; }

        public ImportSearchRuleDto SearchRule { get; set; }
    }
}
