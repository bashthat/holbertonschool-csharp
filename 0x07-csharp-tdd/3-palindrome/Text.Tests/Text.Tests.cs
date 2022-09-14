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
            var r = Str.IsPalindrome("");
            Assert.AreEqual(true, r);
        }
        [Test]
        public void Test2()
        {
            var r = Str.IsPalindrome("redder");
            Assert.AreEqual(true, r);
        }

        [Test]
        public void Test3()
        {
            var r = Str.IsPalindrome("holberton");
            Assert.AreEqual(false, r);
        }
        [Test]
        public void Test4()
        {
            var r = Str.IsPalindrome("abc");
            Assert.AreEqual(true, r);
        }
        [Test]
        public void Test5()
        {
            var r = Str.IsPalindrome("abccba");
            Assert.AreEqual(true, r);
        }
    }   
}