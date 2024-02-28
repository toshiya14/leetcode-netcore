using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class SolutionPrimeInDiagonal
{
    public int DiagonalPrime(int[][] nums)
    {
        var set = new HashSet<int>();
        var length = nums.Length;
        for (var x = 0; x < length; x++)
        {
            FilterAndAdd(set, nums[x][x]);
            FilterAndAdd(set, nums[x][length - x - 1]);
        }

        foreach (var num in set.Order().Reverse())
        {
            if (IsPrime(num))
            {
                return num;
            }
        }

        return 0;
    }


    private static void FilterAndAdd(HashSet<int> set, int num)
    {
        if (num < 2 || (num % 2 == 0 && num != 2))
        {
            return;
        }

        set.Add(num);
    }
    private static bool IsPrime(int num)
    {
        if (num == 2)
        {
            return true;
        }

        for (var i = 3; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
