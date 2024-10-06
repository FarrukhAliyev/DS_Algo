using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        //Console.WriteLine(decryptPassword("aP1pL5e"));
        Console.WriteLine(minTime(new List<int> { 3, 1, 5 }, 1, 5));
        Console.WriteLine(minTime(new List<int> { 130291875, 474356040, 1 }, 1, 8));
    }

    public static string decryptPassword(string s)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '0') continue;
                if (i != s.Length - 1 && Char.IsLower(s[i]) && Char.IsUpper(s[i + 1]))
            {
                sb.Append(new char[] { s[i + 1], s[i], '*' });
                i += 1;
            }
            else if (Char.IsNumber(s[i]))
            {
                sb = new StringBuilder(s[i] + sb.ToString() + '0');
            }
            else
            {
                sb.Append(s[i]);
            }
        }
        return sb.ToString();
    }

    public static long minTime(List<int> files, int numCores, int limit)
    {
        while(limit > 0)
        {
            int max = maxDividableByCores(files, numCores);

            for (int i = 0; i < files.Count; i++)
            {
                if (files[i] == max && max % numCores == 0)
                {
                    files[i] /= numCores;
                    break;
                }
            }
            limit--;
        }
        return files.Sum(x => (long)x);
    }

    public static int maxDividableByCores(List<int> files, int numCores)
    {
        int max = files[0];
        for (int i = 0; i < files.Count; i++)
        {
            if (files[i] > max && files[i] % numCores == 0)
            {
                max = files[i];
            }
        }
        return max;
    }
}