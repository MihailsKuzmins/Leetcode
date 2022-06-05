// ReSharper disable InconsistentNaming
namespace MyNihongo.Leetcode.Tests;

internal static class TreeNodeHelpers
{
	public static TreeNode? CreateBinaryTree(IReadOnlyList<int?> nums)
	{
		if (nums.Count == 0 || nums[0] == null)
			return null;

		var root = new TreeNode(nums[0]!.Value);
		var queue = new Queue<TreeNode?>();
		queue.Enqueue(root);

		for (var i = 1; i < nums.Count; i++)
		{
			var newNode = nums[i].HasValue ? new TreeNode(nums[i]!.Value) : null;
			queue.Enqueue(newNode);

			if (i % 2 == 1)
			{
				var node = queue.Peek();
				if (node != null)
					node.left = newNode;
			}
			else
			{
				var node = queue.Dequeue();
				if (node != null)
					node.right = newNode;
			}
		}

		return root;
	}
}
