static HashSet<int> SymmetricDifference(HashSet<int> s1, HashSet<int> s2)
{
    HashSet<int> result = new HashSet<int>(s1);
    result.SymmetricExceptWith(s2);
    return result;
}
