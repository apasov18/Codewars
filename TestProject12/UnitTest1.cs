namespace TestProject12
{
    public static class Program
    {
        public static double basicOp(char operation, double value1, double value2)
        {
            if (operation == '+') 
            {
                return value1 + value2; 
            }
            else if (operation == '-')
            {
                return value1 - value2;
            }
             else if (operation == '*')
            {
                return value1 * value2;
            }
             else if (operation == '/')
            {
                return value1 / value2;
            }

            return -1;
        }
    }


    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void StaticTests()
        {
            Assert.AreEqual(11, Program.basicOp('+', 4, 7));
            Assert.AreEqual(-3, Program.basicOp('-', 15, 18));
            Assert.AreEqual(25, Program.basicOp('*', 5, 5));
            Assert.AreEqual(7, Program.basicOp('/', 49, 7));
        }
    }
}