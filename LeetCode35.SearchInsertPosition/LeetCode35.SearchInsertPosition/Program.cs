namespace LeetCode35.SearchInsertPosition;

public class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 1, 3 };
        Console.WriteLine(Solution.SearchInsert(nums, 4));
    }
}

public class Solution
{
    #region O(n) Solution
    //public static int SearchInsert(int[] nums, int target)
    //{
    //    for (int i = 0; i < nums.Length; i++)
    //    {
    //        if (target == nums[i])
    //        {
    //            return i;
    //        }
    //        else if (target < nums[i]) 
    //        {
    //            return i;
    //        }
    //    }
    //    return nums.Length;
    //} 
    #endregion

    #region BinarySearch O(logn) Solution
    public static int SearchInsert(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        while (left <= right)
        {
            int middle = (left + right) / 2;
            if (nums[middle] == target) return middle;
            if (nums[middle] < target) left = middle + 1;
            else right = middle - 1;
        }
        return left;
    } 
    #endregion
}