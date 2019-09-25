using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NickAmoozNews.Entities
{
    public class NewsFile : BaseEntity<int>
    {
        public enum FileTypes
        {
            Picture,
            Video,
            Audio,
            Document
        }
        public string Path { get; set; }
        public FileTypes FileType { get; set; }

    }
}
