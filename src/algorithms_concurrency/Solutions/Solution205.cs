namespace MyNihongo.Leetcode.Solutions;

/// <summary>
/// Given two strings s and t, determine if they are <i>isomorphic</i>.<br/>
/// Two strings s and t are isomorphic if the characters in s can be replaced to get t.<br/>
/// All occurrences of a character must be replaced with another character while preserving the order of characters. No two characters may map to the same character, but a character may map to itself.
/// </summary>
public sealed class Solution205
{
	public static bool IsIsomorphic(string s, string t)
	{
		if (s.Length != t.Length)
			return false;

		var mapping = new Dictionary<char, char>();
		for (var i = 0; i < s.Length; i++)
		{
			if (mapping.TryGetValue(s[i], out var mappingChar))
			{
				if (mappingChar != t[i])
					return false;
			}
			else
			{
				if (mapping.ContainsValue(t[i]))
					return false;

				mapping[s[i]] = t[i];
			}
		}

		return true;
	}
}
