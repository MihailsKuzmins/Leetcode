namespace MyNihongo.Leetcode.Tests.Algorithms;

public sealed class Solution905Should
{
	[Fact]
	public void Case1()
	{
		var input = new[] { 3, 1, 2, 4 };
		var expected = new[] { 4, 2, 1, 3 };

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

	[Fact]
	public void Case3()
	{
		var input = new[] { 1 };
		var expected = new[] { 1 };

		var result = Solution905.SortArrayByParity(input);

		result
			.Should()
			.BeEquivalentTo(expected, x => x.WithStrictOrdering());
	}

	[Fact]
	public void Case4()
	{
		var input = new[] { 1, 0, 3 };
		var expected = new[] { 0, 1, 3 };

		var result = Solution905.SortArrayByParity(input);

		result
			.Should()
			.BeEquivalentTo(expected, x => x.WithStrictOrdering());
	}

	[Fact]
	public void Case5()
	{
		var input = new[] { 0, 2 };
		var expected = new[] { 0, 2 };

		var result = Solution905.SortArrayByParity(input);

		result
			.Should()
			.BeEquivalentTo(expected, x => x.WithStrictOrdering());
	}
}
