﻿// ReSharper disable InconsistentNaming
namespace MyNihongo.Leetcode;

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
