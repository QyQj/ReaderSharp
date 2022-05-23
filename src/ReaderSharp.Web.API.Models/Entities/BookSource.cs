using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReaderSharp.Web.API.Models.Entities
{
    [Table("BookSource")]
    public record BookSource
    {
        [Key]
        public string BookSourceId { get; set; }

        public string BookSourceName { get; set; }

        public int BookSourceType { get; set; }

        public bool IsEnabled { get; set; }

        public string BaseUrl { get; set; }

        public string BookSourceNote { get; set; }

        public SourceBookInfoRule BookInfoRule { get; set; }

        public SourceCatalogRule CatalogRule { get; set; }

        public SourceContentRule ContentRule { get; set; }

        public SourceSearchRule SearchRule { get; set; }
    }
}
