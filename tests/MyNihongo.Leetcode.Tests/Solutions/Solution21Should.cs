// ReSharper disable InconsistentNaming
namespace MyNihongo.Leetcode.Tests.Solutions;

public sealed class Solution21Should
{
	[Fact]
	public void Case1()
	{
		Solution21.ListNode list1_3 = new(4), list1_2 = new(2, list1_3), list1_1 = new(1, list1_2),
			list2_3 = new(4), list2_2 = new(3, list2_3), list2_1 = new(1, list2_2);

		var expected = new List<Solution21.ListNode>
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
		Solution21.ListNode list2_1 = new();
		var expected = new List<Solution21.ListNode> { list2_1 };

		var node = Solution21.MergeTwoLists(null, list2_1);
		var result = CreateArray(node);

		result
			.Should()
			.BeEquivalentTo(expected, x => x.IncludingFields());
	}

	private static IEnumerable<Solution21.ListNode> CreateArray(Solution21.ListNode? node)
	{
		if (node == null)
			return Enumerable.Empty<Solution21.ListNode>();

		var list = new List<Solution21.ListNode> { node };
		while (node.next != null)
		{
			list.Add(node.next);
			node = node.next;
		}

		return list;
	}
}
