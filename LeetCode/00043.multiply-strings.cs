using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class SolutionMultiplyStrings
{
    public string Multiply(string num1, string num2)
    {
        //Console.WriteLine($"{num1} x {num2}");
        var result = new int[num1.Length + num2.Length];
        for (var i = 0; i < num1.Length; i++)
        {
            for (var j = 0; j < num2.Length; j++)
            {
                var pos = (num1.Length - i - 1) + (num2.Length - j - 1);
                var n1 = num1[i] - '0';
                var n2 = num2[j] - '0';

                if (n1 == 0 || n2 == 0)
                {
                    continue;
                }

                var digit = n1 * n2;

                result[pos] += digit % 10;
                result[pos + 1] += digit / 10;
            }
        }

        for (var i = 0; i < result.Length; i++)
        {
            if (result[i] > 9)
            {
                var digit = result[i];
                result[i] = digit % 10;
                result[i + 1] += digit / 10;
            }
        }

        var stack = new Stack<int>();
        foreach (var d in result)
        {
            //Console.WriteLine($"push: {d}");
            stack.Push(d);
        }
        var sb = new StringBuilder(result.Length);


        // Remove leading zero.
        while (stack.Count > 0 && stack.Peek() == 0)
        {
            stack.Pop();
        }

        if (stack.Count == 0)
        {
            return "0";
        }

        while (stack.Count > 0)
        {
            var digit = stack.Pop();
            sb.Append(digit);
        }

        return sb.Length == 0 ? "0" : sb.ToString();
    }
}
