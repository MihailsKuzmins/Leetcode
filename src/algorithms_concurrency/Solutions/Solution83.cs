// ReSharper disable InconsistentNaming
namespace MyNihongo.Leetcode.Solutions;

/// <summary>
/// Given the head of a sorted linked list, delete all duplicates such that each element appears only once. Return the linked list <b>sorted</b> as well.
/// </summary>
public sealed class Solution83
{
	public static ListNode? DeleteDuplicates(ListNode? head)
	{
		var curr = head;
		while (curr?.next != null)
		{
			if (curr.val == curr.next.val)
				curr.next = curr.next.next;
			else
				curr = curr.next;
		}

		return head;
	}

	public sealed class ListNode
	{
		public int val;
		public ListNode? next;

		public ListNode(int val = 0, ListNode? next = null)
		{
			this.val = val;
			this.next = next;
		}

		public override string ToString()
		{
			var str = val.ToString();
			if (next != null)
				str += " -> ";

			return str;
		}
	}
}
