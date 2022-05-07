using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReaderSharp.Models.Dtos
{
    public class ImportCatalogRuleDto
    {
        public string ChapterList { get; set; }

        public string ChapterName { get; set; }

        public string ChapterUrl { get; set; }

        public string IsVip { get; set; }

        public string NextCatalogUrl { get; set; }

        public string UpdateTime { get; set; }
    }
}
