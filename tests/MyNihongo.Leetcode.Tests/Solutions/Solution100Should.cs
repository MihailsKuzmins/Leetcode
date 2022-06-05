// ReSharper disable InconsistentNaming
namespace MyNihongo.Leetcode.Tests.Solutions;

public sealed class Solution100Should
{
	[Fact]
	public void Case1()
	{
		TreeNode item1_2 = new(2), item1_3 = new(3), item1 = new(1, item1_2, item1_3),
			item2_2 = new(2), item2_3 = new(3), item2 = new(1, item2_2, item2_3);

		var result = Solution100.IsSameTree(item1, item2);

		result
			.Should()
			.BeTrue();
	}

	[Fact]
	public void Case2()
	{
		TreeNode item1_2 = new(2), item1 = new(1, item1_2),
			item2_2 = new(2), item2 = new(1, right: item2_2);

		var result = Solution100.IsSameTree(item1, item2);

		result
			.Should()
			.BeFalse();
	}

	[Fact]
	public void Case3()
	{
		TreeNode item1_2 = new(2), item1_3 = new(1), item1 = new(1, item1_2, item1_3),
			item2_2 = new(1), item2_3 = new(3), item2 = new(1, item2_2, item2_3);

		var result = Solution100.IsSameTree(item1, item2);

		result
			.Should()
			.BeFalse();
	}

	[Fact]
	public void Case4()
	{
		TreeNode item1 = new(1),
			item2_1 = new(2), item2 = new(1, null, item2_1);

		var result = Solution100.IsSameTree(item1, item2);

		result
			.Should()
			.BeFalse();
	}
}
