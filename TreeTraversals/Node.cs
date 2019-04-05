using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeTraversals
{
    class Node<T>
    {
        
        public Node(T val)
        {
            Value = val;
        }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public T Value { get; set; }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
