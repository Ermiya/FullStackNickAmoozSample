using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03.Array
{
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
        }
    }
}
