
public class MyHashSet
{
    private string[] set = new string[50];

    public bool Contains(string value)
    {
        foreach (string v in set)
            if (v == value) return true;
        return false;
    }

    public void Add(string value)
    {
        for (int i = 0; i < set.Length; i++)
        {
            if (set[i] == null)
            {
                set[i] = value;
                return;
            }
        }
    }
}
