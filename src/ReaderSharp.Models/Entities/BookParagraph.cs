using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReaderSharp.Models.Entities
{
    [Table("BookParagraph")]
    public class BookParagraph
    {
        [Key]
        public string ParagraphId { get; set; }

        public string Content { get; set; }

        public string BookId { get; set; }

        public Book Book { get; set; }

        public string ChapterId { get; set; }

        public BookChapter Chapter { get; set; }
    }
}
