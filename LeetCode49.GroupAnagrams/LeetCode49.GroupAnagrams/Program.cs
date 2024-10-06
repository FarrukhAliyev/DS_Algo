using System.Text;

namespace LeetCode49.GroupAnagrams;

public class Program
{
    static void Main(string[] args)
    {
        string[] strs = { "hhhhu", "tttti", "tttit", "hhhuh", "hhuhh", "tittt" };

        //Check
        // String length
        // Empty or not
        //foreach (var item in Solution.GroupAnagrams(strs))
        //{
        //    foreach (var str in item)
        //    {
        //        Console.Write(str + " ");
        //    }
        //    Console.WriteLine();
        //}

        Console.WriteLine(Solution.CountSort(strs[4]));
    }
}

public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        if (strs.Length == 0)
        {
            return new List<IList<string>>();
        }

        Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();

        foreach (string str in strs)
        {
            string sortedStr = CountSort(str);
            if (!anagrams.ContainsKey(sortedStr))
            {
                anagrams.Add(sortedStr, new List<string>());
            }

            anagrams[sortedStr].Add(str);
        }

        IList<IList<string>> result = new List<IList<string>>();
        foreach (KeyValuePair<string, List<string>> kvp in anagrams)
        {
            result.Add(kvp.Value);
        }
        return result;
    }

    public static string CountSort(string str)
    {
        StringBuilder sorted = new(str);
        for (int i = 0; i < sorted.Length; i++)
        {
            for (int j = 1; j < sorted.Length; j++)
            {
                if (sorted[j] < sorted[i])
                {
                    char temp = sorted[j];
                    sorted[j] = sorted[i];
                    sorted[i] = temp;
                }
            }
        }
        return sorted.ToString();
    }
}