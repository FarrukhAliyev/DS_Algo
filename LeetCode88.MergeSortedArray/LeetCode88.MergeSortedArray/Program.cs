using System.Diagnostics;

namespace LeetCode88.MergeSortedArray;

public class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 1, 2, 3, 0, 0, 0 };
        int[] nums2 = { 2, 5, 6 };

        //foreach (int i in Solution.Merge(nums, 3, nums2, 3))
        //{
        //    Console.WriteLine(i);
        //}
        Solution.Merge(nums, 3, nums2, 3);
    }
}

public class Solution
{
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        Stopwatch sw = Stopwatch.StartNew();
        for (int i = m; i < m + n; i++)
        {
            nums1[i] = nums2[i - m];
        }

        for (int i = 0; i < nums1.Length; i++)
        {
            for (int j = i + 1; j < nums1.Length; j++)
            {
                if (nums1[j] < nums1[i])
                {
                    var temp = nums1[j];
                    nums1[j] = nums1[i];
                    nums1[i] = temp;
                }
            }
        }
        //Array.Sort(nums1);
        sw.Stop();
        Console.WriteLine(sw.Elapsed);
    }
}