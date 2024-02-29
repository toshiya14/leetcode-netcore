using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;
public class SolutionSimplifyPath
{
    public string SimplifyPath(string path)
    {
        var lastStringStartIndex = -1;
        var list = new List<string>();
        for (var p = 0; p <= path.Length; p++)
        {
            if (p == path.Length || path[p] == '/')
            {
                if (lastStringStartIndex != -1)
                {
                    var substr = path[lastStringStartIndex..p];
                    if (substr == ".")
                    {
                        lastStringStartIndex = -1;
                        continue;
                    }
                    else if (substr == "..")
                    {
                        if (list.Count != 0)
                        {
                            list.RemoveAt(list.Count - 1);
                        }
                    }
                    else
                    {
                        list.Add(substr);
                    }
                    lastStringStartIndex = -1;
                }
            }
            else
            {
                if (lastStringStartIndex == -1)
                {
                    lastStringStartIndex = p;
                }
            }
        }

        var sb = new StringBuilder();
        sb.Append("/");
        foreach (var dir in list)
        {
            sb.Append(dir);
            sb.Append("/");
        }

        if (sb.Length == 1)
        {
            return "/";
        }
        else
        {
            return sb.ToString()[..^1];
        }
    }
}
