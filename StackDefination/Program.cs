using System;
using System.Collections.Generic;
using System.Linq;

namespace StackDefination
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<object> stack1 = new Stack<object>();
            stack1.Push(123456789);
            stack1.Push(45);

            Stack<object> stack2 = new Stack<object>();
            stack2.Push(88);
            stack2.Push("example 1");

            Stack<object> stack3 = new Stack<object>();
            stack3.Push("example 2");
            stack3.Push(4f);
            stack3.Push("example 3");

            object[] a = new object[stack1.Count + stack2.Count + stack3.Count];

            stack1.CopyTo(a, 0);
            stack2.CopyTo(a, stack1.Count);
            stack3.CopyTo(a, stack1.Count + stack2.Count);

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
