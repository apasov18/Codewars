namespace TestProject4
{
    class AverageSolution
    {
        public static double FindAverage(double[] array)
        {

            double aver = 0;
            if (array == null)
            {
                return 0;
            }
            else
            {
                double c = 0;
                double a = 0;

                for (int i = 0; i <= array.Length - 1; i++)
                {
                    c++;
                    a = a + array[i];
                    aver = a / c;
                }

                
                return aver;
            }
           
        }
    }


    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void ExampleTest()
        {
            double[] array = new double[] { 17, 16, 16, 16, 16, 15, 17, 17, 15, 5, 17, 17, 16 };
            Assert.AreEqual(200.0 / 13.0, AverageSolution.FindAverage(array));

            // Should return 0 on empty array
            Assert.AreEqual(0, AverageSolution.FindAverage(new double[] { }));
        }
    }

}