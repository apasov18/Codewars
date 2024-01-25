namespace TestProject9
{
    public static class Kata
    {
        public static int MakeNegative(int number)
        {
            if (number > 0)
            {
                return number * -1;
            }
            return number;
        }
    }

    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(-42, Kata.MakeNegative(42));
        }
    }
}