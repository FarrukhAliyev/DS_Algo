using System.Text;

namespace LeetCode1790.OneStringSwap;

public class Program
{
    static void Main(string[] args)
    {
        string s1 = "belk";
        string s2 = "kelb";
        Console.WriteLine(Solution.AreAlmostEqual(s1, s2));
    }
}

public class Solution //SOLVED
{
    #region O(n^2) Solution
    //public static bool AreAlmostEqual(string s1, string s2)
    //{
    //    if (s1.Length != s2.Length) return false;
    //    if (s1.Equals(s2)) return true;

    //    StringBuilder sb = new();
    //    for (int i = 0; i < s1.Length - 1; i++)
    //    {
    //        for (int j = i + 1; j < s1.Length; j++)
    //        {
    //            sb.Clear();
    //            sb.Append(s1);
    //            var temp = sb[i];
    //            sb[i] = sb[j];
    //            sb[j] = temp;
    //            if (sb.ToString() == s2) return true;
    //        }
    //    }
    //    return false;
    //} 
    #endregion

    #region O(n) HashSet Solution
    public static bool AreAlmostEqual(string s1, string s2)
    {
        if (s1 == s2) return true;
        HashSet<char> set1 = new HashSet<char>();
        HashSet<char> set2 = new HashSet<char>();
        int changes = 0;
        for (int i = 0; i < s1.Length; i++)
            if (s1[i] != s2[i])
            {
                set1.Add(s1[i]);
                set2.Add(s2[i]);
                changes++;
            }
        foreach (var ele in set1)
            if (set2.Contains(ele)) set2.Remove(ele);
        return (changes == 2 && set2.Count == 0);
    }
    #endregion
}