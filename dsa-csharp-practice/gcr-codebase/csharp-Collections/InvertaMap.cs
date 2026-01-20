static Dictionary<int, List<string>> InvertMap(Dictionary<string, int> map)
{
    Dictionary<int, List<string>> result = new Dictionary<int, List<string>>();

    foreach (var pair in map)
    {
        if (!result.ContainsKey(pair.Value))
            result[pair.Value] = new List<string>();

        result[pair.Value].Add(pair.Key);
    }
    return result;
}
