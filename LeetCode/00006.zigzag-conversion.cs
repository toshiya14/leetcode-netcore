using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class SolutionZigZagConversion
{
    public string Convert(string s, int numRows)
    {
        if (numRows < 2)
        {
            return s;
        }

        var blockSize = 2 * numRows - 2;
        var blocks = Divide(s, blockSize);

        var sb = new StringBuilder(s.Length);
        for (var row = 0; row < numRows; row++)
        {
            foreach (var (block, blockIndex) in blocks.Select((x, i) => (x, i)))
            {
                var span = block.Span;
                sb.Append(TakeOrEmpty(span, row));
                if (row != 0 && row != numRows - 1)
                {
                    sb.Append(TakeOrEmpty(span, blockSize - row));
                }
            }
        }

        return sb.ToString();
    }

    private static List<Memory<char>> Divide(string s, int blockSize)
    {
        var blocksCount = (int)Math.Ceiling(s.Length / (double)blockSize);
        char[] array = [.. s];
        var result = new List<Memory<char>>(blocksCount);

        for (var i = 0; i < blocksCount; i++)
        {
            var start = i * blockSize;
            var rest = s.Length - start;
            var length = Math.Min(rest, blockSize);
            result.Add(new Memory<char>(array, start, length));
        }

        return result;
    }

    private static string TakeOrEmpty(Span<char> chars, int index)
    {
        if (index >= chars.Length)
        {
            return string.Empty;
        }

        return chars[index].ToString();
    }
}
