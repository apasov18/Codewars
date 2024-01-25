namespace TestProject5
{
    public static class Kata
    {
        public static int CountSheeps(bool[] sheeps)
        {
            int count = sheeps.Count(b => b);
            return count;

            
        }
    }

    [TestFixture]
    public class CountSheepsTests
    {

        [Test]
        public void SampleTest()
        {
            var sheeps = new bool[] { true, false, true };

            Assert.AreEqual(2, Kata.CountSheeps(sheeps));
        }
    }
}