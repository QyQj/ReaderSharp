using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace ReaderSharp.Models
{
    /// <summary>
    /// 书籍信息
    /// </summary>
    [Table("Book")]
    public class BookInfo
    {
        [Key]
        public string BookId { get; set; }

        public string BookName { get; set; }

        public string Author { get; set; }

        public string SourceId { get; set; }

        public byte[] Picture { get; set; }
    }
}
