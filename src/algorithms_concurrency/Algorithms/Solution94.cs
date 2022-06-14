// ReSharper disable InconsistentNaming
namespace MyNihongo.Leetcode.Algorithms;

/// <summary>
/// Given the root of a binary tree, return the inorder traversal of its nodes' values.
/// </summary>
public sealed class Solution94
{
	public static IList<int> InorderTraversal(TreeNode? root)
	{
		if (root == null)
			return Array.Empty<int>();

		var list = new List<int>();
		var stack = new Stack<TreeNode>();

		while (root != null || stack.Count > 0)
		{
			// Reach the left
			while (root != null)
			{
				stack.Push(root);
				root = root.left;
			}

			root = stack.Pop();
			list.Add(root.val);

			// Reach the right
			root = root.right;
		}

		return list;
	}
}
