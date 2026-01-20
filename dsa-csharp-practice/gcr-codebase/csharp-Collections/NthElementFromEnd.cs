static char FindNthFromEnd(LinkedList<char> list, int n)
{
    var fast = list.First;
    var slow = list.First;

    for (int i = 0; i < n; i++)
        fast = fast.Next;

    while (fast != null)
    {
        slow = slow.Next;
        fast = fast.Next;
    }

    return slow.Value;
}
