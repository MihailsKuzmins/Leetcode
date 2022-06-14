namespace MyNihongo.Leetcode.Tests.Algorithms;

public sealed class Solution202Should
{
	[Fact]
	public void Case1()
	{
		const int input = 19;

		var result = Solution202.IsHappy(input);

		result
			.Should()
			.BeTrue();
	}

	[Fact]
	public void Case2()
	{
		const int input = 2;

		var result = Solution202.IsHappy(input);

		result
			.Should()
			.BeFalse();
	}
}
