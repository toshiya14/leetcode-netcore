using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class SolutionJumpGameII
{
    public int Jump(int[] nums)
    {
        return Next(nums, 0, 0);
    }

    private static int Next(int[] nums, int current, int steps)
    {
        if (current >= nums.Length - 1)
        {
            return steps;
        }

        var maxSteps = nums[current];

        var maxJumpIndex = current;
        var maxJumpPosition = 0;
        for (var i = 0; i <= maxSteps; i++)
        {
            var next = current + i;
            if (next >= nums.Length - 1)
            {
                return steps + 1;
            }
            var longestPosition = next + nums[next];

            if (longestPosition > maxJumpPosition)
            {
                maxJumpIndex = next;
                maxJumpPosition = longestPosition;
            }
        }

        Console.WriteLine($"next: {maxJumpIndex}, steps: {steps + 1}");
        return Next(nums, maxJumpIndex, steps + 1);
    }
}
