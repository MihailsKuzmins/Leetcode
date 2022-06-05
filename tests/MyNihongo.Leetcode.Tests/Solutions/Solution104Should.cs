namespace MyNihongo.Leetcode.Tests.Solutions;

public sealed class Solution104Should
{
	[Fact]
	public void Case1()
	{
		TreeNode left = new(9),
			right1 = new(15), right2 = new(7), right = new(20, right1, right2),
			item = new(3, left, right);

		const int expected = 3;

		var result = Solution104.MaxDepth(item);

		result
			.Should()
			.Be(expected);
	}

	[Fact]
	public void Case2()
	{
		TreeNode right = new(2),
			item = new(1, right: right);

		const int expected = 2;

		var result = Solution104.MaxDepth(item);

		result
			.Should()
			.Be(expected);
	}
}
