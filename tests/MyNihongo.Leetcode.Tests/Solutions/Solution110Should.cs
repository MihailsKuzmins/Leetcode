namespace MyNihongo.Leetcode.Tests.Solutions;

public sealed class Solution110Should
{
	[Fact]
	public void Case1()
	{
		Solution110.TreeNode left = new(9),
			right1 = new(15), right2 = new(7), right = new(20, right1, right2),
			item = new(3, left, right);

		var result = Solution110.IsBalanced(item);

		result
			.Should()
			.BeTrue();
	}

	[Fact]
	public void Case2()
	{
		Solution110.TreeNode left1 = new(4), left2 = new(4), left3 = new(3, left1, left2), left4 = new(3), left = new(2, left3, left4),
			right = new(2),
			item = new(1, left, right);

		var result = Solution110.IsBalanced(item);

		result
			.Should()
			.BeFalse();
	}
}
