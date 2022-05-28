// ReSharper disable InconsistentNaming
namespace MyNihongo.Leetcode.Solutions;

/// <summary>
/// Given the root of a binary tree, check whether it is a <i>mirror of itself</i> (i.e., symmetric around its center).
/// </summary>
public sealed class Solution101
{
	public static bool IsSymmetric(TreeNode? root)
	{
		if (root == null)
			return false;

		if (root.right == null)
			return root.left == null;
		if (root.left == null)
			return false;

		Stack<TreeNode> leftStack = new(), rightStack = new();

		leftStack.Push(root.left);
		rightStack.Push(root.right);

		while (leftStack.Count != 0)
		{
			var left = leftStack.Pop();
			var right = rightStack.Pop();

			if (left.val != right.val)
				return false;

			if (left.left != null)
			{
				if (right.right == null)
					return false;

				leftStack.Push(left.left);
				rightStack.Push(right.right);
			}
			else if (right.right != null)
				return false;

			if (left.right != null)
			{
				if (right.left == null)
					return false;

				leftStack.Push(left.right);
				rightStack.Push(right.left);
			}
			else if (right.left != null)
				return false;
		}

		return true;
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
	}
}
