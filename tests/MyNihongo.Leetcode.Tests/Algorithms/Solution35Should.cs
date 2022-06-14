namespace MyNihongo.Leetcode.Tests.Algorithms;

public sealed class Solution35Should
{
	[Fact]
	public void Case1()
	{
		var nums = new[] { 1, 3, 5, 6 };
		const int target = 5, expected = 2;

		var result = Solution35.SearchInsert(nums, target);

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void Case2()
	{
		var nums = new[] { 1, 3, 5, 6 };
		const int target = 2, expected = 1;

		var result = Solution35.SearchInsert(nums, target);

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void Case3()
	{
		var nums = new[] { 1, 3, 5, 6 };
		const int target = 7, expected = 4;

		var result = Solution35.SearchInsert(nums, target);

		result
			.Should()
			.Be(expected);
	}
}
