using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();


            Node root = new Node(6);
            root.Left = new Node(4);
            root.Left.Left = new Node(2);
            root.Left.Right = new Node(5);
            root.Left.Left.Left = new Node(1);
            root.Left.Left.Right = new Node(3);
            root.Right = new Node(7);

            //Console.WriteLine("Original Inorder Traversal:");
            //class1.InorderTraversal(root);

            Node rebalancedRoot = class1.RebalanceBST(root);

            //Console.WriteLine("\\n\\nRebalanced Inorder Traversal:");
            //class1.InorderTraversal(rebalancedRoot);

        }
    }
}