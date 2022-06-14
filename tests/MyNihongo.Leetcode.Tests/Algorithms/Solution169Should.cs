namespace MyNihongo.Leetcode.Tests.Algorithms;

public sealed class Solution169Should
{
	[Fact]
	public void Case1()
	{
		int[] input = { 3, 2, 3 };
		const int expected = 3;

		var result = Solution169.MajorityElement(input);

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void Case2()
	{
		int[] input = { 2, 2, 1, 1, 1, 2, 2 };
		const int expected = 2;

		var result = Solution169.MajorityElement(input);

		result
			.Should()
			.Be(expected);
	}
}
