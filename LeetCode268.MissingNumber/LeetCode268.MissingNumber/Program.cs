namespace LeetCode268.MissingNumber;

public class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 3, 0, 1 };
        Console.WriteLine(Solution.MissingNumber(nums));
    }
}

public class Solution
{
    #region O(n^2) Solution
    //public static int MissingNumber(int[] nums)
    //{
    //    bool check = false;
    //    for (int i = 0; i <= nums.Length; i++)
    //    {
    //        check = false;
    //        for (int j = 0; j < nums.Length; j++)
    //        {
    //            if (nums[j] == i)
    //            {
    //                check = true;
    //                break;
    //            }
    //        }
    //        if (!check) return i;
    //    }
    //    return -1;
    //} 
    #endregion

    #region O(n) Solution
    public static int MissingNumber(int[] nums)
    {
        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == count)
            {
                count++;
                i = -1;
            }
            else if (i == nums.Length - 1) return count;
        }
        return -1;
    }
    #endregion

    #region OneLineSolution
    //public static int MissingNumber(int[] nums)
    //{
    //    return nums.Length * (nums.Length + 1) / 2 - nums.Sum();
    //} 
    #endregion

    #region XOR Solution
    //public static int MissingNumber(int[] nums)
    //{
    //    int x = nums.Length;

    //    for (int i = 0; i < nums.Length; i++)
    //    {
    //        x ^= i ^ nums[i];
    //    }

    //    return x;
    //} 
    #endregion
}