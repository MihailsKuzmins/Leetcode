namespace MyNihongo.Leetcode.Tests.Solutions;

public sealed class Solution905Should
{
	[Fact]
	public void Case1()
	{
		var input = new[] { 3, 1, 2, 4 };
		var expected = new[] { 2, 4, 3, 1 };

		var result = Solution905.SortArrayByParity(input);

		result
			.Should()
			.BeEquivalentTo(expected, x => x.WithStrictOrdering());
	}

	[Fact]
	public void Case2()
	{
		var input = new[] { 0 };
		var expected = new[] { 0 };

		var result = Solution905.SortArrayByParity(input);

		result
			.Should()
			.BeEquivalentTo(expected, x => x.WithStrictOrdering());
	}
}
