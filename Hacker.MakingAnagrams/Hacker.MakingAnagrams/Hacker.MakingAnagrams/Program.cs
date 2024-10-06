using System.Text;

namespace Hacker.MakingAnagrams;

public class Program
{
    static void Main(string[] args)
    {
        string a = "cde";
        string b = "abc";

        Console.WriteLine(Result.MakeAnagram(a,b));
    }
}

class Result // SOLVED
{
    public static int MakeAnagram(string a, string b)
    {
        bool check;
        int count = 0;
        for (int i = 0; i < a.Length; i++)
        {
            check = false;
            for (int j = 0; j < b.Length; j++)
            {
                if (a[i] == b[j])
                {
                    b = b.Remove(j,1);
                    check = true;
                    break;
                }
            }
            if (!check)
            {
                count++;
            }
        }
        count += b.Length;
        return count;
    }
}