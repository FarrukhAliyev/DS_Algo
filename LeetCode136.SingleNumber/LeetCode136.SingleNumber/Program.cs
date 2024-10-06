namespace LeetCode136.SingleNumber;

public class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 4, 1, 2, 1, 2 };

        Console.WriteLine(Solution.SingleNumber(nums));
    }
}

public class Solution //SOLVED
{
    public static int SingleNumbero(int[] nums)
    {
        Dictionary<int, int> elementCounts = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (elementCounts.ContainsKey(nums[i]))
            {
                elementCounts[nums[i]]++;
            }
            else
            {
                elementCounts.Add(nums[i], 1);
            }
        }

        return elementCounts.FirstOrDefault(l => l.Value == 1).Key;
    }

    public static int SingleNumber(int[] nums) //XOR Bitwise Operator
    {
        var result = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            result ^= nums[i];
        }
        return result;
    }
}