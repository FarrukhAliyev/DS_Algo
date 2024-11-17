using System.Collections;

namespace LeetCode128.LongestConsecutiveSequence;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(LongestConsecutive(new int[] { 9, 1, 4, 7, 3, -1, 0, 5, 8, -1, 6 }));
        //Console.WriteLine(LongestConsecutive(new int[] { 0, -1 }));
    }

    //static int LongestConsecutive(int[] nums)
    //{
    //    if(nums.Length == 0) return 0;

    //    int count = 1;

    //    int pos = 0;

    //    int element = nums[0];

    //    List<int> consecutiveList = new() { 1 };

    //    for (int i = 0; i < nums.Length; i++) 
    //    {
    //        if (nums[i] == element + count)
    //        {
    //            count++;
    //            i = -1;
    //        }

    //        if (i == nums.Length - 1)
    //        {
    //            consecutiveList.Add(count);
    //            count = 1;
    //            if (pos == nums.Length - 1) break;
    //            element = nums[++pos];
    //            i = -1;
    //        }
    //    }

    //    return consecutiveList.Max(x => x);
    //}

    static int LongestConsecutive(int[] nums)
    {
        HashSet<int> numSet = new HashSet<int>(nums);
        int longest = 0;

        foreach (int n in numSet)
        {
            if (!numSet.Contains(n - 1))
            {
                int length = 1;

                while (numSet.Contains(n + length))
                {
                    length++;
                }

                longest = longest > length ? longest : length;
            }
        }

        return longest;
    }
}
