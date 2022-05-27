namespace MyNihongo.Leetcode.Tests.Solutions;

public sealed class Solution168Should
{
	[Fact]
	public void Case1()
	{
		const int input = 1;
		const string expected = "A";

		var result = Solution168.ConvertToTitle(input);

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void Case2()
	{
		const int input = 28;
		const string expected = "AB";

		var result = Solution168.ConvertToTitle(input);

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void Case3()
	{
		const int input = 701;
		const string expected = "ZY";

		var result = Solution168.ConvertToTitle(input);

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void Case4()
	{
		const int input = 2147483647;
		const string expected = "FXSHRXW";

		var result = Solution168.ConvertToTitle(input);

		result
			.Should()
			.Be(expected);
	}
}
