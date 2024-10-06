namespace LeetCode344.ReverseString;

public class Program
{
    static void Main(string[] args)
    {
        char[] s = { 'h', 'e', 'l', 'l', 'o', 'm' };

        Solution.ReverseString(ref s);

        foreach (var item in s)
        {
            Console.WriteLine(item);
        }
    }
}

public class Solution //Solved
{
    public static void ReverseString(ref char[] s)
    {
        for (int i = 0; i < s.Length/2; i++)
        {
            var temp = s[i];
            s[i] = s[s.Length - 1 - i];
            s[s.Length - 1 - i] = temp;
        }
    }
}