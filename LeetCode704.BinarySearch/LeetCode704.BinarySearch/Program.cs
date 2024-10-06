namespace LeetCode704.BinarySearch;

public class Program
{
    static void Main(string[] args)
    {
        int[] nums = { -1, 0, 3, 5, 9, 12 };
        Console.WriteLine(Solution.Search(nums, 13));
    }
}


public class Solution //SOLVED
{
    public static int Search(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length;
        int mid = 0;
        while (left < right)
        {
            mid = (left + right) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        if (left < nums.Length && nums[left] == target) return left;
        else return -1;
    }
}