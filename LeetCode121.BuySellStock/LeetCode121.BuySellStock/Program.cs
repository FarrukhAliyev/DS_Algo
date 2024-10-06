namespace LeetCode121.BuySellStock;

internal class Program
{
    static void Main(string[] args)
    {
        int[] prices = { 6, 1, 3, 2, 4, 7 };
        int[] prices2 = { 2, 4, 1 };
        int[] prices3 = { 7, 1, 5, 3, 6, 4 };
        int[] prices4 = { 7, 6, 4, 3, 1 };
        Console.WriteLine(Solution.MaxProfit(prices4));
    }
}

public class Solution //SOLVED
{
    #region MySolution O(n^2)
    //public static int MaxProfit(int[] prices)
    //{
    //    int maxSub = 0;
    //    for (int i = 0; i < prices.Length; i++)
    //    {
    //        for(int j = i + 1; j < prices.Length; j++)
    //        {
    //            if ((prices[j] - prices[i]) > maxSub)
    //            {
    //                maxSub = prices[j] - prices[i];
    //            }
    //        }
    //    }

    //    return maxSub;
    //} 
    #endregion


    #region SecondSolution O(n)
    public static int MaxProfit(int[] prices)
    {
        int profit = 0;
        int min = prices[0];

        foreach (int price in prices)
        {
            profit = Math.Max(profit, price - min);
            min = Math.Min(min, price);
        }

        return profit;
    } 
    #endregion
}