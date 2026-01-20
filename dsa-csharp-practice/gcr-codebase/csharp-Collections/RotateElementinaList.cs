static List<int> RotateList(List<int> list, int k)
{
    k = k % list.Count;
    List<int> result = new List<int>();

    for (int i = k; i < list.Count; i++)
        result.Add(list[i]);

    for (int i = 0; i < k; i++)
        result.Add(list[i]);

    return result;
}
