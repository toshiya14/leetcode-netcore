using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class SolutionThreeSumClosest
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        if (nums.Length < 3)
        {
            return 0;
        }

        var closest = nums[0] + nums[1] + nums[2];
        var closestDiff = Math.Abs(closest - target);

        Console.WriteLine($"Init: sum={closest}, diff={closestDiff}");

        if (nums.Length == 3)
        {
            return closest;
        }

        var sorted = nums.Order().ToArray();
        for (var i = 0; i < sorted.Length; i++)
        {
            var a = sorted[i];

            if (i != 0 && a == sorted[i - 1])
            {
                continue;
            }

            var left = i + 1;
            var right = sorted.Length - 1;

            while (left < right)
            {
                var sum = sorted[i] + sorted[left] + sorted[right];
                var diff = Math.Abs(sum - target);

                if (diff < closestDiff)
                {

                    Console.WriteLine($"Update: {sorted[i]} + {sorted[left]} + {sorted[right]} = {sum}, diff={diff}");
                    closestDiff = diff;
                    closest = sum;
                }
                else
                {
                    Console.WriteLine($"Ignore: {sorted[i]} + {sorted[left]} + {sorted[right]} = {sum}, diff={diff}");
                }

                if (sum == target)
                {
                    return sum;
                }
                else if (sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }

        return closest;
    }
}
