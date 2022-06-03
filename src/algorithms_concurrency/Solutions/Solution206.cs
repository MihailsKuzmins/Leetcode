namespace MyNihongo.Leetcode.Solutions;

/// <summary>
/// Given the head of a singly linked list, reverse the list, and return the reversed list.
/// </summary>
public sealed class Solution206
{
	public static ListNode? ReverseList(ListNode? head)
	{
		if (head == null)
			return null;

		ListNode? prev = head, curr = head.next;
		prev.next = null;
		while (curr != null)
		{
			var tmp = curr.next;
			curr.next = prev;

			prev = curr;
			curr = tmp;
		}

		return prev;
	}
}
