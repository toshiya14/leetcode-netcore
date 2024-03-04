using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class SolutionNextPermutation
{
    public void NextPermutation(int[] nums)
    {
        if (nums.Length < 2)
        {
            return;
        }

        if (nums.Length == 2)
        {
            (nums[1], nums[0]) = (nums[0], nums[1]);
            return;
        }

        var p = -1;
        for (var i = nums.Length - 1; i > 0; i--)
        {
            if (nums[i - 1] < nums[i])
            {
                p = i - 1;
                break;
            }
        }

        // swap nums[p] and nums[^1]
        if (p > -1)
        {
            // find the number from [p, length), smallest but larger than p.
            var targetIndex = -1;
            var smallest = int.MaxValue;
            for (var i = nums.Length - 1; i > p; i--)
            {
                if (nums[i] > nums[p] && nums[i] < smallest)
                {
                    smallest = nums[i];
                    targetIndex = i;
                }
            }
            if (targetIndex > -1)
            {
                (nums[p], nums[targetIndex]) = (nums[targetIndex], nums[p]);
            }

            Console.WriteLine($"p={p}, smallest={smallest}, swap:{p},{targetIndex}, nums={string.Join(',', nums)}");
        }

        // reverse
        for (var i = 0; i < (nums.Length - p) / 2; i++)
        {
            var i1 = p + i + 1;
            var i2 = nums.Length - i - 1;
            (nums[i1], nums[i2]) = (nums[i2], nums[i1]);

            Console.WriteLine($"swap:{i1},{i2}, nums={string.Join(',', nums)}");
        }

        Console.WriteLine($"Result: {string.Join(',', nums)}");
    }
}
