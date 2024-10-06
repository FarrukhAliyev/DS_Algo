using System.Security.Cryptography.X509Certificates;

namespace LeetCode205.IsomorphicStrings;

public class Program
{
    static void Main(string[] args)
    {
        string s = "aabbbaba";
        string t = "bbaaaabb";

        Console.WriteLine(Solution.IsIsomorphic(s, t));
    }
}

public class Solution //SOLVED
{
    //public static bool IsIsomorphic(string s, string t)
    //{
    //    Dictionary<char, int> set = new();

    //    foreach (char c in s)
    //    {
    //        if (!set.ContainsKey(c))
    //        {
    //            set.Add(c, 1);
    //        }
    //        else
    //        {
    //            set[c]++;
    //        }
    //    }

    //    Dictionary<char, int> set2 = new();

    //    foreach (char c in t)
    //    {
    //        if (!set2.ContainsKey(c))
    //        {
    //            set2.Add(c, 1);
    //        }
    //        else
    //        {
    //            set2[c]++;
    //        }
    //    }
    //    return set.Values.SequenceEqual(set2.Values);
    //}

    public static bool IsIsomorphic(string s, string t)
    {
        var dict = new Dictionary<char, char>();
        for (int i = 0; i < s.Length; i++)
        {
            char ss = s[i];
            char st = t[i];
            if (dict.ContainsKey(ss))
            {
                if (st != dict[ss]) return false;
            }
            else
            {
                if (dict.ContainsValue(st)) return false;
                dict.Add(ss, st);
            }
        }
        return true;
    }
}