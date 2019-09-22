using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.GenericLinkedList
{
   public  class GenericNode<T>
    {
        public GenericNode<T> Next { get; set; }
        public GenericNode<T> Prev { get; set; }
    }

    public class GenericLinkedList<T>
    {
        public static int statisTest;
        public T MyProperty { get; set; }
        public GenericNode<T> First { get; set; }
        public GenericNode<T> Last { get; set; }
        public void Add(GenericNode<T> node)
        {
            MyProperty = default(T);
            Last.Next = node;
        }
        public class UserList
        {
            public UserList()
            {
                GenericLinkedList<int> list = new GenericLinkedList<int>();
                GenericLinkedList<string> lists = new GenericLinkedList<string>();

                GenericLinkedList<string>.statisTest = 2;
                GenericLinkedList<int>.statisTest = 4;


            }
        }
    }
}
