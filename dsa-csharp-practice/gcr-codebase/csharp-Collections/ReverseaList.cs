using System.Collections;

static ArrayList ReverseArrayList(ArrayList list)
{
    int left = 0;
    int right = list.Count - 1;

    while (left < right)
    {
        object temp = list[left];
        list[left] = list[right];
        list[right] = temp;

        left++;
        right--;
    }
    return list;
}
// using linklist
static LinkedList<int> ReverseLinkedList(LinkedList<int> list)
{
    LinkedList<int> reversed = new LinkedList<int>();

    foreach (int item in list)
        reversed.AddFirst(item);

    return reversed;
}
