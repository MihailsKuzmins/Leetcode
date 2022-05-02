namespace MyNihongo.Leetcode.Solutions;

/// <summary>
/// Write a function to find the longest common prefix string amongst an array of strings.<br/>
/// If there is no common prefix, return an empty string "".<br/>
/// </summary>
public sealed class Solution14
{
	public static string LongestCommonPrefix(string[] strs)
	{
		var result = strs[0].AsSpan();
		for (var i = 1; i < strs.Length; i++)
		{
			for (var j = 0; j < result.Length; j++)
			{
				if (j < strs[i].Length && strs[i][j] == result[j])
					continue;

				if (j == 0)
					return string.Empty;

				result = result[..j];
				break;
			}
		}

		return result.ToString();
	}
}
