// ReSharper disable InconsistentNaming
namespace MyNihongo.Leetcode.Algorithms;

/// <summary>
/// Given the root of a binary tree and an integer targetSum, return true if the tree has a <b>root-to-leaf</b> path such that adding up all the values along the path equals targetSum.<br/>
/// A leaf is a node with no children.
/// </summary>
public sealed class Solution112
{
	public static bool HasPathSum(TreeNode? root, int targetSum)
	{
		return root != null && HasSum(root, 0, targetSum);

		static bool HasSum(in TreeNode node, in int currentSum, in int targetSum)
		{
			if (node.left == null && node.right == null)
				return currentSum + node.val == targetSum;

			if (node.left != null)
			{
				if (HasSum(node.left, currentSum + node.val, targetSum))
					return true;
			}

			if (node.right != null)
			{
				if (HasSum(node.right, currentSum + node.val, targetSum))
					return true;
			}

			return false;
		}
	}
}
