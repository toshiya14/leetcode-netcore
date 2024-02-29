using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class SolutionRemoveElement
{
    public int RemoveElement(int[] nums, int val)
    {
        var length = nums.Length;
        var insertPos = nums.Length - 1;

        for (var i = 0; i < length; i++)
        {
            while (nums[insertPos] == val)
            {
                length--;
                insertPos--;

                if (length == 0)
                {
                    return 0;
                }
            }

            if (insertPos < i)
            {
                break;
            }

            if (nums[i] == val)
            {
                var temp = nums[insertPos];
                nums[insertPos] = temp;
                nums[i] = temp;
                insertPos--;
                length--;
            }
        }

        return length;
    }
}
