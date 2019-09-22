using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NickAmoozNews.Entities
{
  public  class Category :BaseEntity<byte>
    {
        public Byte? ParentId { get; set; }
        public string Name { get; set; }
    }
}
