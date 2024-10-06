using System.Linq;

namespace LeetCode350.IntersectionTwoArrays;

public class Program
{
    static void Main(string[] args)
    {
        int[] nums1 = { 1, 2, 2, 1 };
        int[] nums2 = { 2 };

        int[] result = Solution.Intersect(nums1, nums2);

        foreach (int i in result)
        {
            Console.WriteLine(i);
        }
    }
}

public class Solution //SOLVED
{
    public static int[] Intersect(int[] nums1, int[] nums2)
    {
        int length = nums1.Length < nums2.Length ? nums1.Length : nums2.Length;
        List<int> result = new List<int>();

        int count = 0;

        for (int i = 0; i < nums1.Length; i++)
        {
            for (int j = count; j < nums2.Length; j++)
            {
                if (nums1[i] == nums2[j])
                {
                    (nums2[j], nums2[count]) = (nums2[count], nums2[j]);
                    result.Add(nums1[i]);
                    count++;
                    break;
                }
            }
        }

        return result.ToArray();
    }
}