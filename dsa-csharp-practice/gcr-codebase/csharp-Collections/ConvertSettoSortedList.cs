static List<int> SetToSortedList(HashSet<int> set)
{
    List<int> list = new List<int>(set);
    list.Sort();
    return list;
}
