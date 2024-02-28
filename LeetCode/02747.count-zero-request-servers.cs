using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class SolutionCountZeroRequestServers
{


    public int[] CountServers(int n, int[][] logs, int x, int[] queries)
    {
        var sortedLogs = logs.OrderBy(x => x[1]).ToArray();
        var sortedQueries = queries.Select((x, i) => (x, i)).OrderBy(x => x.x);

        var result = new int[queries.Length];

        var left = 0;
        var right = -1;
        var record = new Dictionary<int, int>();

        foreach (var query in sortedQueries)
        {
            var endTime = query.x;
            var startTime = endTime - x;
            var originalQueryIndex = query.i;

            MoveCursorToTime(sortedLogs, ref left, startTime, true, ref record);
            if (right < left)
            {
                right = left;
            }
            MoveCursorToTime(sortedLogs, ref right, endTime, false, ref record);

            var rec = string.Join('|', record.Where(x => x.Value > 0).Select(x => $"{x.Key}:{x.Value}"));
            Console.WriteLine($"left={left}, right={right}, record={rec}, origin={originalQueryIndex}");

            var count = record.Count(x => x.Value > 0);
            result[originalQueryIndex] = n - count;
        }

        return result;
    }

    private static void MoveCursorToTime(int[][] sortedLogs, ref int cursor, int time, bool movingLeftCursor, ref Dictionary<int, int> record)
    {
        while (true)
        {
            if (cursor >= sortedLogs.Length)
            {
                return;
            }

            var currentTime = sortedLogs[cursor][1];
            var currentServerId = sortedLogs[cursor][0];

            if (movingLeftCursor)
            {
                if (currentTime >= time)
                {
                    return;
                }

                Counter(ref record, currentServerId, -1);
                cursor++;
            }
            else
            {
                if (currentTime > time)
                {
                    return;
                }

                Counter(ref record, currentServerId, 1);
                cursor++;
            }
        }
    }

    private static void Counter(ref Dictionary<int, int> record, int sid, int delta)
    {
        if (record.ContainsKey(sid))
        {
            record[sid] += delta;
        }
        else
        {
            record[sid] = delta;
        }

        if (record[sid] < 0)
        {
            record[sid] = 0;
        }
    }
}
