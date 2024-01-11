using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 ca = new Class1();

            // Example 1
            Node root1 = new Node(20);
            root1.left = new Node(8);
            root1.right = new Node(22);
            root1.left.left = new Node(4);
            root1.left.right = new Node(12);
            root1.left.right.left = new Node(10);
            root1.left.right.right = new Node(14);

            // 주어진 값의 최소 공통 조상 찾기
            int value1 = 4;
            int value2 = 14;

            Node resultint = ca.FindLowestCommonAncestor(root1, value1, value2); // Output: 3

            // node 의 최소 공통 조상 찾기
            Node node1 = root1.left.left;
            Node node2 = root1.left.right.right;

            Node resultNode = ca.FindLowestCommonAncestor(root1, node1, node2);

        }
    }
}
