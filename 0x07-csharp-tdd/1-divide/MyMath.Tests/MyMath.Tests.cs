using System.Buffers;
using NUnit.Framework;
using System;
using System.Collections.Generic;

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
            int input_1 = 7;
            int input_2 = 3;

            int result = Operations.Add(input_1, input_2);

            Assert.AreEqual(10, result);
        }
    }
}