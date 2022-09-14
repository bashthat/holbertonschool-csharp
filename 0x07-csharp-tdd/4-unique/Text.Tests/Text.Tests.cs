using System.Reflection;
using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Text.Tests
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
            Assert.AreEqual(Str.UniqueChar("Holberton"), 0);
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(Str.UniqueChar("Holberton School"), 1);
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(Str.UniqueChar("Holberton School Holberton"), 7);
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual(Str.UniqueChar(""), -1);
        }

        [Test]
        public void Test5()
        {
            Assert.AreEqual(Str.UniqueChar("Holberton School Holberton School"), 7);
        }
    }
}