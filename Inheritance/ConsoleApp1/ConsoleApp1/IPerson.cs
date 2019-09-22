using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public interface IPerson
    {
        string FirstName { get; set; }
        string  LastName { get; set; }
        bool checkName(string name);
    }

    public class Student1 : IPerson
    {
        public string SID { get; set; }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual bool checkName(string name)
        {
            throw new NotImplementedException();
        }
    }

    public class Teacher2 : IPerson
    {
        public string TID { get; set; }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual bool checkName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
