using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeTraversals
{
    static class BFSTraversal<T>
    {
        public static Queue<Node<T>> Traverse(Node<T> root)
        {
            var q = new Queue<Node<T>>();
            q.Enqueue(root);
            
            var finalQ = new Queue<Node<T>>();

            while (q.Count > 0)
            {
                var x = q.Dequeue();

                if (x.Left != null)
                    q.Enqueue(x.Left);

                if (x.Right != null)
                    q.Enqueue(x.Right);

                finalQ.Enqueue(x);
            }

            return finalQ;
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
