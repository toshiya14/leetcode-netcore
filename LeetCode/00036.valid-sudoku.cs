using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class SolutionValidSudoku
{
    public bool IsValidSudoku(char[][] board)
    {
        var rows = InitRec();
        var cols = InitRec();
        var subs = InitRec();

        for (var x = 0; x < 9; x++)
        {
            for (var y = 0; y < 9; y++)
            {

                var digitChar = board[y][x];
                if (digitChar == '.')
                {
                    continue;
                }

                var digit = digitChar - '0' - 1;
                var subx = x / 3;
                var suby = y / 3;
                var subn = suby * 3 + subx;
                if (RecordAndCheck(digit, rows, y) || RecordAndCheck(digit, cols, x) || RecordAndCheck(digit, subs, subn))
                {
                    return false;
                }
            }
        }

        return true;
    }
    private static bool[,] InitRec()
    {
        var rec = new bool[9, 9];
        return rec;
    }
    private static bool RecordAndCheck(int digit, bool[,] rec, int recIndex)
    {
        if (rec[recIndex, digit])
        {
            return true;
        }
        else
        {
            rec[recIndex, digit] = true;
            return false;
        }
    }

}
