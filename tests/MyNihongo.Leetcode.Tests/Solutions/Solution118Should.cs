namespace MyNihongo.Leetcode.Tests.Solutions;

public sealed class Solution118Should
{
	[Fact]
	public void Case1()
	{
		const int input = 5;
		var expected = new[]
		{
			new[] { 1 },
			new[] { 1, 1 },
			new[] { 1, 2, 1 },
			new[] { 1, 3, 3, 1 },
			new[] { 1, 4, 6, 4, 1 }
		};

		var result = Solution118.Generate(input);

		result
			.Should()
			.BeEquivalentTo(expected, x => x.WithStrictOrdering());
	}

	[Fact]
	public void Case2()
	{
		const int input = 1;
		var expected = new[]
		{
			new[] { 1 }
		};

		var result = Solution118.Generate(input);

		result
			.Should()
			.BeEquivalentTo(expected, x => x.WithStrictOrdering());
	}
}
