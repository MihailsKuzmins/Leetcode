namespace MyNihongo.Leetcode.Tests.Solutions;

public sealed class Solution121Should
{
	[Fact]
	public void Case1()
	{
		var input = new[] { 7, 1, 5, 3, 6, 4 };
		const int expected = 5;

		var result = Solution121.MaxProfit(input);

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void Case2()
	{
		var input = new[] { 7, 6, 4, 3, 1 };
		const int expected = 0;

		var result = Solution121.MaxProfit(input);

		result
			.Should()
			.Be(expected);
	}
}
