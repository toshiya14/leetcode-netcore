using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class SolutionRotateImage
{
    public void Rotate(int[][] matrix)
    {
        var n = matrix.Length;
        var i = 0;
        for (var y = 0; y < n; y++)
        {
            for (var x = y; x < n; x++)
            {
                if (x >= n - y - 1)
                {
                    break;
                }

                var p1x = x;
                var p1y = y;

                var p2x = n - 1 - y;
                var p2y = x;

                var p3x = n - 1 - x;
                var p3y = n - 1 - y;

                var p4x = y;
                var p4y = n - 1 - x;

                var temp = matrix[p1y][p1x];
                matrix[p1y][p1x] = matrix[p4y][p4x];
                matrix[p4y][p4x] = matrix[p3y][p3x];
                matrix[p3y][p3x] = matrix[p2y][p2x];
                matrix[p2y][p2x] = temp;

                i++;
                Console.WriteLine($"==== Round {i} ====");
                Console.WriteLine(Utils.Formatter.Print2D(matrix, 2));
            }
        }
    }
}
