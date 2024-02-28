using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class SolutionSumOfUniqueElements
{
    public int SumOfUnique(int[] nums)
    {
        var unique = new HashSet<int>();
        var repeated = new HashSet<int>();

        foreach (var num in nums)
        {
            if (repeated.Contains(num))
            {
                continue;
            }

            if (unique.Contains(num))
            {
                unique.Remove(num);
                repeated.Add(num);
                continue;
            }

            unique.Add(num);
        }

        return unique.Sum();
    }
}
