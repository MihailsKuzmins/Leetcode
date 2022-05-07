namespace MyNihongo.Leetcode.Tests.Solutions;

public sealed class Solution66Should
{
	[Fact]
	public void Case1()
	{
		int[] input = { 1, 2, 3 },
			expected = { 1, 2, 4 };

		var result = Solution66.PlusOne(input);

		result
			.Should()
			.BeEquivalentTo(expected, x => x.WithStrictOrdering());
	}

	[Fact]
	public void Case2()
	{
		int[] input = { 4, 3, 2, 1 },
			expected = { 4, 3, 2, 2 };

		var result = Solution66.PlusOne(input);

		result
			.Should()
			.BeEquivalentTo(expected, x => x.WithStrictOrdering());
	}

	[Fact]
	public void Case3()
	{
		int[] input = { 9 },
			expected = { 1, 0 };

		var result = Solution66.PlusOne(input);

		result
			.Should()
			.BeEquivalentTo(expected, x => x.WithStrictOrdering());
	}
}
