using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NickAmoozNews.Entities
{
    public class News : BaseEntity<int>
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Context { get; set; }

    }
}
