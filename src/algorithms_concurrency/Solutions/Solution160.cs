// ReSharper disable InconsistentNaming
namespace MyNihongo.Leetcode.Solutions;

/// <summary>
/// Given the heads of two singly linked-lists headA and headB, return the node at which the two lists intersect. If the two linked lists have no intersection at all, return null.
/// </summary>
public sealed class Solution160
{
	public static ListNode? GetIntersectionNode(ListNode? headA, ListNode? headB)
	{
		if (headA == null || headB == null)
			return null;

		// The idea is to set the current pointer of one list to the start pointer of another list
		// Therefore, it is guaranteed that they will meet at the intersection after the swap of pointers
		// If there is no intersection both pointers will be null
		ListNode? currA = headA, currB = headB;
		while (currA != currB)
		{
			currA = currA != null
				? currA.next
				: headB;

			currB = currB != null
				? currB.next
				: headA;
		}

		return currA;
	}
}
