using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReaderSharp.Web.API.Models.Entities
{
    [Table("BookParagraph")]
    public class BookParagraph
    {
        [Key]
        public string ParagraphId { get; set; }

        public string Content { get; set; }

        [Required]
        public string ChapterId { get; set; }

        public BookChapter Chapter { get; set; }
    }
}
