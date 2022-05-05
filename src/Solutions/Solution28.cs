namespace MyNihongo.Leetcode.Solutions;

/// <summary>
/// Implement strStr().<br/>
/// Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.<br/>
/// <b>Clarification:</b><br/>
/// What should we return when needle is an empty string? This is a great question to ask during an interview.<br/>
/// For the purpose of this problem, we will return 0 when needle is an empty string. This is consistent to C's strstr() and Java's indexOf().
/// </summary>
public sealed class Solution28
{
	public static int StrStr(string haystack, string needle)
	{
		if (haystack.Length == 0)
			return -1;
		if (needle.Length == 0)
			return 0;

		for (var i = 0; i < haystack.Length && i + needle.Length <= haystack.Length; i++)
		{
			var j = 0;
			for (; j < needle.Length; j++)
			{
				if (needle[j] != haystack[i + j])
					goto Continue;
			}

			if (j == needle.Length)
				return i;

			Continue:;
		}

		return -1;
	}
}
