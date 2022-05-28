namespace MyNihongo.Leetcode.Solutions;

/// <summary>
/// A phrase is a <b>palindrome</b> if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.<br/>
/// Given a string s, return true if it is a <b>palindrome</b>, or false otherwise.
/// </summary>
public sealed class Solution125
{
	public static bool IsPalindrome(string s)
	{
		int i = 0, j = s.Length - 1;
		while (i < j)
		{
			if (!char.IsLetterOrDigit(s[i]))
			{
				i++;
				continue;
			}

			if (!char.IsLetterOrDigit(s[j]))
			{
				j--;
				continue;
			}

			if (char.ToLowerInvariant(s[i]) != char.ToLowerInvariant(s[j]))
				return false;

			i++;
			j--;
		}

		return true;
	}
}
