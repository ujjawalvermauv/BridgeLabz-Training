static void UnionIntersection(HashSet<int> s1, HashSet<int> s2)
{
    HashSet<int> union = new HashSet<int>(s1);
    union.UnionWith(s2);

    HashSet<int> intersection = new HashSet<int>(s1);
    intersection.IntersectWith(s2);
}
