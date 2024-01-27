namespace TestProject15
{
    
    
        public static class Kata
        {
            public static IEnumerable<string> FriendOrFoe(string[] names)
            {
                return names.Where(names => names.Length <= 4);
            }
        }



    


    [TestFixture]
    public class KataTests
    {
        [Test]
        public void Test1()
        {
            string[] expected = { "Ryan", "Mark" };
            string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
            CollectionAssert.AreEqual(expected, Kata.FriendOrFoe(names));
        }
    }


}