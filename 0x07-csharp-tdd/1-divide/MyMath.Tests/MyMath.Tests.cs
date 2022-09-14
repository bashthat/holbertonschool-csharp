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
        [Test]
        public void Test2()
        {
            int input_1 = 100;
            int input_2 = 5;

            int result = Operations.Divide(input_1, input_2);

            Assert.AreEqual(20, result);
        }
        [Test]
        public void Test3()
        {
            int input_1 = 100;
            int input_2 = 0;

            int result = Operations.Multiply(input_1, input_2);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void Test4()
        {
            int input_1 = 100;
            int input_2 = 0;

            int result = Operations.Subtract(input_1, input_2);

            Assert.AreEqual(100, result);
        }
        [test]
        public void Test5()
        {
            int input_1 = 100;
            int input_2 = 0;

            int result = Operations.Mod(input_1, input_2);

            Assert.AreEqual(0, result);
        }
        catch (System.Exception)
        {
            
            throw;
        }
    }
}