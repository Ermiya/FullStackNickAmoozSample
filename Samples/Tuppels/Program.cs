using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuppels
{
    class Program
    {
        static void Main(string[] args)
        {

            var tup = Tuple.Create<int, string, int>(1, "", 2);
            testTup(tup);
            var fullname = GetFullName();
            //fullname.age

            //Tupple Deconstruction
            (int age, string Name, string Family) = GetFullName();

            

            

        }
        public static (int age, string firstName, string lastName) GetFullName()
        {
            return (1, "Farshid", "Saeidi");
        }
            
        private static void testTup(Tuple<int, string, int> tup)
        {
            throw new NotImplementedException();
        }
    }
}
