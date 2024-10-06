namespace NumOfEachCharInStr;

public class Program
{
    static void Main(string[] args)
    {
        foreach (var kvp in EachCharInStr("Tassako"))
        {
            Console.WriteLine($"{kvp.Key}:{kvp.Value}");
        }
    }

    static Dictionary<char, int> EachCharInStr(string str)
    {
        Dictionary<char, int> result = new();

        foreach (char c in str)
        {
            if (result.ContainsKey(c))
            {
                result[c]++;
            }
            else 
            {
                result.Add(c, 1);
            }
        }

        return result;
    }
}
