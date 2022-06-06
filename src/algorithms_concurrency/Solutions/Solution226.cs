namespace MyNihongo.Leetcode.Solutions;

/// <summary>
/// Given the root of a binary tree, invert the tree, and return its root.
/// </summary>
public sealed class Solution226
{
	public static TreeNode? InvertTree(TreeNode? root)
	{
		if (root == null)
			return null;

		var stack = new Stack<TreeNode>();
		stack.Push(root);

		while (stack.Count != 0)
		{
			var node = stack.Pop();

			if (node.right != null)
				stack.Push(node.right);
			if (node.left != null)
				stack.Push(node.left);

			(node.left, node.right) = (node.right, node.left);
		}

		return root;
	}
}
