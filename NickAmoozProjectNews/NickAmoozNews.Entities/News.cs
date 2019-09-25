using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NickAmoozNews.Entities
{
    public enum NewsState
    {
        Draft,
        Publish,
        Deleted
    }
    public class News : BaseEntity<int>
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Body { get; set; }
        public List<Keyword> Keywords { get; set; }
        public List<Category> Categories { get; set; }
        public List<NewsFile> Atachments { get; set; }
        public byte MainCategoryId { get; set; }
        public int MainFileId { get; set; }
        public NewsState State { get; set; }



    }
}
