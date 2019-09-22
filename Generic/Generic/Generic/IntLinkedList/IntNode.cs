﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.IntLinkedList
{
   public class IntNode
    {
        public int Value { get; set; }
        public IntNode Next { get; set; }
        public IntNode Perv { get; set; }
    }

    public class IntLinkedList : IEnumerable
    {
        public IntNode First { get; set; }
        public IntNode Last { get; set; }
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
