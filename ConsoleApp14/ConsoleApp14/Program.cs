using Chapter5_02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Chapter5_02.Class1;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Node root = new Node(100);
            root.Left = new Node(50);
            root.Right = new Node(150);
            root.Left.Left = new Node(25);
            root.Left.Right = new Node(75);
            root.Right.Left = new Node(125);
            root.Right.Right = new Node(175);
            root.Right.Left.Left = new Node(110);

            class1.PreorderTraversal(root);
        
        }
    }
}
