using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Inheritance.Person;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            //Person p = new Person();
            Student s = new Student();
            Teacher t = new Teacher();
            
            test(s);
            test(t);
            test1(s);

            // test(s);

            Class1 c1 = new Class1();
            //c1.a 

            PersonTester(new Student1());
        }

        private static void test(Person p)
        {
            
        }

        private static void test1(Student s)
        {
            throw new NotImplementedException();
        }

        private static void PersonTester(IPerson person)
        {
            if (person is Teacher2)
            {
                Teacher2 t = person as Teacher2;

            }
            else if (person is Student1)
            {
                Student1 t = person as Student1;

            }

        }
    }
}
