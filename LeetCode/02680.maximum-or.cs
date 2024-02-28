using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class SolutionMaximumOr
{

    public long MaximumOr(int[] nums, int k)
    {
        // build sufmap
        // sufmap[i] = nums[n-1] | nums[n-2] | ... | nums[i]
        var sufmap = new long[nums.Length + 1];
        var last = 0;
        for (var i = nums.Length; i >= 0; i--)
        {
            if (i == nums.Length)
            {
                sufmap[i] = 0;
            }
            else
            {
                last |= nums[i];
                sufmap[i] = last;
            }
        }

        var pre = 0L;
        var max = 0L;
        for (var i = 0; i < nums.Length; i++)
        {
            //Console.WriteLine($"RESULT: i={i}, pre={pre} | can={candidate} | suf={sufmap[i + 1]}");
            var num = (long)nums[i];
            var candidate = num << k;
            var result = pre | candidate | sufmap[i + 1];
            if (result > max)
            {
                max = result;
            }
            pre |= num;
        }

        return max;
    }
}
