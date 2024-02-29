using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class SolutionIntegerToRoman
{
    private static readonly Dictionary<int, char> digits = new()
    {
        [1] = 'I',
        [5] = 'V',
        [10] = 'X',
        [50] = 'L',
        [100] = 'C',
        [500] = 'D',
        [1000] = 'M'
    };

    public string IntToRoman(int num)
    {
        var parts = Divide(num);
        var result = new StringBuilder();
        for (var i = 1; i < parts.Length; i++)
        {
            var (pos, digit) = parts[i];
            for (var j = 0; j < digit; j++)
            {
                result.Append(digits[pos]);
            }
        }

        return result.ToString();
    }

    private static (int pos, int digit)[] Divide(int num)
    {
        var result = new (int pos, int digit)[8];
        var index = 0;
        for (var numbase = 1000; numbase >= 1; numbase /= 10)
        {
            var digit = num / numbase % 10;
            if (digit == 9)
            {
                result[index++] = (1 * numbase, 1);
                result[index++] = (10 * numbase, 1);
            }
            else if (digit == 4)
            {
                result[index++] = (1 * numbase, 1);
                result[index++] = (5 * numbase, 1);
            }
            else if (digit < 5)
            {
                result[index++] = (0, 0);
                result[index++] = (numbase, digit);
            }
            else
            {
                result[index++] = (5 * numbase, 1);
                result[index++] = (numbase, digit - 5);
            }
        }
        return result;
    }
}
