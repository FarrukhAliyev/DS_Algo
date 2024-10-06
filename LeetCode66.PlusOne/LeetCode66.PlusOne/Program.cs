namespace PlusOne;

public class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7, 9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7, 4, 0, 0, 6 };
        int[] nums2 = { 9, 9, 9 };
        int[] nums3 = { 0 };

        foreach (int x in Solution.PlusOne(nums3))
        {
            Console.WriteLine(x);
        }
    }
}

public class Solution // SOLVED
{
    #region NotEnoughSpace
    //public static int[] PlusOne(int[] digits)
    //{
    //    decimal initialDigit = 0;
    //    for (int i = 0; i < digits.Length; i++)
    //    {
    //        initialDigit += digits[i];
    //        if (i != digits.Length - 1)
    //        {
    //            initialDigit *= 10;
    //        }
    //        else
    //        {
    //            initialDigit += 1;
    //        }
    //    }

    //    int[] result = new int[initialDigit.ToString().Length];

    //    for (int i = result.Length - 1; i >= 0; i--)
    //    {
    //        result[i] = (int)(initialDigit % 10);
    //        initialDigit /= 10;
    //    }

    //    return result;
    //}
    #endregion

    public static int[] PlusOne(int[] digits)
    {

        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] + 1 == 10 && i == 0)
            {
                Array.Resize(ref digits, digits.Length + 1);
                digits[0] = 1;
                return digits;
            }
            if (digits[i] + 1 < 10)
            {
                digits[i] += 1;
                break;
            }
            else
            {
                digits[i] = 0;
            }

            
        }

        return digits;
    }
}