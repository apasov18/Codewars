using TestProject2;

namespace TestProject2
{



    class Digitizer
    {
        public static long[] Digitize(long number)
        {
            List<long> digits = new List<long>();
            if (number == 0)
            {
                digits.Add(0);

            }

            while (number > 0)
            {
                int count = 0;
                count++;

                long digit = number % 10;
                number /= 10;
               digits.Add(digit);
               
            }

            return digits.ToArray();
        }


        [TestFixture]
        public class SolutionTest
        {
            [Test]
            public void MyTest()
            {
                Assert.AreEqual(new long[] { 1, 3, 2, 5, 3 }, Digitizer.Digitize(35231));
                Assert.AreEqual(new long[] { 0 }, Digitizer.Digitize(0));
            }
        }
    }

}