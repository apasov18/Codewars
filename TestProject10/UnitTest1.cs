namespace TestProject10
{
    public class Kata
    {
        public static int FindSmallestInt(int[] args)
        {
            return args.Min(x => x);
        }
    }

    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase(new int[] { 78, 56, 232, 12, 11, 43 }, ExpectedResult = 11)]
        [TestCase(new int[] { 78, 56, -2, 12, 8, -33 }, ExpectedResult = -33)]
        public static int FixedTest(int[] args)
        {
            return Kata.FindSmallestInt(args);
        }
    }
}