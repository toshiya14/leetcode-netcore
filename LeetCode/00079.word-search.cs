using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class SolutionWordSearch
{
    public bool Exist(char[][] board, string word)
    {
        for (var y = 0; y < board.Length; y++)
        {
            for (var x = 0; x < board[y].Length; x++)
            {
                var rec = new bool[board[y].Length, board.Length];
                if (Backtrack(board, x, y, word, ref rec))
                {
                    return true;
                }
            }
        }

        return false;
    }

    private static bool Backtrack(char[][] board, int x, int y, string word, ref bool[,] rec)
    {
        Console.WriteLine($"{x},{y} {word}");
        if (word.Length == 0)
        {
            return false;
        }

        if (x < 0 || y < 0)
        {
            return false;
        }

        if (y >= board.Length)
        {
            return false;
        }

        if (x >= board[y].Length)
        {
            return false;
        }

        if (board[y][x] != word[0])
        {
            return false;
        }

        if (rec[x, y])
        {
            return false;
        }

        if (word.Length == 1)
        {
            return board[y][x] == word[0];
        }

        rec[x, y] = true;
        // up
        if (Backtrack(board, x, y - 1, word[1..], ref rec))
        {
            return true;
        }

        // right
        if (Backtrack(board, x + 1, y, word[1..], ref rec))
        {
            return true;
        }

        // down
        if (Backtrack(board, x, y + 1, word[1..], ref rec))
        {
            return true;
        }

        // left
        if (Backtrack(board, x - 1, y, word[1..], ref rec))
        {
            return true;
        }
        rec[x, y] = false;
        return false;
    }
}
