using System;

public class Node
{
    public int Data { get; set; }
    public Node Next { get; set; }

    public Node(int data)
    {
        Data = data;
        Next = null;
     }
}

public class Exam
{
    public Node head;
    public Node tail;

    public bool Delete(Node elem)
    {


       if (elem == null)
        {
            return false;
        }

       if(head == elem)
        {
            head = head.Next;

            if (head == null)
            {
                // If the list becomes empty after deletion, update tail as well
                tail = null;
            }
            return true;
        }

        Node current = head;
        while (current.Next != null && current.Next != elem)
        {
            current = current.Next;
        }

        if (current.Next == null)
        {
            // Element not found in the list
            return false;
        }

        // Update the next pointer to skip the element to be deleted
        current.Next = elem.Next;

        // If the element to be deleted is the tail, update tail
        if (elem == tail)
        {
            tail = current;
        }

        return true;
    }

    public bool InsertAfter(Node elem, int item)
    {
        Node newNode = new Node(item);


        if(elem == null)
        {
            head = newNode;

            if(tail == null)
            {
                tail = newNode;
            }

        }else 
        {
            Node current = head;

            while(current != null && current != elem)
            {
                current = current.Next;
            }

            newNode.Next = current.Next;
            current.Next = newNode;

            if (current == tail)
                tail = newNode;

        }


        return true;
    }

    public void DisplayList()
    {
        Node current = head;
        while (current != null)
        {
            Console.Write($"{current.Data} -> ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }
}
