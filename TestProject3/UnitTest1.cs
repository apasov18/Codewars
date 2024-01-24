namespace TestProject3
{
    public class Kata
    {
        public static string Remove_char(string s)
        {
            return  s.Substring(1, s.Length - 2);
        }
    }


    [TestFixture]
    public class Test
    {
        [Test]
        public void Test1()
        {
            StringAssert.AreEqualIgnoringCase("loquen", Kata.Remove_char("eloquent"));
            StringAssert.AreEqualIgnoringCase("ountr", Kata.Remove_char("country"));
            StringAssert.AreEqualIgnoringCase("erso", Kata.Remove_char("person"));
            StringAssert.AreEqualIgnoringCase("lac", Kata.Remove_char("place"));
            StringAssert.AreEqualIgnoringCase("", Kata.Remove_char("ok"));
        }
    }

}