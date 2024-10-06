using System.Text;

namespace LeetCode125.ValidPalindrome;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Solution.IsPalindrome("A man, a plan, a canal: Panama"));
    }
}

public class Solution //SOLVED
{
    public static bool IsPalindrome(string s)
    {
        StringBuilder sb = new();

        for (int i = 0; i < s.Length; i++)
        {
            if (Char.IsLetterOrDigit(s[i]) && s[i] != ' ')
            {
                sb.Append(Char.ToLower(s[i]));
            }
        }


        for (int i = 0; i < sb.Length/2 ; i++)
        {
            if (sb[i] != sb[sb.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
}