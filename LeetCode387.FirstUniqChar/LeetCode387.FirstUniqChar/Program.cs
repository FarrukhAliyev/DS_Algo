namespace LeetCode387.FirstUniqChar;

public class Program
{
    static void Main(string[] args)
    {
        string s = "dddccdbba";
        string c = "aabb";

        Console.WriteLine(Solution.FirstUniqChar(c));

    }
}

public class Solution //Solved
{
    public static int FirstUniqChar(string s)
    {

        #region FirstSolution
        //Dictionary<char, int> kVP = new();

        //for (int i = 0; i < s.Length; i++)
        //{
        //    if (!kVP.ContainsKey(s[i]))
        //    {
        //        kVP.Add(s[i], 1);
        //    }
        //    else
        //    {
        //        kVP[s[i]]++;
        //    }
        //}


        //for (int i = 0; i < s.Length; i++)
        //{
        //    if (kVP.GetValueOrDefault(s[i]) == 1)
        //    {
        //        return i;
        //    }
        //}
        //return -1; 
        #endregion

        #region SecondSolution
        if (s.Length == 1) return 0;
        bool check = false;
        char[] chars = new char[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            check = false;
            for (int j = i + 1; j < s.Length; j++) 
            {
                if (s[i] == s[j])
                {
                    chars[i] = s[i];
                    break;
                }
            }
            for (int j = 0; j < chars.Length; j++)
            {
                if (s[i] == chars[j])
                {
                    check = true;
                    break;
                }
            }
            if (!check) return i;
        }
        return -1;
        #endregion
    }
}