using System.Collections;

namespace TestProject20
{



    public static class Kata
    {
        public static int[] ReverseSeq(int n)
        {
            List<int> array = new List<int>(); 
            
            while (n > 0) 
            {
                array.Add(n);
                n--;
               
            }

            return array.ToArray();
        }
    }



    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(Kata.ReverseSeq(5), Is.EqualTo(new int[] { 5, 4, 3, 2, 1 }));
        }
    }
}