namespace MyNihongo.Leetcode.Tests.Algorithms;

public sealed class Solution119Should
{
	[Fact]
	public void Case1()
	{
		const int input = 3;
		var expected = new[] { 1, 3, 3, 1 };

		var result = Solution119.GetRow(input);

		result
			.Should()
			.BeEquivalentTo(expected, x => x.WithStrictOrdering());
	}

	[Fact]
	public void Case2()
	{
		const int input = 0;
		var expected = new[] { 1 };

		var result = Solution119.GetRow(input);

		result
			.Should()
			.BeEquivalentTo(expected, x => x.WithStrictOrdering());
	}

	[Fact]
	public void Case3()
	{
		const int input = 1;
		var expected = new[] { 1, 1 };

		var result = Solution119.GetRow(input);

		result
			.Should()
			.BeEquivalentTo(expected, x => x.WithStrictOrdering());
	}

	[Fact]
	public void Case4()
	{
		const int input = 18;
		var expected = new[] { 1, 18, 153, 816, 3060, 8568, 18564, 31824, 43758, 48620, 43758, 31824, 18564, 8568, 3060, 816, 153, 18, 1 };

		var result = Solution119.GetRow(input);

		result
			.Should()
			.BeEquivalentTo(expected, x => x.WithStrictOrdering());
	}
}
