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
        if (nums.Length == 0)
        {
            return -1;
        }

        if (nums.Length == 1)
        {
            return nums[0] == target ? 0 : -1;
        }

        return BinarySearch(nums, 0, nums.Length - 1, target);
    }

    private static int BinarySearch(int[] nums, int left, int right, int target)
    {
        if (right <= left)
        {
            if (nums[left] == target)
            {
                return left;
            }
            else if (nums[right] == target)
            {
                return right;
            }
            else
            {
                return -1;
            }
        }

        var mid = (left + right) / 2;
        if (nums[mid] == target)
        {
            return mid;
        }
        else
        {
            var li = BinarySearch(nums, left, mid, target);
            if (li < 0)
            {
                var ri = BinarySearch(nums, mid + 1, right, target);
                return ri;
            }
            else
            {
                return li;
            }
        }
    }
}
