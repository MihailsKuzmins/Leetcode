// ReSharper disable InconsistentNaming
namespace MyNihongo.Leetcode.Solutions;

/// <summary>
/// Given the root of a binary tree, return <i>its maximum depth</i>.<br/>
/// A binary tree's <b>maximum depth</b> is the number of nodes along the longest path from the root node down to the farthest leaf node.
/// </summary>
public sealed class Solution104
{
	public static int MaxDepth(TreeNode? root)
	{
		if (root == null)
			return 0;

		var depth = 0;
		var queue = new Queue<TreeNode>();
		queue.Enqueue(root);

		while (queue.Count > 0)
		{
			depth++;

			// The trick is going down level by level
			// This is not any of the standard traversal methods
			for (int i = 0, count = queue.Count; i < count; i++)
			{
				var element = queue.Dequeue();

				if (element.left != null)
					queue.Enqueue(element.left);
				if (element.right != null)
					queue.Enqueue(element.right);
			}
		}

		return depth;
	}
}
