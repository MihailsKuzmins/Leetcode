namespace MyNihongo.Leetcode.Tests.Solutions;

public sealed class Solution219Should
{
	[Fact]
	public void Case1()
	{
		int[] input = { 1, 2, 3, 1 };
		const int num = 3;

		var result = Solution219.ContainsNearbyDuplicate(input, num);

		result
			.Should()
			.BeTrue();
	}

	[Fact]
	public void Case2()
	{
		int[] input = { 1, 0, 1, 1 };
		const int num = 1;

		var result = Solution219.ContainsNearbyDuplicate(input, num);

		result
			.Should()
			.BeTrue();
	}

	[Fact]
	public void Case3()
	{
		int[] input = { 1, 2, 3, 1, 2, 3 };
		const int num = 2;

		var result = Solution219.ContainsNearbyDuplicate(input, num);

		result
			.Should()
			.BeFalse();
	}

	[Fact]
	public void Case4()
	{
		int[] input = { -1, -1 };
		const int num = 1;

		var result = Solution219.ContainsNearbyDuplicate(input, num);

		result
			.Should()
			.BeTrue();
	}
}
