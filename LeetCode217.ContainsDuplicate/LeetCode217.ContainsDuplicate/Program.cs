namespace LeetCode217.ContainsDuplicate;

public class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 1, 2, 3 };
        Console.WriteLine(Solution.ContainsDuplicate(nums));
    }
}

public class Solution //SOLVED
{
    public static bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!set.Add(nums[i]))
            {
                return true;
            }
        }
        return false;
    }
}