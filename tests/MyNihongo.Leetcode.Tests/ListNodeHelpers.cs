namespace MyNihongo.Leetcode.Tests;

internal static class ListNodeHelpers
{
	public static ListNode? CreateLinkedList(IReadOnlyList<int> arr)
	{
		if (arr.Count == 0)
			return null;

		ListNode head = new(arr[0]),
			curr = head;

		for (var i = 1; i < arr.Count; i++)
		{
			var node = new ListNode(arr[i]);
			curr.next = node;

			curr = node;
		}

		return head;
	}

	public static IEnumerable<ListNode> CreateArray(ListNode? node)
	{
		if (node == null)
			return Enumerable.Empty<ListNode>();

		var list = new List<ListNode> { node };
		while (node.next != null)
		{
			list.Add(node.next);
			node = node.next;
		}

		return list;
	}

	public static IEnumerable<int> CreateValueArray(ListNode? node)
	{
		if (node == null)
			return Enumerable.Empty<int>();

		var list = new List<int> { node.val };
		while (node.next != null)
		{
			list.Add(node.next.val);
			node = node.next;
		}

		return list;
	}
}
