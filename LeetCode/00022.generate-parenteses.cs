using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class SolutionGenerateParenteses
{
    public IList<string> GenerateParenthesis(int n)
    {
        var results = new List<string>();
        Backtrack(results, "", n, n);
        return results;
    }

    private static void Backtrack(List<string> results, string based, int leftRest, int rightRest)
    {
        if (leftRest > 0)
        {
            Backtrack(results, based + "(", leftRest - 1, rightRest);
        }

        if (rightRest > 0 && leftRest < rightRest)
        {
            Backtrack(results, based + ")", leftRest, rightRest - 1);
        }

        if (leftRest == 0 && rightRest == 0)
        {
            results.Add(based);
        }
    }
}
