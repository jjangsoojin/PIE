using Chapter5_01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Chapter5_01.Class1;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {

            Class1 class1 = new Class1();
            Node root = new Node('A');   
            root.Left = new Node('B');  
            root.Right = new Node('C'); 
            root.Left.Left = new Node('D');  
            root.Left.Right = new Node('E');  
            root.Right.Left = new Node('F');     
            root.Right.Right = new Node('G');    
            root.Left.Left.Left = new Node('H');     

            int height = class1.treeHeight(root);
            System.Diagnostics.Debug.WriteLine("Height of the tree: " + height);
        }
    }
}
