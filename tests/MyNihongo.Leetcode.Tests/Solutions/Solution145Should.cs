namespace MyNihongo.Leetcode.Tests.Solutions;

public sealed class Solution145Should
{
	[Fact]
	public void Case1()
	{
		Solution145.TreeNode right1 = new(3), right = new(2, right1),
			item = new(1, right: right);

		var expected = new[] { 3, 2, 1 };

		var result = Solution145.PostorderTraversal(item);

		result
			.Should()
			.BeEquivalentTo(expected, x => x.WithStrictOrdering());
	}

	[Fact]
	public void Case2()
	{
		var result = Solution145.PostorderTraversal(null);

		result
			.Should()
			.BeEmpty();
	}

	[Fact]
	public void Case3()
	{
		Solution145.TreeNode item = new(1);

		var expected = new[] { 1 };

		var result = Solution145.PostorderTraversal(item);

		result
			.Should()
			.BeEquivalentTo(expected, x => x.WithStrictOrdering());
	}

	[Fact]
	public void Case4()
	{
		Solution145.TreeNode left = new(1),
			right = new(2),
			item = new(3, left, right);

		var expected = new[] { 1, 2, 3 };

		var result = Solution145.PostorderTraversal(item);

		result
			.Should()
			.BeEquivalentTo(expected, x => x.WithStrictOrdering());
	}
}
