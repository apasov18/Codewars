namespace CodewarsTest
{
    public class SolutionClass
    {
        public static string EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                return "Even";
            }
            else
            {

                return "Odd"; // Code goes here ...
            }

        }
    }


    [TestFixture]
    public class ExampleTests
    {
        [TestCase(1)]
        [TestCase(7)]
        public void PositiveOddTest(int num)
        {
            Assert.AreEqual("Odd", SolutionClass.EvenOrOdd(num));
        }

        [TestCase(2)]
        [TestCase(42)]
        public void PositiveEvenTest(int num)
        {
            Assert.AreEqual("Even", SolutionClass.EvenOrOdd(num));
        }

        [TestCase(-1)]
        [TestCase(-7)]
        public void NegativeOddTest(int num)
        {
            Assert.AreEqual("Odd", SolutionClass.EvenOrOdd(num));
        }

        [TestCase(-2)]
        [TestCase(-42)]
        public void NegativeEvenTest(int num)
        {
            Assert.AreEqual("Even", SolutionClass.EvenOrOdd(num));
        }

        [Test]
        public void ZeroIsEvenTest()
        {
            Assert.AreEqual("Even", SolutionClass.EvenOrOdd(0));
        }
    }
}