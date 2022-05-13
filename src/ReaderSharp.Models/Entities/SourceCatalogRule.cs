using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReaderSharp.Models.Entities
{
    [Table("SourceCatalogRule")]
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

        [Required]
        public string BookSourceId { get; set; }

        public BookSource BookSource { get; set; }
    }
}
