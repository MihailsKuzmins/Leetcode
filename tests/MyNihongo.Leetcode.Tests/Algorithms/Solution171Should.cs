namespace MyNihongo.Leetcode.Tests.Algorithms;

public sealed class Solution171Should
{
	[Fact]
	public void Case1()
	{
		const string input = "A";
		const int expected = 1;

		var result = Solution171.TitleToNumber(input);

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void Case2()
	{
		const string input = "AB";
		const int expected = 28;

		var result = Solution171.TitleToNumber(input);

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void Case3()
	{
		const string input = "ZY";
		const int expected = 701;

		var result = Solution171.TitleToNumber(input);

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void Case4()
	{
		const string input = "FXSHRXW";
		const int expected = 2147483647;

		var result = Solution171.TitleToNumber(input);

		result
			.Should()
			.Be(expected);
	}
}
