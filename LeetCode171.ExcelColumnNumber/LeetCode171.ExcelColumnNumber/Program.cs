namespace LeetCode171.ExcelColumnNumber;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Solution.TitleToNumber("F"));
    }
}

public class Solution
{
    public static int TitleToNumber(string columnTitle)
    {
        int result = 0;
        for (int i = 0; i < columnTitle.Length; i++)
        {
            int current = columnTitle[i] - 'A' + 1;
            result = (result * 26) + current;
        }
        return result;
    }
}