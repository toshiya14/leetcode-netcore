using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class SolutionInsertInterval
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        if (intervals.Length == 0)
        {
            return [newInterval];
        }

        if (newInterval[1] < intervals[0][0])
        {
            return [newInterval, .. intervals];
        }

        if (newInterval[0] > intervals[^1][1])
        {
            return [.. intervals, newInterval];
        }

        // find start.
        var start = -1;

        while (start < intervals.Length && (start < 0 || (intervals[start][1] < newInterval[0])))
        {
            start++;
        }

        var end = intervals.Length - 1;
        while (end > 0 && intervals[end][0] > newInterval[1])
        {
            end--;
        }

        //Console.WriteLine($"Selected: {string.Join(',', intervals[start..(end + 1)].Select(x => $"({x[0]},{x[1]})"))}");

        if (end < start)
        {
            return [.. intervals[0..(end + 1)], newInterval, .. intervals[start..]];
        }

        var newLength = intervals.Length - end + start;
        var result = new List<int[]>(newLength);
        for (var i = 0; i < start; i++)
        {
            result.Add(intervals[i]);
        }
        var newIntervalStart = Math.Min(newInterval[0], intervals[start][0]);
        var newIntervalEnd = Math.Max(newInterval[1], intervals[end][1]);
        result.Add([newIntervalStart, newIntervalEnd]);
        for (var i = end + 1; i < intervals.Length; i++)
        {
            result.Add(intervals[i]);
        }
        return [.. result];
    }
}
