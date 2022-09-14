using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace MyMath.Tests\
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
            int[,] matrix = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            int[,] newMatrix = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            int[,] r = MyMath.Matrix.Divide(matrix, 1);
            Assert.AreEqual(newMatrix, r);
        }
        [Test]
        public void Test2()
        {
            int[,] matrix = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            int[,] newMatrix = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            int[,] r = MyMath.Matrix.Divide(matrix, 1);
            Assert.AreEqual(newMatrix, r);
        }
        [Test]
        public void Test3()
        {
            int[,] matrix = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            int[,] newMatrix = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            int[,] r = MyMath.Matrix.Divide(matrix, 1);
            Assert.AreEqual(newMatrix, r);
        }
    }
}