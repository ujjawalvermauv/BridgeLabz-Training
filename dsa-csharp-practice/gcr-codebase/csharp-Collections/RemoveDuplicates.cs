static List<int> RemoveDuplicates(List<int> list)
{
    HashSet<int> seen = new HashSet<int>();
    List<int> result = new List<int>();

    foreach (int item in list)
    {
        if (!seen.Contains(item))
        {
            seen.Add(item);
            result.Add(item);
        }
    }
    return result;
}
