// ReSharper disable InconsistentNaming
namespace MyNihongo.Leetcode.Solutions;

/// <summary>
/// You are given the heads of two sorted linked lists list1 and list2.<br/>
/// Merge the two lists in a one <b>sorted</b> list. The list should be made by splicing together the nodes of the first two lists.<br/>
/// Return the <i>head of the merged linked list</i>.
/// </summary>
public sealed class Solution21
{
	public static ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
	{
		if (list1 == null)
			return list2;
		if (list2 == null)
			return list1;

		ListNode? start;
		if (list1.val < list2.val)
		{
			start = list1;
			list1 = list1.next;
		}
		else
		{
			start = list2;
			list2 = list2.next;
		}

		var i = start;
		while (list1 != null && list2 != null)
		{
			if (list1.val < list2.val)
			{
				i.next = list1;
				list1 = list1.next;
			}
			else
			{
				i.next = list2;
				list2 = list2.next;
			}
			i = i.next;
		}

		if (list1 != null)
			i.next = list1;
		else if (list2 != null)
			i.next = list2;

		return start;
	}
}
