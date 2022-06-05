namespace MyNihongo.Leetcode.Tests.Solutions;

public sealed class Solution108Should
{
	[Fact]
	public void Case1()
	{
		int[] input = { -10, -3, 0, 5, 9 };
		int?[] expected = { 0, -10, 5, null, -3, null, 9 };

		var root = Solution108.SortedArrayToBST(input);
		var result = GetBinaryTreeList(root);

		result
			.Should()
			.BeEquivalentTo(expected, x => x.WithStrictOrdering());
	}

	[Fact]
	public void Case2()
	{
		int[] input = { 1, 3 };
		int?[] expected = { 1, null, 3 };

		var root = Solution108.SortedArrayToBST(input);
		var result = GetBinaryTreeList(root);

		result
			.Should()
			.BeEquivalentTo(expected, x => x.WithStrictOrdering());
	}
}
