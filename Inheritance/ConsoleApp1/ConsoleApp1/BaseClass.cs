using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public abstract class Person
    {
        public Person( string firstName , string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FirstName { get; set; }
        internal string LastName { get; set; }

        //public abstract string GetYourName();

        public virtual string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public class Student : Person
        {
            public Student():base("","")
            {

            }
            public int StudentId { get; set; }

            public override string GetFullName()
            {
                return $"{base.GetFullName()} {StudentId}";
            }
            //public override string GetYourName()
            //{
            //    return $"{FirstName} {LastName} {StudentId}";

            //}
        }

        public class Teacher:Person
        {
            public Teacher() : base("", "")
            {

            }

            public int TeacherId { get; set; }
            public string  ClassNo { get; set; }

            //public override string GetYourName()
            //{
            //    return $"{FirstName} {LastName} {ClassNo}";

            //}
        }


    }
}
