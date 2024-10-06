namespace LeetCode108.ArrayToBinaryTree;

public class TreeNode
{
    public int Value;
    public TreeNode Left;
    public TreeNode Right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.Value = val;
        this.Left = left;
        this.Right = right;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 1, 3 };
        var tree = Solution.SortedArrayToBST(nums);
        Console.WriteLine(tree);
    }
}

public class Solution //TRY AGAIN
{
    public static TreeNode SortedArrayToBST(int[] nums)
    {
        return CreateNode(0, nums.Length - 1);

        TreeNode CreateNode(int left, int right)
        {
            if (left > right)
            {
                return null;
            }
            int mid = left + (right - left) / 2;
            return new TreeNode(nums[mid], CreateNode(left, mid - 1), CreateNode(mid + 1, right));
        }
    }
}