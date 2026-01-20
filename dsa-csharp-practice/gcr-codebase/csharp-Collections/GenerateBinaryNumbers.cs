static List<string> GenerateBinary(int n)
{
    Queue<string> q = new Queue<string>();
    List<string> result = new List<string>();

    q.Enqueue("1");

    for (int i = 0; i < n; i++)
    {
        string curr = q.Dequeue();
        result.Add(curr);

        q.Enqueue(curr + "0");
        q.Enqueue(curr + "1");
    }
    return result;
}
