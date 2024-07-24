    using NUnit.Framework;
    using System;
    using System.Linq;

namespace TestProject17
{

    public class Kata
    {
        public static string Smash(string[] words)
        {
            if (words == null)
                return "";

            return String.Join(" ", words);

            
        }
    }


    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("hello", Kata.Smash(new string[] { "hello" }));
            Assert.AreEqual("hello world", Kata.Smash(new string[] { "hello", "world" }));
            Assert.AreEqual("hello amazing world", Kata.Smash(new string[] { "hello", "amazing", "world" }));
            Assert.AreEqual("this is a really long sentence", Kata.Smash(new string[] { "this", "is", "a", "really", "long", "sentence" }));
            Assert.AreEqual("", Kata.Smash(new string[] { "" }));
        }
    }
}