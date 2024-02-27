using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class SolutionLongestSubstringWithoutRepeatingCharacters
{
    public int LengthOfLongestSubstring(string s)
    {
        // record the position that the char last appears.
        var indexCache = new Dictionary<char, int>();

        // record each sub result:
        // the longest substring without repeating characters in range [0, i].
        var resultCache = new List<int>(s.Length);

        var maxLength = 0;

        foreach (var (x, i) in s.Select((x, i) => (x, i)))
        {
            int lastAppearsIndex;
            if (!indexCache.TryGetValue(x, out lastAppearsIndex))
            {
                lastAppearsIndex = -1;
            }

            var lastResult = 0;
            if (i > 0)
            {
                lastResult = resultCache[i - 1];
            }

            var newResult = lastResult + 1;
            var substringFromLastAppears = i - lastAppearsIndex;
            var currentResult = Math.Min(newResult, substringFromLastAppears);

            resultCache.Add(currentResult);
            indexCache[x] = i;

            Console.WriteLine($"STEP: i={i}, x={x}, li={lastAppearsIndex}, result=min({newResult}, {substringFromLastAppears}) r={currentResult}");

            if (currentResult > maxLength)
            {
                maxLength = currentResult;
            }
        }

        return maxLength;
    }
}

public class OfficialSolutionLongestSubstringWithoutRepeatingCharacters
{
    public int LengthOfLongestSubstring(string s)
    {
        var startIndex = 0;
        var endIndex = 0;
        var set = new HashSet<char>();
        var maxLength = 0;

        while (endIndex < s.Length)
        {
            var currentChar = s[endIndex];
            if (set.Contains(currentChar))
            {
                var currentLength = endIndex - startIndex;
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                }

                set.Remove(s[startIndex]);
                startIndex++;
            }
            else
            {
                set.Add(currentChar);
                endIndex++;
            }
        }

        return Math.Max(endIndex - startIndex, maxLength);
    }
}
