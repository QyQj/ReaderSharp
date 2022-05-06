using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReaderSharp.Models.Entities
{
    public class SourceBookInfoRule
    {
        [Key]
        public string BookInfoRuleId { get; set; }

        public string BookName { get; set; }

        public string Author { get; set; }

        public string CoverUrl { get; set; }

        public string Introduction { get; set; }

        public string LastChapter { get; set; }

        public string BookSourceId { get; set; }

        public BookSource BookSource { get; set; }
    }
}
