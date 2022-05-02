namespace MyNihongo.Leetcode.Solutions;

/// <summary>
/// Given an integer x, return true if x is palindrome integer.<br/>
/// An integer is a <b>palindrome</b> when it reads the same backward as forward.<br/>
/// For example, 121 is a palindrome while 123 is not.
/// </summary>
public sealed class Solution9
{
	public bool IsPalindrome(int x)
	{
		if (x < 0)
			return false;

		int reversed = 0, initial = x;
		while (x > 0)
		{
			reversed = reversed * 10 + x % 10;
			x /= 10;
		}

		return initial == reversed;
	}
}
