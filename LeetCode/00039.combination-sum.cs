using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class SolutionCombinationSum
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        var result = new List<IList<int>>();
        var sorted = candidates.Order().ToArray();
        Backtrack(sorted, result, [], 0, 0, target);
        return result;
    }

    private static void Backtrack(int[] candidates, IList<IList<int>> rec, int[] chosen, int startChoice, int sum, int target)
    {

        for (var i = startChoice; i < candidates.Length; i++)
        {
            var num = candidates[i];
            var newSum = sum + num;
            int[] newChosen = [.. chosen, num];
            //Console.WriteLine($"Backtrack, chosen={string.Join(",", newChosen)}, current={i}, sum={newSum}, target={target}");

            // check sum
            if (newSum == target)
            {
                rec.Add(newChosen);
                return;
            }

            if (newSum > target)
            {
                return;
            }

            Backtrack(candidates, rec, [.. chosen, num], i, sum + num, target);
        }
    }
}
