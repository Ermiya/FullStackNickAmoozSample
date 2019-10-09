using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03.Lists
{
    public class Person : IEquatable<Person>
    {
        public string FName { get; set; }
        public bool Equals(Person other)
        {
            return FName == other.FName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            List<int> myList01 = new List<int>(250) { 1, 2, 3, 4 };



            myList01.Add(1);
            myList01.Remove(1);
            
            myList01.RemoveAt(0);
            myList01.TrimExcess();

            myList01.Find(x => x.ToString() == "");

            myList01.Sort();

            myList01.Count();
            var a = myList01.Capacity;

            myList01.AsReadOnly();

        }
    }
}
