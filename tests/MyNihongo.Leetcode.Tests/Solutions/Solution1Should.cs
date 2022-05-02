namespace MyNihongo.Leetcode.Tests.Solutions;

public sealed class Solution1Should
{
	[Fact]
	public void Case1()
	{
		var nums = new[] { 2, 7, 11, 15 };
		const int target = 9;

		var expected = new[] { 0, 1 };

		var result = Solution1.TwoSum(nums, target);

		result
			.Should()
			.BeEquivalentTo(expected);
	}

	[Fact]
	public void Case2()
	{
		var nums = new[] { 3, 2, 4 };
		const int target = 6;

		var expected = new[] { 1, 2 };

		var result = Solution1.TwoSum(nums, target);

		result
			.Should()
			.BeEquivalentTo(expected);
	}

	[Fact]
	public void Case3()
	{
		var nums = new[] { 3, 3};
		const int target = 6;

		var expected = new[] { 0, 1 };

		var result = Solution1.TwoSum(nums, target);

		result
			.Should()
			.BeEquivalentTo(expected);
	}
}
