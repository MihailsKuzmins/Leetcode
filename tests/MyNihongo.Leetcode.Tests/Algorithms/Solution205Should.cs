namespace MyNihongo.Leetcode.Tests.Algorithms;

public sealed class Solution205Should
{
	[Fact]
	public void Case1()
	{
		const string str1 = "egg", str2 = "add";

		var result = Solution205.IsIsomorphic(str1, str2);

		result
			.Should()
			.BeTrue();
	}

	[Fact]
	public void Case2()
	{
		const string str1 = "foo", str2 = "bar";

		var result = Solution205.IsIsomorphic(str1, str2);

		result
			.Should()
			.BeFalse();
	}

	[Fact]
	public void Case3()
	{
		const string str1 = "paper", str2 = "title";

		var result = Solution205.IsIsomorphic(str1, str2);

		result
			.Should()
			.BeTrue();
	}

	[Fact]
	public void Case4()
	{
		const string str1 = "badc", str2 = "baba";

		var result = Solution205.IsIsomorphic(str1, str2);

		result
			.Should()
			.BeFalse();
	}
}
