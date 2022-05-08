namespace MyNihongo.Leetcode.Tests.Solutions;

public sealed class Solution83Should
{
	[Fact]
	public void Case1()
	{
		Solution83.ListNode item3 = new(2), item2 = new(1, item3), item1 = new(1, item2);
		var expected = new[] { item1, item3 };

		var node = Solution83.DeleteDuplicates(item1);
		var result = CreateList(node);

		result
			.Should()
			.BeEquivalentTo(expected, x => x.WithStrictOrdering().IncludingFields());
	}

	[Fact]
	public void Case2()
	{
		Solution83.ListNode item5 = new(3), item4 = new(3, item5), item3 = new(2, item4), item2 = new(1, item3), item1 = new(1, item2);
		var expected = new[] { item1, item3, item5 };

		var node = Solution83.DeleteDuplicates(item1);
		var result = CreateList(node);

		result
			.Should()
			.BeEquivalentTo(expected, x => x.WithStrictOrdering().IncludingFields());
	}

	[Fact]
	public void Case3()
	{
		var node = Solution83.DeleteDuplicates(null);
		var result = CreateList(node);

		result
			.Should()
			.BeEmpty();
	}

	private static IEnumerable<Solution83.ListNode> CreateList(Solution83.ListNode? node)
	{
		var list = new List<Solution83.ListNode>();
		while (node != null)
		{
			list.Add(node);
			node = node.next;
		}

		return list;
	}
}
