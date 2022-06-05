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
}
