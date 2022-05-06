using System.ComponentModel.DataAnnotations;

namespace ReaderSharp.Models.Entities
{
    public class SourceContentRule
    {
        [Key]
        public string ContentRuleId { get; set; }

        public string Content { get; set; }

        public string NextContent { get; set; }

        public string BookSourceId { get; set; }

        public BookSource BookSource { get; set; }
    }
}
