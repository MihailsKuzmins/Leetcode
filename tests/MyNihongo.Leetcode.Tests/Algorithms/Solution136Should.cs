namespace MyNihongo.Leetcode.Tests.Algorithms;

public sealed class Solution136Should
{
	[Fact]
	public void Case1()
	{
		var input = new[] { 2, 2, 1 };
		const int expected = 1;

		var result = Solution136.SingleNumber(input);

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void Case2()
	{
		var input = new[] { 4, 1, 2, 1, 2 };
		const int expected = 4;

		var result = Solution136.SingleNumber(input);

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void Case3()
	{
		var input = new[] { 1 };
		const int expected = 1;

		var result = Solution136.SingleNumber(input);

		result
			.Should()
			.Be(expected);
	}
}
