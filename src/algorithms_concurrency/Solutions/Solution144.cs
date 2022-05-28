// ReSharper disable InconsistentNaming
namespace MyNihongo.Leetcode.Solutions;

/// <summary>
/// Given the root of a binary tree, return the preorder traversal of its nodes' values.
/// </summary>
public sealed class Solution144
{
	public static IList<int> PreorderTraversal(TreeNode? root)
	{
		if (root == null)
			return Array.Empty<int>();

		var stack = new Stack<TreeNode>();
		stack.Push(root);

		var list = new List<int>(1);
		while (stack.Count != 0)
		{
			var node = stack.Pop();
			list.Add(node.val);

			if (node.right != null)
				stack.Push(node.right);
			if (node.left != null)
				stack.Push(node.left);
		}

		return list;
	}

	public sealed class TreeNode
	{
		public int val;
		public TreeNode? left;
		public TreeNode? right;

		public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
		{
			this.val = val;
			this.left = left;
			this.right = right;
		}

		public override string ToString()
		{
			return val.ToString();
		}
	}
}
