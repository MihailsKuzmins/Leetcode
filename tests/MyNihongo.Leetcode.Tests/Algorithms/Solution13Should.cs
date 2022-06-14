namespace MyNihongo.Leetcode.Tests.Algorithms;

public sealed class Solution13Should
{
	[Fact]
	public void Case1()
	{
		const string input = "III";
		const int expected = 3;

		var result = Solution13.RomanToInt(input);

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void Case2()
	{
		const string input = "LVIII";
		const int expected = 58;

		var result = Solution13.RomanToInt(input);

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void Case3()
	{
		const string input = "MCMXCIV";
		const int expected = 1994;

		var result = Solution13.RomanToInt(input);

		result
			.Should()
			.Be(expected);
	}
}
