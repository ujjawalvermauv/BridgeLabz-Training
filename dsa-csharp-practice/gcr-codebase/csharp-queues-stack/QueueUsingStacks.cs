using System;
using System.Collections.Generic;

class QueueUsingStacks
{
    private Stack<int> stack1 = new Stack<int>();
    private Stack<int> stack2 = new Stack<int>();

    // Enqueue operation
    public void Enqueue(int x)
    {
        stack1.Push(x);
    }

    // Dequeue operation
    public int Dequeue()
    {
        if (stack2.Count == 0)
        {
            if (stack1.Count == 0)
                throw new InvalidOperationException("Queue is empty");

            while (stack1.Count > 0)
                stack2.Push(stack1.Pop());
        }
        return stack2.Pop();
    }

    static void Main()
    {
        QueueUsingStacks q = new QueueUsingStacks();
        q.Enqueue(10);
        q.Enqueue(20);
        q.Enqueue(30);

        Console.WriteLine(q.Dequeue());
        Console.WriteLine(q.Dequeue());
    }
}
