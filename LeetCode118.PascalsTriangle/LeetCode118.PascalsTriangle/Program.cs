namespace LeetCode118.PascalsTriangle;

public class Program
{
    static void Main(string[] args)
    {
        foreach (var list in Solution.Generate(10))
        {
            foreach (var item in list)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();
        }
    }
}

public class Solution //SOLVED
{
    public static IList<IList<int>> Generate(int numRows)
    {
        List<IList<int>> result = new(numRows) { new List<int> { 1 } };
        for (int i = 1; i < numRows; i++)
        {
            List<int> list = new(i + 1);
            for (int j = 0; j < i + 1; j++)
            {
                if (j == 0 || j == list.Capacity - 1)
                {
                    list.Add(1);
                    continue;
                }
                list.Add(result[i - 1][j] + result[i - 1][j - 1]);
            }
            result.Add(list);
        }

        return result;
    }
}