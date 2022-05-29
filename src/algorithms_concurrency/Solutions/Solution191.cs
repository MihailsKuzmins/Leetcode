namespace MyNihongo.Leetcode.Solutions;

/// <summary>
/// Write a function that takes an unsigned integer and returns the number of '1' bits it has (also known as the <b>Hamming weight</b>).
/// </summary>
public sealed class Solution191
{
	public static int HammingWeight(uint n)
	{
		var result = 0;
		while (n > 0)
		{
			if ((n & 1) == 1)
				result++;
			
			n >>= 1;
		}

		return result;
	}
}
