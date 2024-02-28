using LeetCode;

namespace Tests;

public class TestsCountZeroRequestServers
{
    public SolutionCountZeroRequestServers Solution { get; private set; }

    private static readonly int[] expected1 = [1, 2];
    private static readonly int[] expected2 = [0, 1];
    private static readonly int[] expected3 = [5, 6, 5, 5, 6, 5, 6, 5, 6];

    [SetUp]
    public void Setup()
    {
        this.Solution = new();
    }

    [Test]
    public void Test1()
    {
        Assert.Multiple(() =>
        {
            CollectionAssert.AreEqual(expected1, this.Solution.CountServers(3, [[1, 3], [2, 6], [1, 5]], 5, [10, 11]));
            Console.WriteLine();
            CollectionAssert.AreEqual(expected2, this.Solution.CountServers(3, [[2, 4], [2, 1], [1, 2], [3, 1]], 2, [3, 4]));
            Console.WriteLine();
            CollectionAssert.AreEqual(expected3, this.Solution.CountServers(6, [[1, 21]], 10, [24, 35, 28, 26, 20, 25, 16, 31, 12]));

            //var logslines = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "02747_00.txt"));
            //var logs = logslines.Select(x => x.Split(',')).Select(x => new int[] { Convert.ToInt32(x[0]), Convert.ToInt32(x[0]) }).ToArray();

            //var queriestxt = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "02747_01.txt"));

            //var queries = queriestxt.Split(',').Select(x => Convert.ToInt32(x)).ToArray();

            //CollectionAssert.AreEqual(expected2, this.Solution.CountServers(8648, logs, 4409, queries));
        });
    }
}
