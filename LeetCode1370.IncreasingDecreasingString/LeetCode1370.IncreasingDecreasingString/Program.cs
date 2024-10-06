using System.Security.Cryptography;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        //Console.WriteLine(Solution.SortString("aaaabbbbcccc"));
        //Console.WriteLine(Solution.SortString("rat"));

        //Console.WriteLine('\0' - 'a' + 1);

        int[] a = new int[10000];

        int[] b = new int[100];

        int count = 0;

        for (int i = 0; i < a.Length; i++)
        {
            a[i] = RandomNumberGenerator.GetInt32(0, 100);
        }

        for (int i = 0;i < a.Length; i++)
        {
            b[a[i]]++;
        }

        for(int i = 0; i< b.Length ; i++)
        {
            if (i == 55) Console.WriteLine($"{i} - {b[i]}");
        }

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == 55)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}

public class Solution
{
    public static string SortString(string s)
    {
        StringBuilder initial = new(s);

        StringBuilder result = new();

        while(initial.Length > 0)
        {
            result.Append(FromSmallest(initial));
            result.Append(FromBiggest(initial));
        }

        return result.ToString();
    }

    public static string FromSmallest(StringBuilder initial)
    {
        char min = '\0';
        bool check = true;

        StringBuilder result = new();

        while (check)
        {
            check = false;
            min = '\0';
            for (int i = 0; i < initial.Length; i++)
            {
                if (AlphabetNumber(initial[i]) < AlphabetNumber(min) && !result.ToString().Contains(initial[i]))
                {
                    min = initial[i];
                    check = true;
                }
            }
            CharDelete(initial, min);
            if(min != '\0') result.Append(min);
        }

        return result.ToString();
    }
    
    public static string FromBiggest(StringBuilder initial)
    {
        char max = '_';
        bool check = true;

        StringBuilder result = new();

        while (check)
        {
            check = false;
            max = '_';
            for (int i = 0; i < initial.Length; i++)
            {
                if (AlphabetNumber(initial[i]) > AlphabetNumber(max) && !result.ToString().Contains(initial[i]))
                {
                    max = initial[i];
                    check = true;
                }
            }
            CharDelete(initial, max);

            if(max != '_') result.Append(max);
        }

        return result.ToString();
    }

    public static StringBuilder CharDelete(StringBuilder sBuilder, char c)
    {
        for (int i = 0; i < sBuilder.Length; i++)
        {
            if (sBuilder[i] == c)
            {
                return sBuilder.Remove(i, 1);
            }
        }

        return sBuilder;
    }

    public static int AlphabetNumber(char c)
    {
        if (c == '\0') return 100;
        if (c == '_') return 0;
        return c - 'a' + 1;
    }
}