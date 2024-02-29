using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class SolutionDivideTwoIntegers
{
    public int Divide(int dividend, int divisor)
    {

        if (divisor == int.MinValue)
        {
            return dividend == int.MinValue ? 1 : 0;
        }

        var resultOffset = 0;
        var sign = dividend < 0 ^ divisor < 0 ? -1 : 1;
        int a, b;
        if (dividend == int.MinValue)
        {
            if (divisor == 1)
            {
                return int.MinValue;
            }
            else if (divisor == -1)
            {
                return int.MaxValue;
            }
            a = int.MaxValue;
            resultOffset = 1;
        }
        else
        {
            a = Math.Abs(dividend);
        }
        b = Math.Abs(divisor);

        if (a < b)
        {
            return 0;
        }

        if (b == 1)
        {
            return sign * a - resultOffset;
        }

        var counter = 1;
        var x = b;
        Console.WriteLine($"{a}-{x}+{resultOffset}>={b}");
        while (a - x + resultOffset >= b)
        {
            counter++;
            x += b;
        }

        return counter * sign;
    }
}
