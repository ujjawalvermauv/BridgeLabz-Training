static Dictionary<string, int> WordCount(string text)
{
    Dictionary<string, int> map = new Dictionary<string, int>();
    string[] words = text.ToLower()
        .Replace(",", "")
        .Replace("!", "")
        .Split(' ');

    foreach (string word in words)
    {
        if (map.ContainsKey(word))
            map[word]++;
        else
            map[word] = 1;
    }
    return map;
}
