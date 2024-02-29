using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class SolutionThreeSum
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var sorted = nums.Order().ToArray();
        var result = new List<IList<int>>();
        for (var i = 0; i < sorted.Length; i++)
        {
            var a = sorted[i];

            if (a > 0)
            {
                break;
            }

            if (i != 0 && a == sorted[i - 1])
            {
                continue;
            }

            var left = i + 1;
            var right = sorted.Length - 1;

            while (left < right)
            {
                var sum = sorted[i] + sorted[left] + sorted[right];

                if (sum == 0)
                {
                    Console.WriteLine($"Find: {sorted[i]} {sorted[left]} {sorted[right]}");
                    result.Add(new[] { sorted[i], sorted[left], sorted[right] });

                    while (left < sorted.Length - 1 && sorted[left] == sorted[left + 1])
                    {
                        Console.WriteLine($"Skipped: {left}: {sorted[left]}");
                        left++;
                    }
                    left++;

                    while (right > 1 && sorted[right] == sorted[right - 1])
                    {
                        Console.WriteLine($"Skipped: {right}: {sorted[right]}");
                        right--;
                    }
                    right--;
                }
                else if (sum > 0)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }
        }

        return result;
    }
}
