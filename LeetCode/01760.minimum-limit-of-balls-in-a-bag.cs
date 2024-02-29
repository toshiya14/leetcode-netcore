using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class SolutionMinimumLimitOfBallsInABag
{
    public int MinimumSize(int[] nums, int maxOperations)
    {
        var max = nums.Max();
        var left = 1;
        var right = max;

        while (true)
        {
            var mid = (left + right) / 2;
            var steps = CountOperation(nums, mid);
            //Console.WriteLine($"left={left}, right={right}, mid={mid}, steps={steps}");

            if (left == right)
            {
                return mid;
            }

            if (steps > maxOperations)
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }
    }

    private static int CountOperation(int[] nums, int limit)
    {
        var steps = 0;
        foreach (var num in nums)
        {
            if (num > limit)
            {
                steps += (num - 1) / limit;
            }
        }

        return steps;
    }
}
