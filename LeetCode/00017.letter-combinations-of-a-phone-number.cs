using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class SolutionLetterCombinationsOfAPhoneNumber
{
    static readonly char[][] letters = [
        [],
        [],
        ['a', 'b', 'c'],
        ['d', 'e', 'f'],
        ['g', 'h', 'i'],
        ['j', 'k', 'l'],
        ['m', 'n', 'o'],
        ['p', 'q', 'r', 's'],
        ['t', 'u', 'v'],
        ['w', 'x', 'y', 'z']
    ];
    public IList<string> LetterCombinations(string digits)
    {

        var result = new List<string>();

        if (digits.Length == 0)
        {
            return result;
        }

        var indexes = new int[digits.Length];
        var single = new char[digits.Length];

        while (true)
        {
            // fill
            for (var i = 0; i < digits.Length; i++)
            {
                var digit = digits[i] - '0';
                single[i] = letters[digit][indexes[i]];
            }
            Console.WriteLine($"Single: {new string(single)}");

            result.Add(new string(single));

            // move index
            indexes[^1]++;
            for (var i = indexes.Length - 1; i >= 0; i--)
            {
                var digit = digits[i] - '0';
                if (indexes[i] >= letters[digit].Length)
                {
                    if (i == 0)
                    {
                        return result;
                    }

                    indexes[i - 1]++;
                    indexes[i] = 0;
                }
            }
        }
    }
}
