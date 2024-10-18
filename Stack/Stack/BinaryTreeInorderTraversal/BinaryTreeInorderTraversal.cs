public class BinaryTreeInorderTraversal
{

    //Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    private static IList<int> stack = new List<int>();
    public static IList<int> InorderTraversal(TreeNode node)
    {

        if (node == null)
            return [];
        InorderTraversal(node.left);
        stack.Add(node.val);
        InorderTraversal(node.right);
        return stack.ToList();
    }

    public static void Main(string[] args)
    {
        // Create the binary tree as shown in the example
        TreeNode root = new TreeNode(1);
        root.right = new TreeNode(2);
        root.right.left = new TreeNode(3);
        //root.left.right = new TreeNode(5);
        //root.right.right = new TreeNode(8);
        //root.left.right.left = new TreeNode(6);
        //root.left.right.right = new TreeNode(7);
        //root.right.right.left = new TreeNode(9);

        // Call the InorderTraversal method
        IList<int> result = InorderTraversal(root);

        // Print the result
        Console.WriteLine("Inorder Traversal:");
        foreach (int val in result)
        {
            Console.Write(val + " ");
        }
        Console.WriteLine();
    }
}