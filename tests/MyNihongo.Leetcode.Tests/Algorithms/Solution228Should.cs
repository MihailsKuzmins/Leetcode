namespace MyNihongo.Leetcode.Tests.Algorithms;

public sealed class Solution228Should
{
	[Fact]
	public void Case1()
	{
		int[] input = { 0, 1, 2, 4, 5, 7 };
		string[] expected = { "0->2", "4->5", "7" };

		var result = Solution228.SummaryRanges(input);

		result
			.Should()
			.BeEquivalentTo(expected, x => x.WithStrictOrdering());
	}

	[Fact]
	public void Case2()
	{
		int[] input = { 0, 2, 3, 4, 6, 8, 9 };
		string[] expected = { "0", "2->4", "6", "8->9" };

		var result = Solution228.SummaryRanges(input);

		result
			.Should()
			.BeEquivalentTo(expected, x => x.WithStrictOrdering());
	}
}
