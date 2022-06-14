// ReSharper disable InconsistentNaming
namespace MyNihongo.Leetcode.Algorithms;

/// <summary>
/// Given the head of a linked list and an integer val, remove all the nodes of the linked list that has Node.val == val, and return the new head.
/// </summary>
public sealed class Solution203
{
	public static ListNode? RemoveElements(ListNode? head, int val)
	{
		ListNode? newHead = null, curr = null;
		while (head != null)
		{
			if (head.val != val)
			{
				if (newHead == null)
					newHead = head;
				if (curr != null)
					curr.next = head;

				curr = head;
			}

			head = head.next;
			
			if (curr != null)
				curr.next = null;
		}

		return newHead;
	}
}
