namespace MyNihongo.Leetcode.Algorithms;

/// <summary>
/// Given a string s consisting of some words separated by some number of spaces, return the length of the <b>last</b> word in the string.<br/>
/// A <b>word</b> is a maximal substring consisting of non-space characters only.
/// </summary>
public sealed class Solution58
{
	public static int LengthOfLastWord(string s)
	{
		var length = 0;
		for (var i = s.Length - 1; i >= 0; i--)
		{
			if (s[i] == ' ')
			{
				if (length > 0)
					return length;

				continue;
			}

			length++;
		}

		return length;
	}
}
