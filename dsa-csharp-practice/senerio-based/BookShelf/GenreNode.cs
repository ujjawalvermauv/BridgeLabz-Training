
public class GenreNode
{
    public string Key;
    public BookLinkedList Value;
    public GenreNode Next;
    public GenreNode(string key)
    {
        Key = key;
        Value = new BookLinkedList();
        Next = null;
    }
}
