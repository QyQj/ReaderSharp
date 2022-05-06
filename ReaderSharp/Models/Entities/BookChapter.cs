using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReaderSharp.Models.Entities
{
    /// <summary>
    /// 书籍章节
    /// </summary>
    [Table("BookChapter")]
    public class BookChapter
    {
        [Key]
        public string ChapterId { get; set; }

        public string BookId { get; set; }

        public string ChapterName { get; set; }

        public int CatalogIndex { get; set; }
    }
}
