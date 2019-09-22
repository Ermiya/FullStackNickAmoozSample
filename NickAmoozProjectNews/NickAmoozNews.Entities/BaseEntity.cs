using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NickAmoozNews.Entities
{
    public class BaseEntity<TId>
    {
        public TId Id { get; set; }
        public int InsertBy { get; set; }
        public DateTime InsertDate { get; set; }
        public int UpdatetBy { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
