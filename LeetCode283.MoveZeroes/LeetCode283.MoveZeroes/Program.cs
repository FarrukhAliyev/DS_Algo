namespace LeetCode283.MoveZeroes;

public class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 0, 1, 0, 3, 12 };
        
        Solution.MoveZeroes(nums);
    }
}

public class Solution //SOLVED
{
    #region CasualTransferSolution
    //public static void MoveZeroes(int[] nums)
    //{
    //    int count = 0;

    //    for (int i = 0; i < nums.Length; i++)
    //    {
    //        if (nums[i] != 0)
    //        {
    //            var temp = nums[i];
    //            nums[i] = nums[count];
    //            nums[count] = temp;

    //            count++;
    //        }
    //    }

    //    foreach (var item in nums)
    //    {
    //        Console.WriteLine(item);
    //    }
    //} 
    #endregion

    #region AnormalTransferSolution
    public static void MoveZeroes(int[] nums)
    {
        int count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                (nums[i], nums[count]) = (nums[count], nums[i]);
                count++;
            }
        }

        foreach (var item in nums)
        {
            Console.WriteLine(item);
        }
    }
    #endregion
}