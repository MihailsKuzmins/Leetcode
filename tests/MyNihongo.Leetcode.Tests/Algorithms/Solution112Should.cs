namespace MyNihongo.Leetcode.Tests.Algorithms;

public sealed class Solution112Should
{
	[Fact]
	public void Case1()
	{
		TreeNode left1 = new(7), left2 = new(2), left3 = new(11, left1, left2), left = new(4, left3),
			right1 = new(1), right2 = new(4, right: right1), right3 = new(13), right = new(8, right3, right2),
			item = new(5, left, right);
		
		const int targetSum = 22;

		var result = Solution112.HasPathSum(item, targetSum);

		result
			.Should()
			.BeTrue();
	}

	[Fact]
	public void Case2()
	{
		TreeNode left = new(2),
			right = new(3),
			item = new(1, left, right);

		const int targetSum = 5;

		var result = Solution112.HasPathSum(item, targetSum);

		result
			.Should()
			.BeFalse();
	}
}
