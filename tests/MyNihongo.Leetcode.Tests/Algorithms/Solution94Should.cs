namespace MyNihongo.Leetcode.Tests.Algorithms;

public sealed class Solution94Should
{
	[Fact]
	public void Case1()
	{
		TreeNode item3 = new(3), item2 = new(2, item3), item1 = new(1, right: item2);
		var expected = new [] { 1, 3, 2 };

		var result = Solution94.InorderTraversal(item1);

		result
			.Should()
			.BeEquivalentTo(expected, x => x.WithStrictOrdering());
	}

	[Fact]
	public void Case2()
	{
		var result = Solution94.InorderTraversal(null);

		result
			.Should()
			.BeEmpty();
	}

	[Fact]
	public void Case3()
	{
		TreeNode item1 = new(1);
		var expected = new[] { 1 };

		var result = Solution94.InorderTraversal(item1);

		result
			.Should()
			.BeEquivalentTo(expected, x => x.WithStrictOrdering());
	}
}
