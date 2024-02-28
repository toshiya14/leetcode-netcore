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

        var i = total / 2;
        var hasM2 = total % 2 == 0;

        int s1 = 0, s2 = 0;

        if (hasM2)
        {
            var m1 = GetNthSmallNum(nums1, nums2, i, ref s1, ref s2);
            //Console.WriteLine($"M1: {m1}, S1: {s1}, S2: {s2}");
            var m2 = GetNthSmallNum(nums1.AsSpan()[s1..], nums2.AsSpan()[s2..], 1, ref s1, ref s2);
            //Console.WriteLine($"M2: {m2}, S1: {s1}, S2: {s2}");
            return (m1 + m2) / 2.0;
        }
        else
        {
            var m1 = GetNthSmallNum(nums1, nums2, i + 1, ref s1, ref s2);
            //Console.WriteLine($"M1: {m1}, S1: {s1}, S2: {s2}");
            return m1;
        }
    }

    public static int GetNthSmallNum(Span<int> nums1, Span<int> nums2, int n, ref int s1, ref int s2)
    {
        var i = Math.Max(0, n / 2 - 1);

        //Console.WriteLine($"VERBOSE: num1={string.Join(',', nums1.ToArray())}, num2={string.Join(',', nums2.ToArray())}, n={n}");

        if (nums1.Length == 0)
        {
            s2 += n;
            return nums2[n - 1];
        }

        if (nums2.Length == 0)
        {
            s1 += n;
            return nums1[n - 1];
        }

        if (n == 1)
        {
            var n1 = nums1[0];
            var n2 = nums2[0];
            if (n1 < n2)
            {
                s1 += 1;
                return n1;
            }
            else
            {
                s2 += 1;
                return n2;
            }

        }
        else
        {
            int i1 = i, i2 = i;
            if (i >= nums1.Length)
            {
                i1 = nums1.Length - 1;
            }
            else if (i >= nums2.Length)
            {
                i2 = nums2.Length - 1;
            }
            var n1 = nums1[i1];
            var n2 = nums2[i2];
            //Console.WriteLine($"VERBOSE: n1={n1}, n2={n2}, i1={i1}, i2={i2}");
            if (n1 < n2)
            {
                s1 += i1 + 1;
                var k = n - i1 - 1;
                return GetNthSmallNum(nums1[(i1 + 1)..], nums2, k, ref s1, ref s2);
            }
            else
            {
                s2 += i2 + 1;
                var k = n - i2 - 1;
                return GetNthSmallNum(nums1, nums2[(i2 + 1)..], k, ref s1, ref s2);
            }
        }

    }
}
