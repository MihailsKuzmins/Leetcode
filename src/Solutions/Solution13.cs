namespace MyNihongo.Leetcode.Solutions;

/// <summary>
/// Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.<br/>
/// I -> 1<br/>
/// V -> 5<br/>
/// X -> 10<br/>
/// L -> 50<br/>
/// C -> 100<br/>
/// D -> 500<br/>
/// M -> 1000<br/><br/>
/// For example, 2 is written as II in Roman numeral, just two one's added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.<br/>
/// Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:<br/>
/// - I can be placed before V (5) and X (10) to make 4 and 9.<br/>
/// - X can be placed before L (50) and C (100) to make 40 and 90.<br/>
/// - C can be placed before D (500) and M (1000) to make 400 and 900.<br/><br/>
/// Given a roman numeral, convert it to an integer.
/// </summary>
public sealed class Solution13
{
	public static int RomanToInt(string s)
	{
		var result = 0;
		for (int i = 0, lastIndex = s.Length - 1; i < s.Length; i++)
		{
			switch (s[i])
			{
				case 'I':
					if (i < lastIndex)
					{
						switch (s[i + 1])
						{
							case 'V':
								i++;
								result += 4;
								goto Continue;
							case 'X':
								i++;
								result += 9;
								goto Continue;
						}
					}
					result++;
					break;
				case 'V':
					result += 5;
					break;
				case 'X':
					if (i < lastIndex)
					{
						switch (s[i + 1])
						{
							case 'L':
								i++;
								result += 40;
								goto Continue;
							case 'C':
								i++;
								result += 90;
								goto Continue;
						}
					}
					result += 10;
					break;
				case 'L':
					result += 50;
					break;
				case 'C':
					if (i < lastIndex)
					{
						switch (s[i + 1])
						{
							case 'D':
								i++;
								result += 400;
								goto Continue;
							case 'M':
								i++;
								result += 900;
								goto Continue;
						}
					}
					result += 100;
					break;
				case 'D':
					result += 500;
					break;
				case 'M':
					result += 1000;
					break;
			}
		Continue:;
		}

		return result;
	}
}
