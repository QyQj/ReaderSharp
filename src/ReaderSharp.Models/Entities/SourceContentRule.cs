using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReaderSharp.Models.Entities
{
    [Table("SourceContentRule")]
    public class SourceContentRule
    {
        [Key]
        public string ContentRuleId { get; set; }

        public string Content { get; set; }

        public string NextContent { get; set; }

        [Required]
        public string BookSourceId { get; set; }

        public BookSource BookSource { get; set; }
    }
}
