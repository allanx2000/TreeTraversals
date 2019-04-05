using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeTraversals
{
    class DFSTraversal<T>
    {
        public Queue<Node<T>> InOrder { get; private set; }
        public Queue<Node<T>> PreOrder { get; private set; }
        public Queue<Node<T>> PostOrder { get; private set; }

        private DFSTraversal()
        {
            InOrder = new Queue<Node<T>>();
            PreOrder = new Queue<Node<T>>();
            PostOrder = new Queue<Node<T>>();
        }

        public static DFSTraversal<T> CreateTraversal(Node<T> root)
        {
            DFSTraversal<T> tr = new DFSTraversal<T>();

            Traverse(root, tr);

            return tr;
        }

        private static void Traverse(Node<T> node, DFSTraversal<T> tr)
        {
            if (node == null)
                return;

            tr.PreOrder.Enqueue(node);
            Traverse(node.Left, tr);
            tr.InOrder.Enqueue(node);
            Traverse(node.Right, tr);
            tr.PostOrder.Enqueue(node);
        }
    }
}
