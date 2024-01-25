namespace TestProject6
{
    public class Kata
    {
        public static string Greet(string name, string owner)
        {
            if (name == owner) 
            {
                return "Hello boss";
            
            }
            
            
            return "Hello guest";
        }
    }


    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual("Hello boss", Kata.Greet("Daniel", "Daniel"));
            Assert.AreEqual("Hello guest", Kata.Greet("Greg", "Daniel"));
        }
    }
}