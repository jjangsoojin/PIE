using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_01
{
    class Program
    {
        static void Main()
        {
            StackExample stack = new StackExample();

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
}
