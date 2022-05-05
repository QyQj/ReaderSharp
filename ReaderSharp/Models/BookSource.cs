using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReaderSharp.Models
{
    [Table("BookSource")]
    public record BookSource
    {
        [Key]
        public string BookSourceId { get; set; }

        public string BaseUrl { get; set; }

        public string BookUrl { get; set; }

        public string ChapterUrl { get; set; }

        public string PicUrl { get; set; }
    }
}
