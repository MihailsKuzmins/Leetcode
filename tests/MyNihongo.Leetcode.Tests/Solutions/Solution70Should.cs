namespace MyNihongo.Leetcode.Tests.Solutions;

public sealed class Solution70Should
{
	[Fact]
	public void Case1()
	{
		const int input = 2,
			expected = 2;

		var result = Solution70.ClimbStairs(input);

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void Case2()
	{
		const int input = 3,
			expected = 3;

		var result = Solution70.ClimbStairs(input);

		result
			.Should()
			.Be(expected);
	}
}
