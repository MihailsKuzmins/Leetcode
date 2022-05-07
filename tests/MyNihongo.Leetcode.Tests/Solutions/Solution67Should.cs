namespace MyNihongo.Leetcode.Tests.Solutions;

public sealed class Solution67Should
{
	[Fact]
	public void Case1()
	{
		const string input1 = "11", input2 = "1",
			expected = "100";

		var result = Solution67.AddBinary(input1, input2);

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void Case2()
	{
		const string input1 = "1010", input2 = "1011",
			expected = "10101";

		var result = Solution67.AddBinary(input1, input2);

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void Case3()
	{
		const string input1 = "1111", input2 = "1111",
			expected = "11110";

		var result = Solution67.AddBinary(input1, input2);

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void Case4()
	{
		const string input1 = "100", input2 = "110010",
			expected = "110110";

		var result = Solution67.AddBinary(input1, input2);

		result
			.Should()
			.Be(expected);
	}
}
