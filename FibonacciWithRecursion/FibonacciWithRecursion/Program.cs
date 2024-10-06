namespace FibonacciWithRecursion;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Fibonacci(6));
    }

    public static int Fibonacci(int position)
    {
        if (position < 0) 
            throw new ArgumentOutOfRangeException();

        switch (position)
        {
            case 0:
                return 0;
            case 1:
                return 1;
            default:
                return Fibonacci(position - 2) + Fibonacci(position - 1);
        };
            
    }
}
