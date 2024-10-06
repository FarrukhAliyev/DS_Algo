namespace LeetCode169.MajorityElement;

public class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 2, 2, 1, 1, 1, 1, 2 };
        Console.WriteLine(Solution.MajorElement(nums));
    }
}

public class Solution //SOLVED
{
    #region FirstSolution
    //public static int MajorElement(int[] nums)
    //{
    //    Dictionary<int, int> elementCount = new();

    //    for (int i = 0; i < nums.Length; i++)
    //    {
    //        if (!elementCount.ContainsKey(nums[i]))
    //        {
    //            elementCount.Add(nums[i], 1);
    //        }
    //        else
    //        {
    //            elementCount[nums[i]]++;
    //        }
    //    }

    //    return elementCount.FirstOrDefault(l => l.Value > (nums.Length / 2)).Key; 
    //}
    #endregion

    #region SecondSolution
    //public static int MajorElement(int[] nums)
    //{
    //    int count = 1;

    //    for (int i = 0; i < nums.Length - 1; i++)
    //    {
    //        count = 1;
    //        for (int j = i + 1; j < nums.Length; j++)
    //        {
    //            if (nums[i] == nums[j])
    //            {
    //                count++;
    //            }
    //        }

    //        if (count > (nums.Length / 2))
    //        {
    //            return nums[i];
    //        }
    //    }

    //    return nums[0];
    //}
    #endregion

    #region ThirdSolution
    public static int MajorElement(int[] nums)
    {
        int count = 0;
        int? candidate = null;

        //foreach (int num in nums)
        //{
        //    candidate = (count == 0) ? num : candidate;
        //    count += (candidate == num) ? 1 : -1; 
        //}

        foreach (var num in nums)
        {
            if (count == 0)
            {
                candidate = num;
            }

            if (candidate == num)
            {
                count += 1;
            }
            else
            {
                count -= 1;
            }
        }

        return candidate.Value;
    } 
    #endregion
}