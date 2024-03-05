using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class SolutionPlusOne
{
    public int[] PlusOne(int[] digits)
    {
        var result = new int[digits.Length + 1];
        result[^1] = 1;
        for (var i = digits.Length - 1; i >= 0; i--)
        {
            var digit = digits[i];
            var j = i + 1;
            digit += result[j];

            if (digit > 9)
            {
                result[j] = digit % 10;
                result[j - 1] = digit / 10;
            }
            else
            {
                result[j] = digit;
            }
        }

        if (result[0] == 0)
        {
            return result[1..];
        }
        else
        {
            return result;
        }
    }
}
