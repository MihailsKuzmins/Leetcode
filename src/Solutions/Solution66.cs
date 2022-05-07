namespace MyNihongo.Leetcode.Solutions;

/// <summary>
/// You are given a <b>large integer</b> represented as an integer array digits, where each digits[i] is the ith digit of the integer. The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.<br/>
/// Increment the large integer by one and return the <i>resulting array of digits</i>.
/// </summary>
public sealed class Solution66
{
	public static int[] PlusOne(int[] digits)
	{
		for (var i = digits.Length - 1; i >= 0; i--)
		{
			if (digits[i] < 9)
			{
				digits[i]++;
				return digits;
			}

			digits[i] = 0;
		}

		// If we reach this point we need to increment the first digit
		var arr = new int[digits.Length + 1];
		arr[0] = 1;

		for (var i = 1; i < arr.Length; i++)
			arr[i] = digits[i - 1];

		return arr;
	}
}
