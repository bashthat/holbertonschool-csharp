using NUnit.Framework;

namespace Text
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(Text.CamelCase("helloWorld"), 2);
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(Text.CamelCase("helloWorld"), 2);
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(Text.CamelCase("helloWorld"), 2);
        }
    }
}