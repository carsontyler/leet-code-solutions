namespace LeetCodeSolutions.ConsoleApp.Problems;

public class BSTMinAbsoluteDiff
{
    public static void Run(){
        var input = new TreeNode(4, new TreeNode(2), new TreeNode(6));

        var result = GetMinimumDifference(input);

        var expected = 2;
        
        Console.WriteLine("BST Min Absolute Diff Success: " + (result == expected));
    }
    
    private static int min = int.MaxValue;
    private static int? prev = null;

    private static int GetMinimumDifference(TreeNode root) {
        if (root == null)
            return min;
            
        GetMinimumDifference(root.left);

        if (prev != null){
            min = Math.Min(min, root.val - prev.Value);
        }
        prev = root.val;

        GetMinimumDifference(root.right);

        return min;
    }

    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
 
}
