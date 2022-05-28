// ReSharper disable InconsistentNaming
namespace MyNihongo.Leetcode.Solutions;

/// <summary>
/// Given a binary tree, find its minimum depth.<br/>
/// The minimum depth is the number of nodes along the shortest path from the root node down to the nearest leaf node.<br/>
/// <b>Note</b>: A leaf is a node with no children.
/// </summary>
public sealed class Solution111
{
	public static int MinDepth(TreeNode? root)
	{
		if (root == null)
			return 0;

		var queue = new Queue<TreeNode>();
		queue.Enqueue(root);

		var depth = 0;
		while (queue.Count > 0)
		{
			depth++;
			for (int i = 0, count = queue.Count; i < count; i++)
			{
				var node = queue.Dequeue();

				if (node.left == null && node.right == null)
					return depth;

				if (node.left != null)
					queue.Enqueue(node.left);
				if (node.right != null)
					queue.Enqueue(node.right);
			}
		}


		return depth;
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
