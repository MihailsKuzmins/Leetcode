// ReSharper disable InconsistentNaming
namespace MyNihongo.Leetcode.Solutions;

/// <summary>
/// Solution155
/// Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.<br/>
/// </summary>
public sealed class MinStack
{
	private readonly List<int> _stack = new(),
		_minStack = new();

	public void Push(int val)
	{
		_stack.Add(val);

		var valIndex = GetItemIndex(_minStack, val);
		_minStack.Insert(valIndex, val);
	}

	public void Pop()
	{
		var val = _stack[^1];
		_stack.RemoveAt(_stack.Count - 1);

		var valIndex = GetItemIndex(_minStack, val);
		_minStack.RemoveAt(valIndex);
	}

	public int Top()
	{
		return _stack[^1];
	}

	public int GetMin()
	{
		return _minStack[^1];
	}

	private static int GetItemIndex(in IReadOnlyList<int> stack, in int val)
	{
		int i = 0, j = stack.Count - 1;
		while (i <= j)
		{
			var mid = (i + j) / 2;

			if (stack[mid] > val)
				i = mid + 1;
			else if (stack[mid] < val)
				j = mid - 1;
			else
				return mid;
		}

		return i;
	}
}
