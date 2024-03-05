using LeetCode;

namespace Tests;

public class TestsJumpGameII
{
    public SolutionJumpGameII Solution { get; private set; }

    [SetUp]
    public void Setup()
    {
        this.Solution = new();
    }

    [Test]
    public void Test1()
    {
        {
            int[] input = [3, 2, 1];
            Assert.That(this.Solution.Jump(input), Is.EqualTo(1));
        }
        {
            int[] input = [2, 3, 1, 1, 4];
            Assert.That(this.Solution.Jump(input), Is.EqualTo(2));
        }
        {
            int[] input = [2, 3, 0, 1, 4];
            Assert.That(this.Solution.Jump(input), Is.EqualTo(2));
        }
    }
}
