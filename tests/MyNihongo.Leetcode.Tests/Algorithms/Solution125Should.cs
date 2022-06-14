namespace MyNihongo.Leetcode.Tests.Algorithms;

public sealed class Solution125Should
{
	[Fact]
	public void Case1()
	{
		const string input = "A man, a plan, a canal: Panama";

		var result = Solution125.IsPalindrome(input);

		result
			.Should()
			.BeTrue();
	}

	[Fact]
	public void Case2()
	{
		const string input = "race a car";

		var result = Solution125.IsPalindrome(input);

		result
			.Should()
			.BeFalse();
	}

	[Fact]
	public void Case3()
	{
		const string input = " ";

		var result = Solution125.IsPalindrome(input);

		result
			.Should()
			.BeTrue();
	}
}
