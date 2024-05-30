namespace LeetCodeSolutions.ConsoleApp.Problems;

public class BinaryTreeRightSide
{
    public static void Run(){
        var input = new TreeNode(1, null, new TreeNode(3));

        var result = RightSideView(input);

        var expected = new List<int>() {1, 3};

        var success = true;

        for (int i = 0; i < result.Count; i++){
            if (result[i] != expected[i])
                success = false;
        }

        Console.WriteLine("Binary Tree Right Side Success: " + success);
    }

    private static IList<int> RightSideView(TreeNode root) {
        var result = new List<int>();

        if (root == null) 
            return result;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0){
            result.Add(queue.Peek().val);

            int count = queue.Count;
            while (count > 0){
                var node = queue.Dequeue();
                count--;

                if (node.right != null)
                    queue.Enqueue(node.right);
                if (node.left != null)
                    queue.Enqueue(node.left);
            }
        }

        return result;
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
