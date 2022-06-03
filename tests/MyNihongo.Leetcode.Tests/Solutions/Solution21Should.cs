// ReSharper disable InconsistentNaming
namespace MyNihongo.Leetcode.Tests.Solutions;

public sealed class Solution21Should
{
	[Fact]
	public void Case1()
	{
		ListNode list1_3 = new(4), list1_2 = new(2, list1_3), list1_1 = new(1, list1_2),
			list2_3 = new(4), list2_2 = new(3, list2_3), list2_1 = new(1, list2_2);

		var expected = new List<ListNode>
		{
			list1_1, list2_1,
			list1_2,
			list2_2,
			list1_3, list2_3
		};

		var node = Solution21.MergeTwoLists(list1_1, list2_1);
		var result = CreateArray(node);

		result
			.Should()
			.BeEquivalentTo(expected, x => x.IncludingFields());
	}

	[Fact]
	public void Case2()
	{
		var node = Solution21.MergeTwoLists(null, null);
		var result = CreateArray(node);

		result
			.Should()
			.BeEmpty();
	}

	[Fact]
	public void Case3()
	{
		ListNode list2_1 = new();
		var expected = new List<ListNode> { list2_1 };

		var node = Solution21.MergeTwoLists(null, list2_1);
		var result = CreateArray(node);

		result
			.Should()
			.BeEquivalentTo(expected, x => x.IncludingFields());
	}
}
