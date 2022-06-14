namespace MyNihongo.Leetcode.Tests.Algorithms;

public sealed class Solution27Should
{
	[Fact]
	public void Case1()
	{
		var nums = new[] { 3, 2, 2, 3 };
		const int val = 3;

		var expected = new[] { 2, 2 };

		var length = Solution27.RemoveElement(nums, val);
		var result = nums[..length];

		result
			.Should()
			.BeEquivalentTo(expected);
	}

	[Fact]
	public void Case2()
	{
		var nums = new[] { 0, 1, 2, 2, 3, 0, 4, 2 };
		const int val = 2;

		var expected = new[] { 0, 1, 4, 0, 3 };

		var length = Solution27.RemoveElement(nums, val);
		var result = nums[..length];

		result
			.Should()
			.BeEquivalentTo(expected);
	}
}
