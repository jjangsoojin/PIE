using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        Exam stack = new Exam();

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        stack.PrintStack();

        stack.Pop();

        stack.PrintStack();

        stack.Push(4);
        stack.Push(5);
        stack.Push(6);

        stack.PrintStack();
    }
}