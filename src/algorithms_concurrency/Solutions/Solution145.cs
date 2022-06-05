// ReSharper disable InconsistentNaming
namespace MyNihongo.Leetcode.Solutions;

/// <summary>
/// Given the root of a binary tree, return the postorder traversal of its nodes' values.
/// </summary>
public sealed class Solution145
{
	public static IList<int> PostorderTraversal(TreeNode? root)
	{
		if (root == null)
			return Array.Empty<int>();

		var list = new List<int>();
		var stack = new Stack<TreeNode>();
		stack.Push(root);
		
		TreeNode? prev = null;
		while (stack.Count != 0)
		{
			var node = stack.Peek();

			// go down the tree in search of a leaf and
			// if so process it and pop stack otherwise move down
			if (prev == null || prev.left == node || prev.right == node)
			{
				if (node.left != null)
					stack.Push(node.left);
				else if (node.right != null)
					stack.Push(node.right);
				else
				{
					stack.Pop();
					list.Add(node.val);
				}
			}
			// go up the tree from left node, if the child is right
			// push it onto stack otherwise process parent and pop the stack
			else if (node.left == prev)
			{
				if (node.right != null)
					stack.Push(node.right);
				else
				{
					stack.Pop();
					list.Add(node.val);
				}
			}
			// go up the tree from right node and after coming back
			// from right node process parent and pop the stack
			else if (node.right == prev)
			{
				stack.Pop();
				list.Add(node.val);
			}

			prev = node;
		}

        return list;
	}
}
