using System.Text;

namespace LeetCode1662.CheckTwoStringArrays;

public class Program
{
    static void Main(string[] args)
    {
        string[] word1 = { "ab", "c" };
        string[] word2 = { "a", "bc" };
        Console.WriteLine(Solution.ArrayStringsAreEqual(word1, word2));
    }
}

public class Solution //SOLVED
{
    public static bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        StringBuilder sb1 = new();
        foreach (string s in word1)
        {
            sb1.Append(s);
        }

        StringBuilder sb2 = new();
        foreach (string s in word2)
        {
            sb2.Append(s);
        }

        return sb1.Equals(sb2);
    }
}