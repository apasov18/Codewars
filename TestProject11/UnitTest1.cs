namespace TestProject11
{
    public class TwoToOne
    {

        public static string Longest(string s1, string s2)
        {
            string s3 = s1 + s2;

            var result =  s3.Where(char.IsLetter).Distinct().OrderBy(c=> c);

            string result2 = new string(result.ToArray());
            return result2;
        }
    }

    [TestFixture]
    public static class TwoToOneTests
    {

        [Test]
        public static void test1()
        {
            Assert.AreEqual("aehrsty", TwoToOne.Longest("aretheyhere", "yestheyarehere"));
            Assert.AreEqual("abcdefghilnoprstu", TwoToOne.Longest("loopingisfunbutdangerous", "lessdangerousthancoding"));
            Assert.AreEqual("acefghilmnoprstuy", TwoToOne.Longest("inmanylanguages", "theresapairoffunctions"));
        }
    }
}