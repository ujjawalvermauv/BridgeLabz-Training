public class StringUtils
{
    public string Reverse(string str)
    {
        char[] arr = str.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }

    public bool IsPalindrome(string str)
    {
        string rev = Reverse(str);
        return str == rev;
    }

    public string ToUpperCase(string str)
    {
        return str.ToUpper();
    }
}
