using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5_02
{
    class Class1
    {
        public class Node
        {
            public int Value;
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(int value)
            {
                Value = value;
                Left = null;
                Right = null;
            }
        }

        public void PreorderTraversal(Node n)
        {
            if (n == null) return;

            System.Diagnostics.Debug.WriteLine(n.Value + " "); //1. 루트(또는 서브트리의 루트) 값을 출력합니다.

            PreorderTraversal(n.Left);  // 2. 왼쪽 서브트리에 대해 전위 순회를 수행합니다.
            PreorderTraversal(n.Right); // 3. 오른쪽 서브트리에 대해 전위 순회를 수행합니다.
        }

    }
}
