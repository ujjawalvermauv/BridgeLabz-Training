
public class MyHashMap
{
    private GenreNode[] table = new GenreNode[10];

    private int Hash(string key) => key.Length % table.Length;

    public BookLinkedList PutIfAbsent(string key)
    {
        int index = Hash(key);
        GenreNode temp = table[index];

        while (temp != null)
        {
            if (temp.Key == key) return temp.Value;
            temp = temp.Next;
        }

        GenreNode node = new GenreNode(key);
        node.Next = table[index];
        table[index] = node;
        return node.Value;
    }

    public void DisplayAll()
    {
        foreach (GenreNode node in table)
        {
            GenreNode temp = node;
            while (temp != null)
            {
                System.Console.WriteLine("\nGenre: " + temp.Key);
                temp.Value.Display();
                temp = temp.Next;
            }
        }
    }
}
