// ReSharper disable InconsistentNaming
namespace MyNihongo.Leetcode.Solutions;

/// <summary>
/// Given head, the head of a linked list, determine if the linked list has a cycle in it.<br/>
/// There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the next pointer. Internally, pos is used to denote the index of the node that tail's next pointer is connected to. <b>Note that pos is not passed as a parameter</b>.<br/>
/// Return true if there is a cycle in the linked list. Otherwise, return false.
/// </summary>
public sealed class Solution141
{
	public static bool HasCycle(ListNode? head)
	{
		if (head == null)
			return false;

		// The trick is to use the 1) fast pointer; and the 2) slow pointer
		// If the fast pointer can reach the slow pointer - there is the cycle
		// Otherwise - no cycle
		ListNode? fast = head, slow = head;

		while (fast?.next != null)
		{
			slow = slow?.next;
			fast = fast.next.next;

			if (slow == fast)
				return true;
		}

		return false;
	}
}
