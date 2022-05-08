// ReSharper disable InconsistentNaming
namespace MyNihongo.Leetcode.Solutions;

/// <summary>
/// Given the head of a sorted linked list, delete all duplicates such that each element appears only once. Return the linked list <b>sorted</b> as well.
/// </summary>
public sealed class Solution83
{
	public static ListNode? DeleteDuplicates(ListNode? head)
	{
		if (head == null)
			return null;

		var unique = head;
		var curr = unique.next;
		var num = unique.val;
		while (curr != null)
		{
			var isUnique = curr.val != num;
			if (isUnique)
			{
				unique = unique.next = curr;
				num = curr.val;
			}

			curr = curr.next;

			if (!isUnique)
				unique.next = null;
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
