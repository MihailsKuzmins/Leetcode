namespace MyNihongo.Leetcode.Tests.Algorithms;

public sealed class Solution26Should
{
	[Fact]
	public void Case1()
	{
		int[] input = { 1, 1, 2 },
			expected = { 1, 2 };

		var index = Solution26.RemoveDuplicates(input);
		var result = input[..index];

		result
			.Should()
			.BeEquivalentTo(expected, x => x.WithStrictOrdering());
	}

	[Fact]
	public void Case2()
	{
		int[] input = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 },
			expected = { 0, 1, 2, 3, 4 };

		var index = Solution26.RemoveDuplicates(input);
		var result = input[..index];

		result
			.Should()
			.BeEquivalentTo(expected, x => x.WithStrictOrdering());
	}
}
