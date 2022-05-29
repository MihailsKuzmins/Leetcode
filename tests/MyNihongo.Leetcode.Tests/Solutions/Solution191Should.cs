namespace MyNihongo.Leetcode.Tests.Solutions;

public sealed class Solution191Should
{
	[Fact]
	public void Case1()
	{
		const uint input = 0b00000000000000000000000000001011u;
		const int expected = 3;

		var result = Solution191.HammingWeight(input);

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void Case2()
	{
		const uint input = 0b00000000000000000000000010000000u;
		const int expected = 1;

		var result = Solution191.HammingWeight(input);

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void Case3()
	{
		const uint input = 0b11111111111111111111111111111101u;
		const int expected = 31;

		var result = Solution191.HammingWeight(input);

		result
			.Should()
			.Be(expected);
	}
}
