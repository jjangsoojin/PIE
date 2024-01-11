using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Chapter05_06
{
    public class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
        // 우회적인 오른쪽 회전 메서드
        public Node RotateRight()
        {
            Node newRoot = Left;
            Left = newRoot.Right;
            newRoot.Right = this;
            return newRoot;
        }
    }
    public class Class1
    {
        // 불균형한 BST를 균형 잡힌 트리로 재조정하는 메서드
        public Node RebalanceBST(Node root)
        {
            if (root == null)
                return null;
            // 루트의 왼쪽 서브트리가 없으면 균형 잡힌 트리
            if (root.Left == null)
                return root;
            // 왼쪽 서브트리의 최대 노드를 새로운 루트로 선택하고 회전 수행
            // 기존 윗부분을 오른쪽으로 옮긴다고 생각 (오른쪽에 큰값이 오니까)
            Node newRoot = root.Left; // root 왼 > 새 노드 root로 지정
            root.Left = newRoot.Right; // 새노드 오른쪽 > 기존루트 왼쪽
            newRoot.Right = root; // 기존루트 > 새 노드 오른쪽으로
            return newRoot;
        }
        public void InorderTraversal(Node root)
        {
            if (root != null)
            {
                InorderTraversal(root.Left);
                Console.Write(root.Value + " ");
                InorderTraversal(root.Right);
            }
        }
    }
}