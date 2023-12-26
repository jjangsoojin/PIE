using System;
using System.Diagnostics;

class Node
{
    public int Data { get; set; }
    public Node Next { get; set; }

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

class Exam
{
    private Node top;

    public bool StackEmpty()
    {
        if (top == null)
        {
            Debug.WriteLine("Error: STACK IS EMPTY");
            return false;
        }

        return true;
    }

    // 스택에 원소를 추가합니다 (push).
    public void Push(int item)
    {
        Node newNode = new Node(item);
        newNode.Next = top;
        top = newNode;

        Debug.WriteLine($"{item}이(가) 스택에 추가되었습니다.");
    }

    // 스택에서 원소를 제거하고 반환합니다 (pop).
    public void Pop()
    {
        if (StackEmpty())
        {
            int poppedItem = top.Data;
            // Next 가 앞으로 하나씩 덮어씌어짐
            top = top.Next;

            Debug.WriteLine($"{poppedItem}이(가) 스택에서 제거되었습니다.");
        }
    }

    // 스택의 현재 상태를 출력합니다.
    public void PrintStack()
    {
        if (top == null)
        {
            Debug.WriteLine("스택이 비어 있습니다.");
            return;
        }

        string stackContent = "현재 스택: ";
        Node current = top;

        while (current != null)
        {
            stackContent += $"{current.Data} ";
            current = current.Next;
        }

        Debug.WriteLine(stackContent);
    }
}
