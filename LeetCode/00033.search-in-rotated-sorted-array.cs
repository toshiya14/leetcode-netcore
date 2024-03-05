using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class SolutionSearchInRotatedSortedArray
{
    public int Search(int[] nums, int target)
    {
        //Console.WriteLine($"New: {string.Join(',', nums)}, target={target}");
        if (nums.Length == 0)
        {
            return -1;
        }

        if (nums.Length == 1)
        {
            return nums[0] == target ? 0 : -1;
        }

        // 1. Find k
        var k = 0;
        for (var i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] > nums[i + 1])
            {
                k = nums.Length - i - 1;
            }
        }

        // 2. Binary Search
        return BinarySearch(nums, k, 0, nums.Length - 1, target);
    }

    private static int BinarySearch(int[] nums, int k, int left, int right, int target)
    {
        //Console.WriteLine($"BinarySearch: k={k}, l={left}, r={right}");
        if (left == right)
        {
            var realleft = GetRealIndex(left, k, nums.Length);
            if (target == nums[realleft])
            {
                return realleft;
            }
            else
            {
                return -1;
            }
        }
        else if (right < left)
        {
            return -1;
        }

        var mid = (left + right) / 2;
        var realmid = GetRealIndex(mid, k, nums.Length);
        //Console.WriteLine($"mid: {mid}, realmid: {realmid}");
        if (nums[realmid] == target)
        {
            return realmid;
        }
        else if (nums[realmid] < target)
        {
            return BinarySearch(nums, k, mid + 1, right, target);
        }
        else
        {
            return BinarySearch(nums, k, left, mid - 1, target);
        }
    }

    private static int GetRealIndex(int i, int k, int len)
    {
        return (len - k + i) % len;
    }
}
