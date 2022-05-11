namespace MyNihongo.Leetcode.Tests.Solutions;

public sealed class Solution101Should
{
	[Fact]
	public void Case1()
	{
		Solution101.TreeNode right4 = new(4), right3 = new(3), right = new(2, right3, right4),
			left4 = new(4), left3 = new(3), left = new(2, left4, left3),
			item = new(1, right, left);

		var result = Solution101.IsSymmetric(item);

		result
			.Should()
			.BeTrue();
	}

	[Fact]
	public void Case2()
	{
		Solution101.TreeNode right3 = new(3), right = new(2, right: right3),
			left3 = new(3), left = new(2, right: left3),
			item = new(1, right, left);

		var result = Solution101.IsSymmetric(item);

		result
			.Should()
			.BeFalse();
	}
}
