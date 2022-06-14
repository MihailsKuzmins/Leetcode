namespace MyNihongo.Leetcode.Tests.Algorithms;

public sealed class Solution69Should
{
	[Fact]
	public void Case1()
	{
		const int input = 4,
			expected = 2;

		var result = Solution69.MySqrt(input);

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void Case2()
	{
		const int input = 8,
			expected = 2;

		var result = Solution69.MySqrt(input);

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void Case3()
	{
		const int input = 2147395599,
			expected = 46339;

		var result = Solution69.MySqrt(input);

		result
			.Should()
			.Be(expected);
	}
}
