namespace MyNihongo.Leetcode.Tests.Algorithms;

public sealed class Solution53Should
{
	[Fact]
	public void Case1()
	{
		var nums = new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
		const int expected = 6;

		var result = Solution53.MaxSubArray(nums);

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void Case2()
	{
		var nums = new[] { 1 };
		const int expected = 1;

		var result = Solution53.MaxSubArray(nums);

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void Case3()
	{
		var nums = new[] { 5, 4, -1, 7, 8 };
		const int expected = 23;

		var result = Solution53.MaxSubArray(nums);

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void Case4()
	{
		var nums = new[] { -5, -3 };
		const int expected = -3;

		var result = Solution53.MaxSubArray(nums);

		result
			.Should()
			.Be(expected);
	}
}
