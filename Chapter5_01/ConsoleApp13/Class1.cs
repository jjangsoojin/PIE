using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5_01
{
    class Class1
    {

        public class Node
        {
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(int value)
            {
                Left = null;
                Right = null;
            }
        }

        public int treeHeight(Node n)
        {
            if (n == null) return 0;

            // 현재 노드의 높이는 1(현재 노드) + 좌우 자식 중 더 높은 쪽의 높이  >  루트 노드 자체도 1의 높이를 갖기 때문에 1을 더해줌.
            return 1 + Math.Max(treeHeight(n.Left), treeHeight(n.Right));
        }
    }
}
