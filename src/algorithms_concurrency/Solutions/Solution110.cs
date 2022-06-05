// ReSharper disable InconsistentNaming
namespace MyNihongo.Leetcode.Solutions;

/// <summary>
/// Given a binary tree, determine if it is height-balanced.<br/>
/// For this problem, a height-balanced binary tree is defined as:<br/>
/// <i>a binary tree in which the left and right subtrees of every node differ in height by no more than 1.</i>
/// </summary>
public sealed class Solution110
{
	// TODO: iterative
	public static bool IsBalanced(TreeNode? root)
	{
		return GetHeight(root) != -1;

		// Returns -1 if not balanced
		static int GetHeight(TreeNode? root)
		{
			if (root == null)
				return 0;

			var left = GetHeight(root.left);
			var right = GetHeight(root.right);

			if (Math.Abs(left - right) > 1)
				return -1;
			if (left == -1 || right == -1)
				return -1;

			return (left > right ? left : right) + 1;
		}
	}
}
