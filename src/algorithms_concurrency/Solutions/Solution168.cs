namespace MyNihongo.Leetcode.Solutions;

/// <summary>
/// Given an integer columnNumber, return its corresponding column title as it appears in an Excel sheet.
/// </summary>
public sealed class Solution168
{
	public static string ConvertToTitle(int columnNumber)
	{
		var stringBuilder = new System.Text.StringBuilder();
		while (columnNumber > 0)
		{
			var division = (char)('A' + (columnNumber - 1) % 26);
			stringBuilder.Insert(0, division);

			columnNumber = (columnNumber - 1) / 26;
		}

		return stringBuilder.ToString();
	}
}
