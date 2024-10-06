namespace LeetCode26.RemoveDuplicates;

public class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        int[] nums2 = { 1, 1, 2 };
        //Console.WriteLine(Solution.RemoveDuplicates(nums2));
        foreach (int i in Solution.RemoveDuplicates(nums2))
        {
            Console.WriteLine(i);
        }
    }
}

public class Solution //SOLVED
{
    public static int[] RemoveDuplicates(int[] nums)
    {
        int count = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                nums[count] = nums[i];
                count++;
            }
        }
        return nums;
    }

    //public static int RemoveDuplicates(int[] nums)
    //{
    //    int i = 1;

    //    foreach (int n in nums)
    //    {
    //        if (nums[i - 1] != n) nums[i++] = n;
    //    }

    //    return i;
    //}
}