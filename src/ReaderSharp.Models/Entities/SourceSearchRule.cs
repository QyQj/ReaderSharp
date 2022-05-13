using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReaderSharp.Models.Entities
{
    [Table("SourceSearchRule")]
    public class SourceSearchRule
    {
        [Key]
        public string SearchRuleId { get; set; }

        public string BookList { get; set; }

        public string BookName { get; set; }

        public string Author { get; set; }

        public string Introduction { get; set; }

        public string BookUrl { get; set; }

        public string CoverUrl { get; set; }

        public string WordCount { get; set; }

        public string LastChapter { get; set; }

        [Required]
        public string BookSourceId { get; set; }

        public BookSource BookSource { get; set; }
    }
}
