using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReaderSharp.Models.Dtos
{
    public class ImportSearchRuleDto
    {
        public string BookList { get; set; }

        public string BookName { get; set; }

        public string Author { get; set; }

        public string Introduction { get; set; }

        public string BookUrl { get; set; }

        public string CoverUrl { get; set; }

        public string WordCount { get; set; }

        public string LastChapter { get; set; }
    }
}
