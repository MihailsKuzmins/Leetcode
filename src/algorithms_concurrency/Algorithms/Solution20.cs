namespace MyNihongo.Leetcode.Algorithms;

/// <summary>
/// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.<br/>
/// An input string is valid if:<br/>
/// - Open brackets must be closed by the same type of brackets.<br/>
/// - Open brackets must be closed in the correct order.
/// </summary>
public sealed class Solution20
{
	public static bool IsValid(string s)
	{
		if (s.Length % 2 != 0)
			return false;

		var sequenceStack = new Stack<char>();
		char pop;
		for (var i = 0; i < s.Length; i++)
		{
			switch (s[i])
			{
				// Simple
				case '(':
					sequenceStack.Push(s[i]);
					break;
				case ')':
					if (!sequenceStack.TryPop(out pop) || pop != '(')
						return false;

					break;
				// Square
				case '[':
					sequenceStack.Push(s[i]);
					break;
				case ']':
					if (!sequenceStack.TryPop(out pop) || pop != '[')
						return false;

					break;
				// Curly
				case '{':
					sequenceStack.Push(s[i]);
					break;
				case '}':
					if (!sequenceStack.TryPop(out pop) || pop != '{')
						return false;

					break;
			}
		}

		return sequenceStack.Count == 0;
	}
}
