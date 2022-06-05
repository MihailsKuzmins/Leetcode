namespace MyNihongo.Leetcode.Tests.Solutions;

public sealed class Solution226Should
{
	[Fact]
	public void Case1()
	{
		int?[] nums = { 4, 2, 7, 1, 3, 6, 9 };
		var input = CreateBinaryTree(nums);

		int[] expected = { 4, 7, 2, 9, 6, 3, 1 };

		var output = Solution226.InvertTree(input);
		var result = GetBinaryTreeList(output);

		result
			.Should()
			.BeEquivalentTo(expected, x => x.WithStrictOrdering());
	}
}
