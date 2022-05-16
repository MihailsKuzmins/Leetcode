namespace MyNihongo.Leetcode.Tests.Solutions;

public sealed class Solution111Should
{
	[Fact]
	public void Case1()
	{
		Solution111.TreeNode left = new(9),
			right1 = new(15), right2 = new(7), right = new(20, right1, right2),
			item = new(3, left, right);

		const int expected = 2;

		var result = Solution111.MinDepth(item);

		result
			.Should()
			.Be(expected);
	}
}
