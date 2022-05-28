namespace MyNihongo.Leetcode.Solutions;

/// <summary>
/// Given a string columnTitle that represents the column title as appears in an Excel sheet, return its <i>corresponding column number</i>.
/// </summary>
public sealed class Solution171
{
	public static int TitleToNumber(string columnTitle)
	{
		var result = 0;
		for (int i = columnTitle.Length - 1, pow = 1; i >= 0; i--, pow *= 26)
		{
			var num = columnTitle[i] - 'A' + 1;
			result += num * pow;
		}

		return result;
	}
}
