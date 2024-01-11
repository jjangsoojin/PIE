using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5_03
{
    public class Node
    {

        public int Data;

        public Node left;
        public Node right;

        public Node(int x)
        {
            Data = x;
        }
    }

    public class Class1
    {
        private int diameter;


        // 주어진 값의 최소 공통 조상 찾기
        public Node FindLowestCommonAncestor(Node root, int value1, int value2)
        {
            while (root != null)
            {
                int currentValue = root.Data;

                if (currentValue > value1 && currentValue > value2)
                {
                    root = root.left;
                }
                else if (currentValue < value1 && currentValue < value2)
                {
                    root = root.right;
                }
                else
                {
                    return root;
                }
            }

            return null; // only if the tree is empty
        }

        // node 의 최소 공통 조상 찾기
        public Node FindLowestCommonAncestor(Node root, Node child1, Node child2)
        {
            if (root == null || child1 == null || child2 == null)
            {
                return null;
            }

            return FindLowestCommonAncestor(root, child1.Data, child2.Data);
        }
    }
}
