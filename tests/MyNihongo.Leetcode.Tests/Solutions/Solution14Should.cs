namespace MyNihongo.Leetcode.Tests.Solutions;

public sealed class Solution14Should
{
	[Fact]
	public void Case1()
	{
		var strs = new[] { "flower", "flow", "flight" };
		const string expected = "fl";

		var result = Solution14.LongestCommonPrefix(strs);

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void Case2()
	{
		var strs = new[] { "dog", "racecar", "car" };
		const string expected = "";

		var result = Solution14.LongestCommonPrefix(strs);

		result
			.Should()
			.Be(expected);
	}
}
