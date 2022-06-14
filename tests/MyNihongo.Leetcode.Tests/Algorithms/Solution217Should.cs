namespace MyNihongo.Leetcode.Tests.Algorithms;

public sealed class Solution217Should
{
	[Fact]
	public void Case1()
	{
		int[] input = { 1, 2, 3, 1 };

		var result = Solution217.ContainsDuplicate(input);

		result
			.Should()
			.BeTrue();
	}

	[Fact]
	public void Case2()
	{
		int[] input = { 1, 2, 3, 4 };

		var result = Solution217.ContainsDuplicate(input);

		result
			.Should()
			.BeFalse();
	}

	[Fact]
	public void Case3()
	{
		int[] input = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };

		var result = Solution217.ContainsDuplicate(input);

		result
			.Should()
			.BeTrue();
	}
}
