using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class SolutionLongestNiceSubstring
{
    public string LongestNiceSubstring(string s)
    {
        return FindNiceSubstring(s);
    }

    private static string FindNiceSubstring(string s)
    {
        if (s.Length < 2)
        {
            return string.Empty;
        }
        else if (s.Length == 2)
        {
            if (Math.Abs(s[0] - s[1]) == 32)
            {
                return s;
            }
            else
            {
                return string.Empty;
            }
        }

        var indexes = new Dictionary<char, int>();
        for (var i = 0; i < s.Length; i++)
        {
            var c = s[i];
            var isLower = c >= 'a' && c <= 'z';
            var another = isLower ? char.ToUpper(c) : char.ToLower(c);

            if (indexes.ContainsKey(another))
            {
                indexes[c] = -1;
                indexes[another] = -1;
            }
            else
            {
                indexes[c] = i;
            }
        }

        var alone = indexes.Where(x => x.Value > -1);
        var alonestr = string.Join(',', alone.Select(x => $"{x.Key}:{x.Value}"));
        //Console.WriteLine($"alone: {s} -> {alonestr}");
        if (!alone.Any())
        {
            return s;
        }

        // build search indexes
        var left = 0;
        var regions = new List<(int left, int right)>();
        foreach (var (_, i) in alone)
        {
            regions.Add((left, i));
            left = i + 1;
        }
        regions.Add((left, s.Length));

        var result = string.Empty;
        foreach (var (i, right) in regions)
        {
            var length = right - i;
            //Console.WriteLine($"Search: left={i}, length={length}");
            if (length > 1)
            {
                var substr = s[i..right];
                //Console.WriteLine($"Search: {substr}");
                var nice = FindNiceSubstring(substr);
                if (!string.IsNullOrEmpty(nice))
                {
                    if (nice.Length > result.Length)
                    {
                        result = nice;
                    }
                }
            }
        }

        return result;
    }
}
