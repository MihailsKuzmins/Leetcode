namespace MyNihongo.Leetcode.Tests.Solutions;

public sealed class Solution20Should
{
	[Fact]
	public void Case1()
	{
		const string input = "()";

		var result = Solution20.IsValid(input);

		result
			.Should()
			.BeTrue();
	}

	[Fact]
	public void Case2()
	{
		const string input = "()[]{}";

		var result = Solution20.IsValid(input);

		result
			.Should()
			.BeTrue();
	}

	[Fact]
	public void Case3()
	{
		const string input = "(]";

		var result = Solution20.IsValid(input);

		result
			.Should()
			.BeFalse();
	}

	[Fact]
	public void Case4()
	{
		const string input = "([)]";

		var result = Solution20.IsValid(input);

		result
			.Should()
			.BeFalse();
	}
}
