public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Solution.Fib(4));
    }
}

public class Solution
{
    //public static int Fib(int n)
    //{
    //    List<int> arr = new() { 0,1 };

    //    for (int i = 2; i <= n; i++)
    //    {
    //        arr.Add(arr[i - 1] + arr[i - 2]);
    //    }

    //    return arr[n];
    //}

    public static int Fib(int n)
    {
        if(n <= 1)
        {
            return n;
        }

        int x = Fib(n - 1);
        int y = Fib(n - 2);
        return x + y;
    }
}
