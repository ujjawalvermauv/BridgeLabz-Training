using System;
using System.Collections.Generic;

class SortStackRecursion
{
    static void SortStack(Stack<int> stack)
    {
        if (stack.Count > 0)
        {
            int temp = stack.Pop();
            SortStack(stack);
            InsertSorted(stack, temp);
        }
    }

    static void InsertSorted(Stack<int> stack, int value)
    {
        if (stack.Count == 0 || value > stack.Peek())
        {
            stack.Push(value);
            return;
        }

        int temp = stack.Pop();
        InsertSorted(stack, value);
        stack.Push(temp);
    }

    static void Main()
    {
        Stack<int> s = new Stack<int>();
        s.Push(30);
        s.Push(10);
        s.Push(20);

        SortStack(s);

        while (s.Count > 0)
            Console.WriteLine(s.Pop());
    }
}
