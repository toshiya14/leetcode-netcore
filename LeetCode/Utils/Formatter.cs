using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Utils;
internal static class Formatter
{
    public static string Print2D<T>(T[][] array, int width)
    {
        var sb = new StringBuilder();
        for (var y = 0; y < array.Length; y++)
        {
            for (var x = 0; x < array[y].Length; x++)
            {
                var el = array[y][x]!.ToString()!.PadLeft(width);
                sb.Append(el);
                sb.Append(' ');
            }
            sb.AppendLine();
        }
        return sb.ToString();
    }
}
