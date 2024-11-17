using System.Collections;

namespace LeetCode128.LongestConsecutiveSequence;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(LongestConsecutive(new int[] { 9, 1, 4, 7, 3, -1, 0, 5, 8, -1, 6 }));
        Console.WriteLine(LongestConsecutive(new int[] { 0, -1 }));
    }

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
