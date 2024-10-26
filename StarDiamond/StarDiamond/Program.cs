namespace StarDiamond;

public class Program
{
    static void Main(string[] args)
    {
        var charArr = DiamondMaker(5);
        for (int i = 0; i < charArr.GetLength(0); i++)
        {
            for (int j = 0; j < charArr.GetLength(1); j++)
            {
                Console.Write(charArr[i, j]);
            }
            Console.WriteLine();
        }
    }

    static char[,] DiamondMaker(int num)
    {
        char[,] result = new char[num, num];

        for (int i = 0; i < (result.GetLength(0) + 1) / 2; i++)
        {
            int pos = (num - (i * 2)) / 2;
            for (int j = 0; j < result.GetLength(1); j++)
            {
                if (j >= pos && j <= num - 1 - pos)
                {
                    result[i, j] = '*';
                    result[result.GetLength(0) - 1 - i, j] = '*';
                }
                else
                {
                    result[i, j] = ' ';
                    result[result.GetLength(0) - 1 - i, j] = ' ';
                }
            }
        }

        return result;
    }
}
