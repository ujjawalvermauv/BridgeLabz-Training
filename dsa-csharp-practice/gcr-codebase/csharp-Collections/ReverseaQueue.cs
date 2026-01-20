static Queue<int> ReverseQueue(Queue<int> q)
{
    Stack<int> stack = new Stack<int>();

    while (q.Count > 0)
        stack.Push(q.Dequeue());

    while (stack.Count > 0)
        q.Enqueue(stack.Pop());

    return q;
}
