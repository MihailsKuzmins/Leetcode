// ReSharper disable InconsistentNaming
namespace MyNihongo.Leetcode.Algorithms;

/// <summary>
/// Given the roots of two binary trees p and q, write a function to check if they are the same or not.<br/>
/// Two binary trees are considered the same if they are structurally identical, and the nodes have the same value.
/// </summary>
public sealed class Solution100
{
	public static bool IsSameTree(TreeNode? p, TreeNode? q)
	{
		if (p == null)
			return q == null;
		if (q == null)
			return false;

		Stack<TreeNode> pStack = new(), qStack = new();

		pStack.Push(p);
		qStack.Push(q);
		while (pStack.Count != 0)
		{
			p = pStack.Pop();
			q = qStack.Pop();

			if (p.val != q.val)
				return false;

			if (p.right != null)
			{
				if (q.right == null)
					return false;

				pStack.Push(p.right);
				qStack.Push(q.right);
			}
			else if (q.right != null)
				return false;

			if (p.left != null)
			{
				if (q.left == null)
					return false;

				pStack.Push(p.left);
				qStack.Push(q.left);
			}
			else if (q.left != null)
				return false;
		}

		return true;
	}
}
