using System.ComponentModel.DataAnnotations;

namespace ReaderSharp.Models.Entities
{
    public class SourceCatalogRule
    {
        [Key]
        public string CatalogRuleId { get; set; }

        public string ChapterList { get; set; }

        public string ChapterName { get; set; }

        public string ChapterUrl { get; set; }

        public string IsVip { get; set; }

        public string NextCatalogUrl { get; set; }

        public string UpdateTime { get; set; }

        public string BookSourceId { get; set; }

        public BookSource BookSource { get; set; }
    }
}
