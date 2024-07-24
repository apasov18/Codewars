namespace TestProject22
{


    public class Kata
    {
        public static bool IsIsogram(string str)
        {
            char[] arrayChar= str.ToLower().ToCharArray();
            for (int i = 0; i < arrayChar.Length; i++) 
            {
                for (int j = i + 1; j < arrayChar.Length; j++)
                {
                    if (arrayChar[i] == arrayChar[j])
                        return false;
                }
            }
            return true;
        }
    }

    public class KataLinq
    {
        public static bool IsIsogram(string str)
        {
            return str.ToLower().Distinct().Count() == str.Length;
        }
    }



    [TestFixture]
    public class BasicTests
    {

        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData("Dermatoglyphics").Returns(true);
                yield return new TestCaseData("isogram").Returns(true);
                yield return new TestCaseData("moose").Returns(false);
                yield return new TestCaseData("isIsogram").Returns(false);
                yield return new TestCaseData("aba").Returns(false);
                yield return new TestCaseData("moOse").Returns(false);
                yield return new TestCaseData("thumbscrewjapingly").Returns(true);
                yield return new TestCaseData("").Returns(true);
            }
        }

        [Test, TestCaseSource("testCases")]
        public bool Test(string str) => Kata.IsIsogram(str);
    }
}