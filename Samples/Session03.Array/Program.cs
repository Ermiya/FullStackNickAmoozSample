using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03.Array1
{
    public class Person
    {
        public string Name { get; set; }
        public string Family { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            int[] MyArray;
            MyArray = new int[4];
            int[] MyArray02 = new int[4] { 3, 4, 5, 6 };
            int[] MyArray03 = new int[] { 3, 4, 5, 6 };

           
            Console.WriteLine(MyArray03[1]);

            foreach (var item in MyArray03)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < MyArray03.Length; i++)
            {
                Console.WriteLine(MyArray03[i]);
            }
            Person[] persons = new Person[4];
            var r = persons[0].Name;

            //var array = Array.CreateInstance();

            //persons.CopyTo()
            persons.Clone();
            //Array.Sort()

        }
    }
}
