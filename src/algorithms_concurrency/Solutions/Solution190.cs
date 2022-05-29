namespace MyNihongo.Leetcode.Solutions;

/// <summary>
/// Reverse bits of a given 32 bits unsigned integer.
/// </summary>
public sealed class Solution190
{
	public static uint ReverseBits(uint n)
	{
		var result = 0u;
		for (var i = 0; i < 32; i++)
		{
			result <<= 1; // ensure the bit capacity
			result |= n & 1; // the same as n % 2. set the last bit

			n >>= 1; // the same as n =/ 2
		}

		return result;
	}
}
