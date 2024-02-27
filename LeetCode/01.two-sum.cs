namespace LeetCode;

public class SolutionTwoSum
{
    public int[] TwoSum(int[] nums, int target)
    {
        var indexCache = new Dictionary<int, int>();
        // Mapping from value to index.

        foreach (var (currentValue, currentIndex) in nums.Select((x, i) => (x, i)))
        {
            var otherValue = target - currentValue;

            if (indexCache.TryGetValue(otherValue, out var otherIndex))
            {
                // Got the result.
                var solution = new[] { otherIndex, currentIndex };
                return solution;
            }
            else
            {
                // push the index into cache.
                indexCache[currentValue] = currentIndex;
            }
        }

        throw new Exception("Should have at least 1 solution, but got 0.");
    }
}
