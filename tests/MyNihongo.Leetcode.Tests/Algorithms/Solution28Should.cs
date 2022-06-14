namespace MyNihongo.Leetcode.Tests.Algorithms;

public sealed class Solution28Should
{
	[Fact]
	public void Case1()
	{
		const string haystack = "hello", needle = "ll";
		const int expected = 2;

		var result = Solution28.StrStr(haystack, needle);

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void Case2()
	{
		const string haystack = "aaaaa", needle = "bba";
		const int expected = -1;

		var result = Solution28.StrStr(haystack, needle);

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void Case3()
	{
		const string haystack = "hello", needle = "";
		const int expected = 0;

		var result = Solution28.StrStr(haystack, needle);

		result
			.Should()
			.Be(expected);
	}
}
