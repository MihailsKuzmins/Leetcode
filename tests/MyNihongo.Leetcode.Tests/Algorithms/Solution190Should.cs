namespace MyNihongo.Leetcode.Tests.Algorithms;

public sealed class Solution190Should
{
	[Fact]
	public void Case1()
	{
		const uint input = 0b00000010100101000001111010011100u,
			expected = 0b00111001011110000010100101000000u;

		var result = Solution190.ReverseBits(input);

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void Case2()
	{
		const uint input = 0b11111111111111111111111111111101u,
			expected = 0b10111111111111111111111111111111u;

		var result = Solution190.ReverseBits(input);

		result
			.Should()
			.Be(expected);
	}
}
