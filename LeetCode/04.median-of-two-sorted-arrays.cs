using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class SolutionMedianOfTwoSortedArrays
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var m = nums1.Length;
        var n = nums2.Length;

        var total = m + n;

        int mi1, mi2;
        if (total % 2 == 0)
        {
            mi1 = total / 2 - 1;
            mi2 = total / 2;
        }
        else
        {
            mi1 = total / 2;
            mi2 = -1;
        }

        //Console.Write($"mi1={mi1}, mi2={mi2}");

        int i1 = 0, i2 = 0;
        int m1 = -1, m2 = -1;
        for (var gi = 0; gi <= mi1 + 1; gi++)
        {
            int current;
            var i1Overflow = i1 >= nums1.Length;
            var i2Overflow = i2 >= nums2.Length;
            if (i1Overflow && i2Overflow)
            {
                break;
            }
            else if (i1Overflow)
            {
                current = nums2[i2];
                i2++;
            }
            else if (i2Overflow)
            {
                current = nums1[i1];
                i1++;
            }
            else
            {
                var n1 = nums1[i1];
                var n2 = nums2[i2];

                if (n1 < n2)
                {
                    current = n1;
                    i1++;
                }
                else
                {
                    current = n2;
                    i2++;
                }
            }

            if (gi == mi1)
            {
                m1 = current;
            }

            if (gi == mi2)
            {
                m2 = current;
            }
        }

        if (mi2 < 0)
        {
            return m1;
        }
        else
        {
            return (m1 + m2) / 2.0;
        }
    }
}
