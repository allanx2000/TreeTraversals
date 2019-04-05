using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTraversals
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<int> root = CreateTree(10);

            //https://www.geeksforgeeks.org/tree-traversals-inorder-preorder-and-postorder/
            var dfs = DFSTraversal<int>.CreateTraversal(root);
            var bfs = BFSTraversal<int>.Traverse(root);
            
            Console.ReadKey();
        }

        private static Node<int> CreateTree(int p)
        {
            var root = new Node<int>(1);
            
            var q = new Queue<Node<int>>();
            q.Enqueue(root);

            for (int i = 2; i <= p; i++)
            {
                var x = q.Peek();
                if (x.Left == null)
                {
                    x.Left = new Node<int>(i);
                    q.Enqueue(x.Left);
                }
                else
                {
                    x.Right = new Node<int>(i);
                    q.Enqueue(x.Right);
                    q.Dequeue();
                }
            }

            return root;
        }
    }
}
