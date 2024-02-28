using LeetCode;

namespace Tests;

public class TestsMaximumOr
{
    public SolutionMaximumOr Solution { get; private set; }

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
            Assert.That(this.Solution.MaximumOr([16, 82], 4), Is.EqualTo(1328));
            Assert.That(this.Solution.MaximumOr([12, 9], 1), Is.EqualTo(30));
            Assert.That(this.Solution.MaximumOr([8, 1, 2], 2), Is.EqualTo(35));

            // large data
            var txt = File.ReadAllText(Path.Join(AppDomain.CurrentDomain.BaseDirectory, "data", "02680_00.txt"));
            var parts = txt.Split(',');
            var nums = parts.Select(x => Convert.ToInt32(x)).ToArray();
            Assert.That(this.Solution.MaximumOr(nums, 10), Is.EqualTo(1024349700095));
        });
    }
}