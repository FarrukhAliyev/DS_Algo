using System.Text;

namespace LeetCode131.PalindromePartitioning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Every alphabet
            //Polindrome
            string s = "abaabaacbbca";
            string c = "abcaa";
            string d = "abbaa";

            foreach (var list in Solution.Partition(d))
            {
                foreach (var item in list)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }


        #region MySolution

        //public static IList<IList<string>> Partition(string s)
        //{
        //    List<IList<string>> result = new List<IList<string>>();
        //    for (int i = 1; i <= s.Length; i++)
        //    {
        //        StringBuilder copyString = new(s);
        //        List<string> subStrList = new();

        //        for (int j = 0; j < s.Length; j += i)
        //        {
        //            if (i + j > s.Length)
        //            {
        //                break;
        //            }

        //            var subStr = s.Substring(j, i);

        //            if (IsPolindrome(subStr) && !String.IsNullOrEmpty(subStr))
        //            {
        //                copyString.Replace(subStr, new String(' ', subStr.Length), j, i);
        //                subStrList.Add(subStr);
        //            }
        //        }
        //        if (!String.IsNullOrWhiteSpace(copyString.ToString()) && !(i != 1 && copyString.ToString() == s))
        //        {
        //            foreach (var letter in copyString.ToString())
        //            {
        //                if (!Char.IsWhiteSpace(letter))
        //                {
        //                    subStrList.Add(letter.ToString());
        //                }
        //            }
        //        }
        //        if (subStrList.Count != 0)
        //        {
        //            result.Add(subStrList);
        //        }
        //    }

        //    return result;

        //}

        //public static bool IsPolindrome(string s)
        //{
        //    StringBuilder reverseSub = new();
        //    for (int k = s.Length - 1; k >= 0; k--)
        //    {
        //        reverseSub.Append(s[k]);
        //    }

        //    if (reverseSub.ToString() == s) return true;

        //    return false;
        //}

        #endregion

        #region BacktrackingSolution
        public class Solution
        {
            public static IList<IList<string>> Partition(string s)
            {
                var result = new List<IList<string>>();
                DFS(0, result, new List<string>(), s);
                return result;
            }

            static void DFS(int start, List<IList<string>> result, List<string> currentList, string s)
            {
                if (start >= s.Length)
                {
                    result.Add(new List<string>(currentList));
                }
                for (int end = start; end < s.Length; end++)
                {
                    if (isPalindrome(s, start, end))
                    {
                        // add current substring in the currentList
                        currentList.Add(s.Substring(start, end - start + 1));
                        DFS(end + 1, result, currentList, s);
                        // backtrack and remove the current substring from currentList
                        currentList.RemoveAt(currentList.Count - 1);
                    }
                }
            }

            static bool isPalindrome(string s, int low, int high)
            {
                while (low < high)
                {
                    if (s[low++] != s[high--])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        #endregion
    }
}