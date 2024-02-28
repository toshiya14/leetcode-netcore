using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class SolutionLongestPalindromicSubstring
{
    public string LongestPalindrome(string s)
    {
        if (s.Length == 0)
        {
            return s;
        }

        var result = string.Empty;

        for (var i = 0; i < s.Length; i += 1)
        {
            // case 1: use one real index of the string as center.
            var result1 = FindSubString(s, i, i);
            // case 1: use virtual index of the string as center.
            var result2 = FindSubString(s, i, i + 1);


            if (result1.Length > result.Length)
            {
                result = result1;
            }

            if (result2.Length > result.Length)
            {
                result = result2;
            }

            //Console.WriteLine($"MAX: s={result}");
        }

        return result;
    }

    private static string FindSubString(string s, int leftStartIndex, int rightStartIndex)
    {
        var distance = 0;
        int leftIndex;
        int rightIndex;
        while (true)
        {
            leftIndex = leftStartIndex - distance;
            rightIndex = rightStartIndex + distance;
            //Console.WriteLine($"WORK ON: left={leftIndex}, right={rightIndex}");

            if (rightIndex >= s.Length || leftIndex < 0)
            {
                break;
            }

            var left = s[leftIndex];
            var right = s[rightIndex];
            if (left != right)
            {
                break;
            }

            distance += 1;
        }

        leftIndex++;
        rightIndex--;
        var length = rightIndex - leftIndex + 1;

        //startIndex = leftIndex;
        //takeCount = length;
        var result = length < 1 ? string.Empty : s.Substring(leftIndex, length);
        //Console.WriteLine($"SUBSTRING: start={leftIndex}, length={length}, result={result}");
        return result;
    }
}
