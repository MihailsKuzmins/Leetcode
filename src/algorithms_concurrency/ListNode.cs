// ReSharper disable InconsistentNaming
namespace MyNihongo.Leetcode;

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
		return val.ToString();
	}
}