static Dictionary<string, int> FindFrequency(List<string> list)
{
    Dictionary<string, int> freq = new Dictionary<string, int>();

    foreach (string item in list)
    {
        if (freq.ContainsKey(item))
            freq[item]++;
        else
            freq[item] = 1;
    }
    return freq;
}
