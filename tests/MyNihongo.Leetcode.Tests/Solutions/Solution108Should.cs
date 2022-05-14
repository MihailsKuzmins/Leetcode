namespace MyNihongo.Leetcode.Tests.Solutions;

public sealed class Solution108Should
{
	[Fact]
	public void Case1()
	{
		int[] input = { -10, -3, 0, 5, 9 };
		int?[] expected = { 0, -3, 9, -10, null, 5 };

		var root = Solution108.SortedArrayToBST(input);
		var result = GetList(root);

		result
			.Should()
			.BeEquivalentTo(expected, x => x.WithStrictOrdering());
	}

	[Fact]
	public void Case2()
	{
		int[] input = { 1, 3 };
		int?[] expected = { 3, 1 };

		var root = Solution108.SortedArrayToBST(input);
		var result = GetList(root);

		result
			.Should()
			.BeEquivalentTo(expected, x => x.WithStrictOrdering());
	}

	private static IEnumerable<int?> GetList(Solution108.TreeNode? root)
	{
		if (root == null)
			return Enumerable.Empty<int?>();

		var list = new List<int?>();
		var queue = new Queue<Solution108.TreeNode?>();
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

				queue.Enqueue(node.right);
				queue.Enqueue(node.left);
			}
		}

		return list;
	}
}
