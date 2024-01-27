namespace TestProject13
{
    public static class Kata
    {
        public static string boolToWord(bool word)
        {
            return word ? "Yes" : "No";
        }
    }

    [TestFixture]
    public class boolToWordTest
    {

        [Test]
        public void boolToWordReturned1()
        {
            Assert.AreEqual("Yes", Kata.boolToWord(true));
            Console.WriteLine("Expected Yes");
        }

        [Test]
        public void boolToWordReturned2()
        {
            Assert.AreEqual("No", Kata.boolToWord(false));
            Console.WriteLine("Expected No");
        }

        [Test]
        public void boolToWordReturned3()
        {
            Assert.AreEqual("Yes", Kata.boolToWord(true));
            Console.WriteLine("Expected Yes");
        }
    }
}