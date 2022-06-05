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

	public static IEnumerable<int?> GetBinaryTreeList(TreeNode? root)
	{
		if (root == null)
			return Enumerable.Empty<int?>();

		var list = new List<int?>();
		var queue = new Queue<TreeNode?>();
		queue.Enqueue(root);

		while (queue.Count > 0)
		{
			for (int i = 0, count = queue.Count; i < count; i++)
			{
				var node = queue.Dequeue();
				list.Add(node?.val);

				if (node == null)
					continue;

				if (node.left == null && node.right == null)
					continue;

				queue.Enqueue(node.left);
				queue.Enqueue(node.right);
			}
		}

		for (var i = list.Count - 1; i >= 0; i--)
		{
			if (list[i] != null)
				break;

			list.RemoveAt(i);
		}

		return list;
	}
}
