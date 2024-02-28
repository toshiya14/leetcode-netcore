using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class SolutionSingleNumber
{
    public int SingleNumber(int[] nums)
    {
        var result = 0;
        foreach (var num in nums)
        {
            result ^= num;
        }

        return result;
    }
}
