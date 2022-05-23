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

		var temp = root;
		var visited = new HashSet<TreeNode>();
		var list = new List<int>();

		while (temp != null && !visited.Contains(temp))
		{
			if (temp.left != null && !visited.Contains(temp.left))
				temp = temp.left;
			else if (temp.right != null && !visited.Contains(temp.right))
				temp = temp.right;
			else
			{
				list.Add(temp.val);

				visited.Add(temp);
				temp = root;
			}
		}

		return list;
	}

	public sealed class TreeNode
	{
		public int val;
		public TreeNode? left;
		public TreeNode? right;

		public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
		{
			this.val = val;
			this.left = left;
			this.right = right;
		}

		public override string ToString()
		{
			return val.ToString();
		}
	}
}
