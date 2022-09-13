using NUnit.Framework;
// using MyMath;
namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var coffee = MyMath.Operations.Add(-1, -2);
            Assert.AreEqual(-3, coffee);
        }
        [Test(-40, 200)]
        public void Test2(int a, int b)
        {
            var coffee = Operations.Add(a, b);
            Assert.AreEqual(160, coffee);
        }
        [Test]
        public void Test3()
        {
            var coffee = Operations.Add(3, 7);
            Assert.AreEqual(10, coffee);
        }
    }
}