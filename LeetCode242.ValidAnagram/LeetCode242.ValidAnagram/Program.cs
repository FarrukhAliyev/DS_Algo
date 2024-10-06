namespace LeetCode242.ValidAnagram;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Solution.IsAnagram("bc", "ab"));
    }
}

public class Solution //SOLVED
{

    #region NotOptimal Solution
    //public static bool IsAnagram(string s, string t)
    //{
    //    if(s.Length != t.Length) return false;
    //    bool check = false;
    //    for (int i = 0; i < s.Length; i++)
    //    {
    //        check = false;
    //        for (int j = 0; j < t.Length; j++)
    //        {
    //            if (s[i] == t[j])
    //            {
    //                t = t.Remove(j, 1);
    //                check = true;
    //                break;
    //            }
    //        }
    //        if (!check) return false;
    //    }
    //    return true;
    //} 
    #endregion

    public static bool IsAnagram(string s, string t)
    {
        if(s.Length != t.Length) return false;

        int[] freq = new int[26];
        for(int i = 0; i < s.Length; i++)
        {
            freq[s[i] - 'a']++;
            freq[t[i] - 'a']--;
        }

        for(int i = 0;i < freq.Length; i++)
        {
            if (freq[i] != 0) return false;
        }
        return true;
    }
}