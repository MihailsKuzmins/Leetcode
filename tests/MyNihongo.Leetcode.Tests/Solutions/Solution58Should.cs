namespace MyNihongo.Leetcode.Tests.Solutions;

public sealed class Solution58Should
{
	[Fact]
	public void Case1()
	{
		const string input = "Hello World";
		const int expected = 5;

		var result = Solution58.LengthOfLastWord(input);

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void Case2()
	{
		const string input = "   fly me   to   the moon  ";
		const int expected = 4;

		var result = Solution58.LengthOfLastWord(input);

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void Case3()
	{
		const string input = "luffy is still joyboy";
		const int expected = 6;

		var result = Solution58.LengthOfLastWord(input);

		result
			.Should()
			.Be(expected);
	}
}
